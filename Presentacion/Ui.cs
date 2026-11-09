using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Hospital.Entidades;
using Hospital.Logica;

namespace Hospital.Presentacion
{
    public static class Ui
    {
        public static void Configurar(Form f, string titulo, int w = 900, int h = 700)
        {
            f.Text = "Sistema Hospital · " + titulo;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ClientSize = new Size(w, h);
            f.Font = new Font("Segoe UI", 10);
            f.AutoScaleMode = AutoScaleMode.Font;
            f.MinimumSize = new Size(650, 450);
        }

        public static Button Boton(string nombre, string texto, EventHandler evento)
        {
            var b = new Button
            {
                Name = nombre,
                Text = texto,
                AutoSize = true,
                Height = 34,
                Margin = new Padding(5)
            };
            b.Click += evento;
            return b;
        }

        public static void Intentar(Action accion)
        {
            try
            {
                accion();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                string mensaje = ex.Number == 2601 || ex.Number == 2627 ? "Ya existe un registro con esos datos o el proceso ya fue registrado." : ex.Number == 1205 ? "Otro usuario modificó los datos al mismo tiempo. Actualice y vuelva a intentar." : ex.Number == 547 ? "Revise las relaciones y restricciones de los datos." : "No se pudo completar la operación de base de datos. Revise la conexión y los valores. Código: " + ex.Number;
                MessageBox.Show(mensaje, "Sistema Hospital", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sistema Hospital", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public static DataGridView Grilla()
        {
            return new DataGridView
            {
                Name = "dgvListado",
                Dock = DockStyle.Fill,
                ReadOnly = true,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                MultiSelect = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells,
                RowHeadersVisible = false
            };
        }
    }
}
