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
    public partial class EjemLogica1 : Form
    {
        public EjemLogica1()
        {
            InitializeComponent();
        }

        private void BtnEJ1_Click(object sender, EventArgs e)
        {
            SolucionEj1.Visible = true;
            SolucionEj2.Visible = false;
            SolucionEj3.Visible = false;
        }

        private void BtnEJ2_Click(object sender, EventArgs e)
        {
            SolucionEj1.Visible = false;
            SolucionEj2.Visible = true;
            SolucionEj3.Visible = false;
        
        }

        private void BtnEJ3_Click(object sender, EventArgs e)
        {
            SolucionEj1.Visible = false;
            SolucionEj2.Visible = false;
            SolucionEj3.Visible = true;
        }
    }
}
