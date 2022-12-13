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
    public partial class EjemLogica2 : Form
    {
        public EjemLogica2()
        {
            InitializeComponent();
        }

        private void BtnEJ4_Click(object sender, EventArgs e)
        {
            SolucionEj5.Visible = false;
            SolucionEj4.Visible = true;
        }

        private void BtnEJ5_Click(object sender, EventArgs e)
        {
            SolucionEj5.Visible = true;
            SolucionEj4.Visible = false;
        }
    }
}
