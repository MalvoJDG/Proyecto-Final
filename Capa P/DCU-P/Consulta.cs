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
    public partial class Consulta : Form
    {
        UsuarioC usuarioC = new UsuarioC();
        public Consulta()
        {
            InitializeComponent();
        }

        private void Consulta_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public void Cargar()
        {
            DataTable dt = usuarioC.ListadoConsultas();
            dtaConsulta.DataSource = dt;
        }

        private void Consulta_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form login = new LoginNew();
            login.Show();
            this.Hide();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            if (txtFiltro.Text != "")
            {
                dtaConsulta.CurrentCell = null;
                foreach (DataGridViewRow row in dtaConsulta.Rows)
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
            Form nueva = new ConsultaN();
            nueva.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Cargar();
        }
    }
}
