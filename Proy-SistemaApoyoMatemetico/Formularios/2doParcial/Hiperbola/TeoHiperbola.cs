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
    public partial class TeoHiperbola : Form
    {
        public TeoHiperbola()
        {
            InitializeComponent();
        }
        EcuaHiperEjeX ejeX = new EcuaHiperEjeX();
        EcuaHiperEjeY ejeY = new EcuaHiperEjeY();
        private void ImagenEjeY_Click(object sender, EventArgs e)
        {
            ejeY.Show();
        }

        private void ImagenEjeX_Click(object sender, EventArgs e)
        {
            ejeX.Show();
        }
    }
}
