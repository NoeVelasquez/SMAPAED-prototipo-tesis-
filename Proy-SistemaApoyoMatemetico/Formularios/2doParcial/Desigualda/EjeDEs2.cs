﻿using System;
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
    public partial class EjeDEs2 : Form
    {
        public EjeDEs2()
        {
            InitializeComponent();
        }

        private void BtnEJ3_Click(object sender, EventArgs e)
        {
            SolucionEj3.Visible = true;
            SolucionEj4.Visible = false;
        }

        private void BtnEJ4_Click(object sender, EventArgs e)
        {
            SolucionEj4.Visible = true;
            SolucionEj3.Visible = false;
        }
    }
}