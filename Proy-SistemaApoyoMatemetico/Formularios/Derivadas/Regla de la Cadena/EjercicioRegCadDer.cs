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
    public partial class EjercicioRegCadDer : Form
    {
        public EjercicioRegCadDer()
        {
            InitializeComponent();
        }

        private void BtnSolucion_Click(object sender, EventArgs e)
        {
            SolucionEjDer1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SolucionEjDer2.Visible = true;
        }
    }
}
