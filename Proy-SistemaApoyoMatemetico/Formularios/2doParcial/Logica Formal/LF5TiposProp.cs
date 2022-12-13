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
    public partial class LF5TiposProp : Form
    {
        public LF5TiposProp()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnBoton1_Click(object sender, EventArgs e)
        {
            Dato1.Visible = true;
            Dato2.Visible = false;
            Dato3.Visible = false;
            Dato4.Visible = false;
        }

        private void BtnBoton2_Click(object sender, EventArgs e)
        {
            Dato1.Visible = false;
            Dato2.Visible = true;
            Dato3.Visible = false;
            Dato4.Visible = false;
        }

        private void BtnBoton3_Click(object sender, EventArgs e)
        {
            Dato1.Visible = false;
            Dato2.Visible = false;
            Dato3.Visible = true;
            Dato4.Visible = false;
        }

        private void BtnBoton4_Click(object sender, EventArgs e)
        {
            Dato1.Visible = false;
            Dato2.Visible = false;
            Dato3.Visible = false;
            Dato4.Visible = true;
        }
    }
}
