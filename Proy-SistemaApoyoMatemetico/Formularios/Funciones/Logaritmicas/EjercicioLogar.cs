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
    public partial class EjercicioLogar : Form
    {
        public EjercicioLogar()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            SolucionEj1.Visible = true;
            SolucionEj2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SolucionEj2.Visible = true;
            SolucionEj1.Visible = false;
        }
    }
}
