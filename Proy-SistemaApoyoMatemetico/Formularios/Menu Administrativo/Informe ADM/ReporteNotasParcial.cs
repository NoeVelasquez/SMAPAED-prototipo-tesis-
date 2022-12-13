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
    public partial class ReporteNotasParcial : Form
    {
        public ReporteNotasParcial()
        {
            InitializeComponent();
        }


        private void ReporteNotasParcial_Load_1(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_DataSet_ListaNotaParcial_.Listar_Notas_Parcial' Puede moverla o quitarla según sea necesario.
            this.listar_Notas_ParcialTableAdapter.Fill(this._DataSet_ListaNotaParcial_.Listar_Notas_Parcial);

            this.reportViewer2.RefreshReport();
        }
    }
}
