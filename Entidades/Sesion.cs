namespace Hospital.Entidades
{
    // Sesión en memoria; nunca contiene la contraseña.
    public sealed class Sesion
    {
        public int Id { get; private set; }
        public string Nombre { get; private set; }
        public string Rol { get; private set; }

        public Sesion(int id, string nombre, string rol)
        {
            Id = id;
            Nombre = nombre;
            Rol = rol;
        }
    }
}
