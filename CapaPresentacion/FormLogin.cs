using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "")
            {
                if (txtContraseña.Text != "")
                {
                    NUsuarios usuario = new NUsuarios();
                    try
                    {
                        var validLogin = usuario.loginUser(txtUsuario.Text, txtContraseña.Text);
                        if (validLogin == true)
                        {
                            FormPrincipal principal = new FormPrincipal();
                            principal.Show();
                            this.Hide();

                        }
                        else
                        {
                            msgError("Usuario o contraseña incorrecta");
                            txtContraseña.Clear();
                            txtUsuario.Focus();
                        }
                    } catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else msgError("Por favor, ingrese su contraseña");
            }
            else msgError("Ingrese su nombre de Ususario");
        }

        private void msgError(string mensaje)
        {
            lblError.Text = " " + mensaje;
            lblError.Visible = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
