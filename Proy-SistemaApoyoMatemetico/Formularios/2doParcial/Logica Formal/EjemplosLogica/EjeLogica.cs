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
    public partial class EjeLogica : Form
    {
        public EjeLogica()
        {
            InitializeComponent();
        }
        private void AbrirEjemp(object FormHijo)
        {
            if (this.Panel1.Controls.Count > 0)
            {
                this.Panel1.Controls.RemoveAt(0);

            }

            Form fh = FormHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.Panel1.Controls.Add(fh);
            this.Panel1.Tag = fh;
            fh.Show();

        }
        private void tiposDeProposicionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void negacionDeEnunciadosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void queEsElLenguajeFormalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirEjemp(new EjemLogica1());
        }
    }
}
