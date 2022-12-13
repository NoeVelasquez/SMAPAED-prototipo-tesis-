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
    public partial class ListadoEstudianteNotasParcial : Form
    {
        N_Estudiante estu = new N_Estudiante();
        N_Parcial np = new N_Parcial();
        public ListadoEstudianteNotasParcial()
        {
            InitializeComponent();
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            ReporteNotasParcial rN = new ReporteNotasParcial();
            rN.ShowDialog();
        }

        private void ListadoEstudianteNotasParcial_Load(object sender, EventArgs e)
        {
            TablaUsuariosNuevos.DataSource = estu.ListarEstudianteNotasParcial().Tables["tbl"];
            TablaUsuariosNuevos.Columns["IDU"].Visible = false;
            Limpiar();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (TablaUsuariosNuevos.SelectedRows.Count > 0)
            {
                TxtIDU.Text = TablaUsuariosNuevos.CurrentRow.Cells[0].Value.ToString();
                TxtT1.Value = (decimal)TablaUsuariosNuevos.CurrentRow.Cells[3].Value;
                TxtT2.Value = (decimal)TablaUsuariosNuevos.CurrentRow.Cells[4].Value;
                TxtT3.Value = (decimal)TablaUsuariosNuevos.CurrentRow.Cells[5].Value;
                TxtT4.Value = (decimal)TablaUsuariosNuevos.CurrentRow.Cells[6].Value;
                TxtT5.Value = (decimal)TablaUsuariosNuevos.CurrentRow.Cells[7].Value;
                TxtT6.Value = (decimal)TablaUsuariosNuevos.CurrentRow.Cells[8].Value;
                TxtT7.Value = (decimal)TablaUsuariosNuevos.CurrentRow.Cells[9].Value;
                TxtTExaFinal.Value = (decimal)TablaUsuariosNuevos.CurrentRow.Cells[10].Value;
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            E_Parcial p = new E_Parcial();
            string Es = TxtIDU.Text;
            p.Tema1 = (decimal)TxtT1.Value;
            p.Tema2 = (decimal)TxtT2.Value;
            p.Tema3 = (decimal)TxtT3.Value;
            p.Tema4 = (decimal)TxtT4.Value;
            p.Tema5 = (decimal)TxtT5.Value;
            p.Tema6 = (decimal)TxtT6.Value;
            p.Tema7 = (decimal)TxtT7.Value;
            p.ExamenFinal = (decimal)TxtTExaFinal.Value;

            np.ActulizaNotaParcial(p, Es);

            TablaUsuariosNuevos.DataSource = estu.ListarEstudianteNotasParcial().Tables["tbl"];
            Limpiar();
        }

        private void Limpiar()
        {
            TxtIDU.Text = "0";
            TxtT1.Value = 0;
            TxtT2.Value = 0;
            TxtT3.Value = 0;
            TxtT4.Value = 0;
            TxtT5.Value = 0;
            TxtT6.Value = 0;
            TxtT7.Value = 0;
            TxtTExaFinal.Value = 0;
        }
    }
}
