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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        NUsuarios usuario= new NUsuarios();   /*obj cliente*/
        NEstudiante estudiante = new NEstudiante();

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        public void limpiar()
        {
            txtUsuarioCod.Text = "";
            txtUsuarioNom.Text = "";
            txtUsuarioApe.Text = "";
            txtUsuarioNivel.Text = "";
            dataGridUsuarios.DataSource = usuario.listarUsuarios();
        }

        public void limpiarEstudiantes()
        {
            txtEstudienteCod.Text = "";
            txtEstudianteNom.Text = "";
            txtEstudianteApe.Text = "";
            txtEstudianteCI.Text = "";
            txtEstudianteTelef.Text = "";
            txtEstudianteGestion.Clear();
            dataGridEstudiantes.DataSource = estudiante.listarEstudiante();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            dataGridEstudiantes.DataSource = estudiante.listarEstudiante();
            dataGridUsuarios.DataSource = usuario.listarUsuarios();
        }

        /*Crear Usuario*/
        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            string rpta = usuario.crudUsuario(0, txtUsuarioNom.Text, txtUsuarioApe.Text, txtUsuarioNivel.Text, "1");
            MessageBox.Show(rpta);
            limpiar();
        }

        /*Modificar Registro Usuario*/

        private void dataGridUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dataGridUsuarios.CurrentCell.RowIndex;

            txtUsuarioCod.Text = dataGridUsuarios[0, fila].Value.ToString();
            txtUsuarioNom.Text = dataGridUsuarios[1, fila].Value.ToString();
            txtUsuarioApe.Text = dataGridUsuarios[2, fila].Value.ToString();
            txtUsuarioNivel.Text = dataGridUsuarios[3, fila].Value.ToString();
        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            string rpta = usuario.crudUsuario(Convert.ToInt32(txtUsuarioCod.Text), txtUsuarioNom.Text, txtUsuarioApe.Text, txtUsuarioNivel.Text, "2");
            MessageBox.Show(rpta);
            limpiar();
        }

        private void btnUsuarioEliminar_Click(object sender, EventArgs e)
        {
            string rpta = usuario.crudUsuario(Convert.ToInt32(txtUsuarioCod.Text), txtUsuarioNom.Text, txtUsuarioApe.Text, txtUsuarioNivel.Text, "3");
            MessageBox.Show(rpta);
            limpiar();
        }




        /*************Crud de Estudiante******/
        private void dataGridEstudiantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dataGridEstudiantes.CurrentCell.RowIndex;

            txtEstudienteCod.Text = dataGridEstudiantes[0, fila].Value.ToString();
            txtEstudianteCI.Text = dataGridEstudiantes[1, fila].Value.ToString();
            txtEstudianteNom.Text = dataGridEstudiantes[2, fila].Value.ToString();
            txtEstudianteApe.Text = dataGridEstudiantes[3, fila].Value.ToString();
            txtEstudianteTelef.Text = dataGridEstudiantes[4, fila].Value.ToString();
            txtEstudianteGestion.Text = dataGridEstudiantes[5, fila].Value.ToString();

        }

        private void btnCrearEstudiante_Click(object sender, EventArgs e)
        {
            string rpta = estudiante.crudEstudiante(0, Convert.ToInt32(txtEstudianteCI.Text), txtEstudianteNom.Text, txtEstudianteApe.Text,txtEstudianteTelef.Text, Convert.ToInt32(txtEstudianteGestion.Text),"1");
            MessageBox.Show(rpta);
            limpiarEstudiantes();
        }

        private void btnModifcarEstudiante_Click(object sender, EventArgs e)
        {
            string rpta = estudiante.crudEstudiante(Convert.ToInt32(txtEstudienteCod.Text), Convert.ToInt32(txtEstudianteCI.Text), txtEstudianteNom.Text, txtEstudianteApe.Text, txtEstudianteTelef.Text, Convert.ToInt32(txtEstudianteGestion.Text), "2");
            MessageBox.Show(rpta);
            limpiarEstudiantes();
        }

        private void btnEliminarEstudiante_Click(object sender, EventArgs e)
        {
            string rpta = estudiante.crudEstudiante(Convert.ToInt32(txtEstudienteCod.Text), Convert.ToInt32(txtEstudianteCI.Text), txtEstudianteNom.Text, txtEstudianteApe.Text, txtEstudianteTelef.Text, Convert.ToInt32(txtEstudianteGestion.Text), "3");
            MessageBox.Show(rpta);
            limpiarEstudiantes();
        }

































        

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
