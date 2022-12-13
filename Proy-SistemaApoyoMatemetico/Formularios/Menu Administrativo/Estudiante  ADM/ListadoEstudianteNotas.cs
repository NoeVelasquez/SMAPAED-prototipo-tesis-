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
    public partial class ListadoEstudianteNotas : Form
    {
        N_Estudiante estu = new N_Estudiante();
        N_Notas nn = new N_Notas();
        public ListadoEstudianteNotas()
        {
            InitializeComponent();
        }

        private void ListadoEstudianteNotas_Load(object sender, EventArgs e)
        {
            TablaUsuariosNuevos.DataSource = estu.ListarEstudianteNotas().Tables["tbl"];
            TablaUsuariosNuevos.Columns["IDU"].Visible = false;
            //E_Estudiante est = new E_Estudiante();
            //est.IDE = (int)TxtIDE.Value;
            //estu.ListarEstudiante()
        }

        private void TablaUsuariosNuevos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            ReporteNotas rN = new ReporteNotas();
            rN.ShowDialog();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (TablaUsuariosNuevos.SelectedRows.Count > 0)
            {
                TxtIDU.Text = TablaUsuariosNuevos.CurrentRow.Cells[0].Value.ToString();
                TxtPreEX.Value= (decimal)TablaUsuariosNuevos.CurrentRow.Cells[3].Value;
                TxtTipFun.Value=(decimal)TablaUsuariosNuevos.CurrentRow.Cells[4].Value;
                TxtDom.Value = (decimal)TablaUsuariosNuevos.CurrentRow.Cells[5].Value;
                TxtExp.Value = (decimal)TablaUsuariosNuevos.CurrentRow.Cells[6].Value;
                TxtTrigo.Value = (decimal)TablaUsuariosNuevos.CurrentRow.Cells[7].Value;
                TxtLogar.Value = (decimal)TablaUsuariosNuevos.CurrentRow.Cells[8].Value;
                TxtTipDer.Value = (decimal)TablaUsuariosNuevos.CurrentRow.Cells[9].Value;
                TxtRegCad.Value = (decimal)TablaUsuariosNuevos.CurrentRow.Cells[10].Value;
                TxtExaFunciones.Value = (decimal)TablaUsuariosNuevos.CurrentRow.Cells[11].Value;
                TxtExaDerivadas.Value = (decimal)TablaUsuariosNuevos.CurrentRow.Cells[12].Value;
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            E_Notas n = new E_Notas();
            string Es = TxtIDU.Text;
            n.PreExamen = (decimal) TxtPreEX.Value;
            n.ExamenTipFun = (decimal)TxtTipFun.Value;
            n.ExamenDominio = (decimal)TxtDom.Value;
            n.ExamenExpo = (decimal)TxtExp.Value;
            n.ExamenTrigo = (decimal)TxtTrigo.Value;
            n.ExamenLogar = (decimal)TxtLogar.Value;
            n.ExamenTipDeriv = (decimal)TxtTipDer.Value;
            n.ExamenRegDer = (decimal)TxtRegCad.Value;
            n.ExamenFinal = (decimal)TxtExaFunciones.Value;
            n.ExamenFinalDerivada = (decimal)TxtExaDerivadas.Value;

           nn.ActulizaNota(n, Es);
            TablaUsuariosNuevos.DataSource = estu.ListarEstudianteNotas().Tables["tbl"];
        }
    }
}
