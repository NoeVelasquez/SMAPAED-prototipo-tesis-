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
    public partial class EcuaHiperEjeX : Form
    {
        public EcuaHiperEjeX()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Parte2.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Parte3.Visible = true;
        }
    }
}
