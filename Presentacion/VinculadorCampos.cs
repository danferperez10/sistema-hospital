using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Hospital.Entidades;
using Hospital.Logica;

namespace Hospital.Presentacion
{
    internal sealed class VinculadorCampos
    {
        readonly Control raiz;
        readonly Campo[] campos;
        public VinculadorCampos(Control raiz, Campo[] campos)
        {
            this.raiz = raiz;
            this.campos = campos;
        }

        Control ControlDe(Campo f)
        {
            string p = f.Tipo == "bool" ? "chk" : f.Tipo == "fecha" || f.Tipo == "fechahora" || f.Tipo == "hora" ? "dtp" : f.Tipo == "entero" || f.Tipo == "decimal" ? "nud" : f.Tipo == "texto" || f.Tipo == "clave" || f.Tipo == "multilinea" ? "txt" : "cbo";
            var c = raiz.Controls.Find(p + f.Nombre, true);
            if (c.Length != 1)
            {
                throw new InvalidOperationException("No se encontró un control único: " + p + f.Nombre);
            }

            return c[0];
        }

        public void Inicializar(Sesion sesion)
        {
            foreach (var f in campos)
            {
                var c = ControlDe(f);
                var combo = c as ComboBox;
                if (combo != null && f.Tipo != "lista")
                {
                    var tabla = Procesos.Opciones(sesion, f.Tipo);
                    var fila = tabla.NewRow();
                    fila["Id"] = 0;
                    fila["Texto"] = "Seleccione...";
                    tabla.Rows.InsertAt(fila, 0);
                    combo.DisplayMember = "Texto";
                    combo.ValueMember = "Id";
                    combo.DataSource = tabla;
                }
            }

            Limpiar();
        }

        public void Limpiar()
        {
            foreach (var f in campos)
            {
                var c = ControlDe(f);
                if (c is CheckBox)
                {
                    ((CheckBox)c).Checked = false;
                }
                else if (c is NumericUpDown)
                {
                    ((NumericUpDown)c).Value = 0;
                }
                else if (c is DateTimePicker)
                {
                    var d = (DateTimePicker)c;
                    d.Value = DateTime.Today;
                    d.Checked = f.Requerido;
                }
                else if (c is ComboBox)
                {
                    var b = (ComboBox)c;
                    if (b.Items.Count > 0)
                    {
                        b.SelectedIndex = 0;
                    }
                }
                else
                {
                    c.Text = "";
                }
            }
        }

        public Dictionary<string, object> Leer()
        {
            var v = new Dictionary<string, object>();
            foreach (var f in campos)
            {
                var c = ControlDe(f);
                object valor;
                if (c is CheckBox)
                {
                    valor = ((CheckBox)c).Checked;
                }
                else if (c is NumericUpDown)
                {
                    valor = ((NumericUpDown)c).Value;
                }
                else if (c is DateTimePicker)
                {
                    var d = (DateTimePicker)c;
                    valor = d.ShowCheckBox && !d.Checked ? null : f.Tipo == "hora" ? (object)new TimeSpan(d.Value.Hour, d.Value.Minute, 0) : f.Tipo == "fecha" ? d.Value.Date : new DateTime(d.Value.Year, d.Value.Month, d.Value.Day, d.Value.Hour, d.Value.Minute, 0);
                }
                else if (c is ComboBox)
                {
                    var b = (ComboBox)c;
                    valor = f.Tipo == "lista" ? b.SelectedItem : b.SelectedValue;
                    if (f.Tipo != "lista" && (valor == null || Convert.ToInt32(valor) == 0))
                    {
                        valor = null;
                    }
                }
                else
                {
                    var texto = f.Tipo == "clave" ? c.Text : c.Text.Trim();
                    valor = texto.Length == 0 ? null : texto;
                }

                v[f.Nombre] = valor;
            }

            return v;
        }

        public void Cargar(DataRow fila)
        {
            foreach (var f in campos)
            {
                var c = ControlDe(f);
                if (f.Tipo == "clave")
                {
                    c.Text = "";
                    continue;
                }

                if (!fila.Table.Columns.Contains(f.Nombre))
                {
                    continue;
                }

                object x = fila[f.Nombre];
                bool vacio = x == DBNull.Value;
                if (c is CheckBox)
                {
                    ((CheckBox)c).Checked = !vacio && Convert.ToBoolean(x);
                }
                else if (c is NumericUpDown)
                {
                    ((NumericUpDown)c).Value = vacio ? 0 : Convert.ToDecimal(x);
                }
                else if (c is DateTimePicker)
                {
                    var d = (DateTimePicker)c;
                    d.Checked = !vacio;
                    if (!vacio)
                    {
                        d.Value = x is TimeSpan ? DateTime.Today.Add((TimeSpan)x) : Convert.ToDateTime(x);
                    }
                }
                else if (c is ComboBox)
                {
                    var b = (ComboBox)c;
                    if (f.Tipo == "lista")
                    {
                        b.SelectedItem = vacio ? null : x;
                    }
                    else
                    {
                        b.SelectedValue = vacio ? 0 : x;
                    }
                }
                else
                {
                    c.Text = vacio ? "" : Convert.ToString(x);
                }
            }
        }
    }
}
