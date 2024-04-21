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
    public partial class LoginNew : Form
    {
        public LoginNew()
        {
            InitializeComponent();
        }

        private void Prueba()
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombreM = txtUsuario.Text;
            string Password = txtPassword.Text;
            switch (txtUsuario.Text)
            {
                case "Papolo":
                    if (txtPassword.Text == "123")
                    {
                        Form consulta = new Consulta();
                        consulta.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show($"Username: {nombreM} , y/o la Password: {Password} son Incorrectas", "error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "Carlos":
                    if (txtPassword.Text == "123")
                    {
                        Form consulta = new Confi();
                        consulta.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show($"Username: {nombreM} , y/o la Password: {Password} son Incorrectas", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                default:

                    MessageBox.Show($"Username: {nombreM} , y/o la Password: {Password} son Incorrectas", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void LoginNew_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }

}
