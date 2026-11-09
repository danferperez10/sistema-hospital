$ErrorActionPreference = 'Stop'
$raiz = $PSScriptRoot
$csc = Join-Path $env:WINDIR 'Microsoft.NET/Framework64/v4.0.30319/csc.exe'
if (-not (Test-Path -LiteralPath $csc)) { throw 'No se encontró el compilador de .NET Framework. Compile desde Visual Studio.' }
$destino = Join-Path $raiz 'compilado'
New-Item -ItemType Directory -Path $destino -Force | Out-Null
function Compilar-Capa($nombre, $referencias, $tipo) {
    $extension = if ($tipo -eq 'winexe') { 'exe' } else { 'dll' }
    $archivo = Join-Path $destino "Hospital.$nombre.$extension"
    $fuentes = @(Get-ChildItem -LiteralPath (Join-Path $raiz $nombre) -Filter '*.cs' | ForEach-Object { $_.FullName })
    $argumentos = @('/nologo', "/target:$tipo", "/out:$archivo", '/reference:System.dll', '/reference:System.Core.dll', '/reference:System.Data.dll', '/reference:System.Configuration.dll')
    foreach ($ref in $referencias) { $argumentos += "/reference:$ref" }
    & $csc @argumentos @fuentes
    if ($LASTEXITCODE -ne 0) { throw "Falló la compilación de $nombre." }
}
Compilar-Capa 'Entidades' @() 'library'
Compilar-Capa 'Datos' @() 'library'
Compilar-Capa 'Logica' @((Join-Path $destino 'Hospital.Entidades.dll'), (Join-Path $destino 'Hospital.Datos.dll')) 'library'
Compilar-Capa 'Presentacion' @((Join-Path $destino 'Hospital.Entidades.dll'), (Join-Path $destino 'Hospital.Logica.dll'), 'System.Drawing.dll', 'System.Windows.Forms.dll') 'winexe'
Copy-Item -LiteralPath (Join-Path $raiz 'Presentacion/App.config') -Destination (Join-Path $destino 'Hospital.Presentacion.exe.config') -Force
Write-Output 'Compilación correcta. Cree la base de datos antes de ejecutar compilado/Hospital.Presentacion.exe.'
