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
    public partial class EjeNumReal2 : Form
    {
        public EjeNumReal2()
        {
            InitializeComponent();
        }

        private void BtnEJ3_Click(object sender, EventArgs e)
        {
            SolucionEj3.Visible = true;
            SolucionEj4.Visible = false;
            SolucionEj5.Visible = false;
            SolucionEj5.Visible = false;
        }

        private void BtnEJ4_Click(object sender, EventArgs e)
        {
            SolucionEj4.Visible = true;
            SolucionEj3.Visible = false;
            SolucionEj5.Visible = false;
            SolucionEj5.Visible = false;
        }

        private void BtnEJ5_Click(object sender, EventArgs e)
        {
            SolucionEj5.Visible = true;
            SolucionEj4.Visible = false;
            SolucionEj3.Visible = false;
            SolucionEj5.Visible = false;
        }

        private void BtnEJ6_Click(object sender, EventArgs e)
        {
            SolucionEj6.Visible = true;
            SolucionEj5.Visible = false;
            SolucionEj4.Visible = false;
            SolucionEj3.Visible = false;
        }
    }
}
