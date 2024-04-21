using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_P.DCU_P
{
    public partial class Confi : Form
    {
        UsuarioC usuarioC = new UsuarioC();
        public Confi()
        {
            InitializeComponent();
            // Obtener el texto del TextBox y limpiarlo
            string filtro = txtFiltro.Text.Trim().ToLower();

            // Filtrar el DataGridView
            FiltrarDataGridView(filtro);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form login = new LoginNew();
            login.Show();
            this.Hide();
        }

        public void Cargar()
        {
            DataTable dt = usuarioC.UsuarioCarlos();
            dtaCarlos.DataSource = dt;
        }

        private void Confi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Confi_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void FiltrarDataGridView(string filtro)
        {
            foreach (DataGridViewRow fila in dtaCarlos.Rows)
            {
                bool mostrarFila = false;

                // Iterar a través de las celdas de la fila
                foreach (DataGridViewCell celda in fila.Cells)
                {
                    // Verificar si el valor de la celda contiene el filtro (ignorando mayúsculas y minúsculas)
                    if (celda.Value != null && celda.Value.ToString().ToLower().Contains(filtro))
                    {
                        mostrarFila = true;
                        break; // No es necesario seguir buscando en otras celdas si ya encontramos una coincidencia
                    }
                }

                // Mostrar u ocultar la fila según el resultado del filtro
                fila.Visible = mostrarFila;
            }
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            if (txtFiltro.Text != "")
            {
                dtaCarlos.CurrentCell = null;
                foreach (DataGridViewRow row in dtaCarlos.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        bool rowVisible = false;
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            if (cell.Value != null && cell.Value.ToString().ToUpper().IndexOf(txtFiltro.Text.ToUpper()) >= 0)
                            {
                                rowVisible = true;
                                break;
                            }
                        }
                        row.Visible = rowVisible;
                    }
                }
            }
            else
            {
                Cargar();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Form nueva = new GuardarConsultas();
            nueva.Show();

        }
    }
}
