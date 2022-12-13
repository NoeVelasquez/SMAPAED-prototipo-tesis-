using CapaDatos;
using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proy_SistemaApoyoMatemetico
{
    public partial class DatosEstudiante : Form
    {
        private readonly D_Estudiante estudiante = new D_Estudiante();
        N_Estudiante estu = new N_Estudiante();

        public DatosEstudiante()
        {
            InitializeComponent();
        }
        private void MostrarRegistros()
        {
            TablaUsuariosNuevos.DataSource = estudiante.MostrarRegistros();
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
            /*E_Estudiante est = new E_Estudiante();
            est.IDE = (int)TxtIDE.Value;
            est.Nombre = TxtNomb.Text;
            est.Apellido = TxtApellido.Text;
            est.CI = TxtCI.Text;
            est.Telefono = TxtTelefono.Text;
            est.Correo = TxtCorreo.Text;
            est.Usuario = TxtUsuario.Text;
            est.Contraseña = TxtContraseña.Text;*/
           
        }

        private void TablaUsuariosNuevos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           /* TxtIDE.Value = (int)TablaUsuariosNuevos.CurrentRow.Cells["IDE"].Value;
            TxtNomb.Text = TablaUsuariosNuevos.CurrentRow.Cells["Nombre"].Value.ToString();
            TxtApellido.Text = TablaUsuariosNuevos.CurrentRow.Cells["Apellido"].Value.ToString();
            TxtCI.Text = TablaUsuariosNuevos.CurrentRow.Cells["CI"].Value.ToString();
            TxtTelefono.Text = TablaUsuariosNuevos.CurrentRow.Cells["Telefono"].Value.ToString();
            TxtCorreo.Text = TablaUsuariosNuevos.CurrentRow.Cells["Correo"].Value.ToString();
            TxtUsuario.Text = TablaUsuariosNuevos.CurrentRow.Cells["Usuario"].Value.ToString();
            TxtContraseña.Text = TablaUsuariosNuevos.CurrentRow.Cells["Contraseña"].Value.ToString();*/
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
           /* if (TxtIDE.Value == 0)
            {
                return;
            }
            if (MessageBox.Show("¿En serio quieres Eliminar el Registro?", "Titulo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                E_Estudiante est = new E_Estudiante();
                est.IDE = (int)TxtIDE.Value;
                estu.EliminarEstudiante(est);
                MostrarRegistros();
                Limpiar();
            }*/
        }

        private void DatosEstudiante_Load(object sender, EventArgs e)
        {
            TablaUsuariosNuevos.DataSource = estu.ListarEstudiante().Tables["tbl"];
            TablaUsuariosNuevos.Columns["IDU"].Visible = false;
            TablaUsuariosNuevos.Columns["IDC"].Visible = false;
            TablaUsuariosNuevos.Columns["usuar"].Visible = false;
            TablaUsuariosNuevos.Columns["Contraseña"].Visible = false;
            TablaUsuariosNuevos.Columns["CreacionDatos"].Visible = false;
            TablaUsuariosNuevos.Columns["Actualizacion"].Visible = false;
        }

        private void BtnActualizar_Click_1(object sender, EventArgs e)
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

        private void BtnRegistrar_Click(object sender, EventArgs e)
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

        private void BtnEliminar_Click_1(object sender, EventArgs e)
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
    }
}
//[IDU]
//      ,[IDC]
//      ,[Nombre]
//      ,[Apellido]
//      ,[CI]
//      ,[Telefono]
//      ,[Correo]
//      ,[usuar]
//      ,[Contraseña]
//      ,[CreacionDatos]
//      ,[Actualizacion] 