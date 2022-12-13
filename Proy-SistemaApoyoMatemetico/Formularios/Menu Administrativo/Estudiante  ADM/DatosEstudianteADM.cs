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
    public partial class DatosEstudianteADM : Form
    {
        private readonly D_Estudiante estudiante = new D_Estudiante();
        N_Estudiante estu = new N_Estudiante();
        public DatosEstudianteADM()
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
        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (TablaUsuariosNuevos.SelectedRows.Count > 0)
            {
                TxtIDE.Value = (int)TablaUsuariosNuevos.CurrentRow.Cells[0].Value;
                TxtIDC.Value = (int)TablaUsuariosNuevos.CurrentRow.Cells[1].Value;
                TxtNomb.Text = TablaUsuariosNuevos.CurrentRow.Cells[2].Value.ToString();
                TxtApellido.Text = TablaUsuariosNuevos.CurrentRow.Cells[3].Value.ToString();
                TxtCI.Text = TablaUsuariosNuevos.CurrentRow.Cells[4].Value.ToString();
                TxtTelefono.Text = TablaUsuariosNuevos.CurrentRow.Cells[5].Value.ToString();
                TxtCorreo.Text = TablaUsuariosNuevos.CurrentRow.Cells[6].Value.ToString();
                TxtUsuario.Text = TablaUsuariosNuevos.CurrentRow.Cells[7].Value.ToString();
                TxtContraseña.Text = TablaUsuariosNuevos.CurrentRow.Cells[8].Value.ToString();

            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void DatosEstudianteADM_Load(object sender, EventArgs e)
        {
            TablaUsuariosNuevos.DataSource = estu.ListarEstudiante().Tables["tbl"];
            TablaUsuariosNuevos.Columns["IDU"].Visible = false;
            TablaUsuariosNuevos.Columns["IDC"].Visible = false;
            TablaUsuariosNuevos.Columns["usuar"].Visible = false;
            TablaUsuariosNuevos.Columns["Contraseña"].Visible = false;
            TablaUsuariosNuevos.Columns["CreacionDatos"].Visible = false;
            TablaUsuariosNuevos.Columns["Actualizacion"].Visible = false;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (TxtIDE.Value == 0)
            {
                return;
            }
            if (MessageBox.Show("¿En serio quieres Eliminar el Registro?", "Titulo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                E_Estudiante est = new E_Estudiante();
                est.IDE = (int)TxtIDE.Value;
                estu.EliminarEstudiante(est);
                TablaUsuariosNuevos.DataSource = estu.ListarEstudiante().Tables["tbl"];
                Limpiar();
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            E_Estudiante est = new E_Estudiante();
            est.IDE = (int)TxtIDE.Value;
            est.IDCargo = (int)TxtIDC.Value;
            est.Nombre = TxtNomb.Text;
            est.Apellido = TxtApellido.Text;
            est.CI = TxtCI.Text;
            est.Telefono = TxtTelefono.Text;
            est.Correo = TxtCorreo.Text;
            est.Usuario = TxtUsuario.Text;
            est.Contraseña = TxtContraseña.Text;
            estu.ActualizarEstudiante(est);
            Limpiar();
            TablaUsuariosNuevos.DataSource = estu.ListarEstudiante().Tables["tbl"];
        }
    }
}
