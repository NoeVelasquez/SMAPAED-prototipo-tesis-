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

        }

        private void BtnActualizar_Click_1(object sender, EventArgs e)
        {
           /* FormMantCliente frm = new FormMantCliente();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                frm.txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                frm.txtnombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                frm.txtapellido.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                frm.txtci.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                frm.txttelefono.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

                frm.ShowDialog();

            }
            else
                MessageBox.Show("seleccione una fila por favor");*/
        }
    }
}
