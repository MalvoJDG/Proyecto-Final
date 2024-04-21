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
    public partial class GuardarConsultas : Form
    {
        UsuarioC usuarioC = new UsuarioC();
        public GuardarConsultas()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            String msj = "";

            try
            {
                usuarioC.Nombre = "Carlos";
                usuarioC.Apellido = "Perez Rodriguez";
                usuarioC.Correo = "CarpR@gmail.com";
                usuarioC.Telefono = "829-762-1032";
                usuarioC.Fecha_cita = dtEntrada.Value;
                usuarioC.razon_consulta = txtUsuario.Text;


                msj = usuarioC.GuardarConsulta();


                MessageBox.Show($"Exito al Guardar la Consulta", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar{ex}", "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
