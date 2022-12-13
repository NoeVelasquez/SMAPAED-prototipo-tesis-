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


namespace Proy_SistemaApoyoMatemetico
{
    public partial class RegistrarUsADM : Form
    { //INSTANCI
        private readonly D_Estudiante estudiante = new D_Estudiante();
        N_Estudiante estu = new N_Estudiante();
        public RegistrarUsADM()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {
            TxtIDE.Value = 0;
            TxtIDC.Value = 0;
            TxtNomb.Text = string.Empty;
            TxtApellido.Text = string.Empty;
            TxtCI.Text = string.Empty;
            TxtTelefono.Text = string.Empty;
            TxtCorreo.Text = string.Empty;
            TxtUsuario.Text = string.Empty;
            TxtContraseña.Text = string.Empty;
        }
        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            bool Resultado;
            E_Estudiante est = new E_Estudiante();
            est.IDCargo = (int)TxtIDC.Value;
            est.Nombre = TxtNomb.Text;
            est.Apellido = TxtApellido.Text;
            est.CI = TxtCI.Text;
            est.Telefono = TxtTelefono.Text;
            est.Correo = TxtCorreo.Text;
            est.Usuario = TxtUsuario.Text;
            est.Contraseña = TxtContraseña.Text;

            Resultado = estu.ValidarDatosADM(est);
            if (Resultado == false)
            {
                return;
            }

            estu.CrearEstudianteADM(est);
            // MostrarRegistros();
            Limpiar();
        }
    }
}
