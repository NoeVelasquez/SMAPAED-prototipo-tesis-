using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaEntidad;
using CapaNegocio;

namespace Proy_SistemaApoyoMatemetico.Formularios
{
    public partial class RegistrarUs : Form
    {
        public int xClic, yClic;
        //INSTANCI
        private readonly D_Estudiante estudiante = new D_Estudiante();
        N_Estudiante estu = new N_Estudiante();
        public RegistrarUs()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {
            TxtIDE.Value = 0;
            TxtNomb.Text = string.Empty;
            TxtApellido.Text = string.Empty;
            TxtCI.Text = string.Empty;
            TxtTelefono.Text = string.Empty;
            TxtCorreo.Text = string.Empty;
            TxtUsuario.Text = string.Empty;
            TxtContraseña.Text = string.Empty;
        }
        
        private void RegistrarUs_Load(object sender, EventArgs e)
        {
            
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            bool Resultado;
            E_Estudiante est = new E_Estudiante();
            est.Nombre = TxtNomb.Text;
            est.Apellido =TxtApellido.Text;
            est.CI = TxtCI.Text;
            est.Telefono = TxtTelefono.Text;
            est.Correo = TxtCorreo.Text;
            est.Usuario = TxtUsuario.Text;
            est.Contraseña = TxtContraseña.Text;

            Resultado= estu.ValidarDatos(est);
            if (Resultado == false)
            {
                return;            
            }

            estu.CrearEstudiante(est);
           // MostrarRegistros();
            Limpiar();
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TxtCI_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                xClic = e.X;
                yClic = e.Y;
            }
            else
            {
                this.Left = this.Left + (e.X);
                this.Top = this.Top + (e.Y);
            }
        }
    }
}
