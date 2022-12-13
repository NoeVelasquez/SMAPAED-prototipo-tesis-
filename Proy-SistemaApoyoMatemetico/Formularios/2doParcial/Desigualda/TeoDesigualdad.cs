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
    public partial class TeoDesigualdad : Form
    {
        public TeoDesigualdad()
        {
            InitializeComponent();
        }

        private void signosDeLaRelaciónToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Signos.Visible = true;
            Transitiva.Visible = false;
            Tricotomia.Visible = false;
            Aditiva.Visible = false;
            Prop1.Visible = false;
            Prop2.Visible = false;
            Prop3.Visible = false;
            Prop4y5.Visible = false;
            Prop6y7.Visible = false;
            Prop8y9.Visible = false;
            Prop10P11y12.Visible = false;
            ID1.Visible = false;
            II2.Visible = false;
            IIA3.Visible = false;
            IE.Visible = false;
        }

        private void leyDeTricotomíaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tricotomia.Visible = true;
            Signos.Visible = false;
            Transitiva.Visible = false;
            Aditiva.Visible = false;
            Multiplicativa.Visible = false;
            Prop1.Visible = false;
            Prop2.Visible = false;
            Prop3.Visible = false;
            Prop4y5.Visible = false;
            Prop6y7.Visible = false;
            Prop8y9.Visible = false;
            Prop10P11y12.Visible = false;
            ID1.Visible = false;
            II2.Visible = false;
            IIA3.Visible = false;
            IE.Visible = false;
        }

        private void leyTransitivaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Transitiva.Visible = true;
            Tricotomia.Visible = false;
            Signos.Visible = false;
            Aditiva.Visible = false;
            Multiplicativa.Visible = false;
            Prop1.Visible = false;
            Prop2.Visible = false;
            Prop3.Visible = false;
            Prop4y5.Visible = false;
            Prop6y7.Visible = false;
            Prop8y9.Visible = false;
            Prop10P11y12.Visible = false;
            ID1.Visible = false;
            II2.Visible = false;
            IIA3.Visible = false;
            IE.Visible = false;
        }

        private void leyAditivaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Aditiva.Visible = true;
            Transitiva.Visible = false;
            Tricotomia.Visible = false;
            Signos.Visible = false;
            Multiplicativa.Visible = false;
            Prop1.Visible = false;
            Prop2.Visible = false;
            Prop3.Visible = false;
            Prop4y5.Visible = false;
            Prop6y7.Visible = false;
            Prop8y9.Visible = false;
            Prop10P11y12.Visible = false;
            ID1.Visible = false;
            II2.Visible = false;
            IIA3.Visible = false;
            IE.Visible = false;
        }

        private void leyMultiplicativaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Multiplicativa.Visible = true;
            Aditiva.Visible = false;
            Transitiva.Visible = false;
            Tricotomia.Visible = false;
            Signos.Visible = false;
            Prop1.Visible = false;
            Prop2.Visible = false;
            Prop3.Visible = false;
            Prop4y5.Visible = false;
            Prop6y7.Visible = false;
            Prop8y9.Visible = false;
            Prop10P11y12.Visible = false;
            ID1.Visible = false;
            II2.Visible = false;
            IIA3.Visible = false;
            IE.Visible = false;
        }

        private void propiedad1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prop1.Visible = true;
            Multiplicativa.Visible = false;
            Aditiva.Visible = false;
            Transitiva.Visible = false;
            Tricotomia.Visible = false;
            Signos.Visible = false;
            Prop2.Visible = false;
            Prop3.Visible = false;
            Prop4y5.Visible = false;
            Prop6y7.Visible = false;
            Prop8y9.Visible = false;
            Prop10P11y12.Visible = false;
            ID1.Visible = false;
            II2.Visible = false;
            IIA3.Visible = false;
            IE.Visible = false;
        }

        private void propiedad2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prop2.Visible = true;
            Prop1.Visible = false;
            Multiplicativa.Visible = false;
            Aditiva.Visible = false;
            Transitiva.Visible = false;
            Tricotomia.Visible = false;
            Signos.Visible = false;
            Prop3.Visible = false;
            Prop4y5.Visible = false;
            Prop6y7.Visible = false;
            Prop8y9.Visible = false;
            Prop10P11y12.Visible = false;
            ID1.Visible = false;
            II2.Visible = false;
            IIA3.Visible = false;
            IE.Visible = false;
        }

        private void propiedad3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prop3.Visible = true;
            Prop2.Visible = false;
            Prop1.Visible = false;
            Multiplicativa.Visible = false;
            Aditiva.Visible = false;
            Transitiva.Visible = false;
            Tricotomia.Visible = false;
            Signos.Visible = false;
            Prop4y5.Visible = false;
            Prop6y7.Visible = false;
            Prop8y9.Visible = false;
            Prop10P11y12.Visible = false;
            ID1.Visible = false;
            II2.Visible = false;
            IIA3.Visible = false;
            IE.Visible = false;
        }

        private void propiedad4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prop4y5.Visible = true;
            Prop3.Visible = false;
            Prop2.Visible = false;
            Prop1.Visible = false;
            Multiplicativa.Visible = false;
            Aditiva.Visible = false;
            Transitiva.Visible = false;
            Tricotomia.Visible = false;
            Signos.Visible = false;
            Prop6y7.Visible = false;
            Prop8y9.Visible = false;
            Prop10P11y12.Visible = false;
            ID1.Visible = false;
            II2.Visible = false;
            IIA3.Visible = false;
            IE.Visible = false;
        }

        private void propiedad5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prop6y7.Visible = true;
            Prop4y5.Visible = false;
            Prop3.Visible = false;
            Prop2.Visible = false;
            Prop1.Visible = false;
            Multiplicativa.Visible = false;
            Aditiva.Visible = false;
            Transitiva.Visible = false;
            Tricotomia.Visible = false;
            Signos.Visible = false;
            Prop8y9.Visible = false;
            Prop10P11y12.Visible = false;
            ID1.Visible = false;
            II2.Visible = false;
            IIA3.Visible = false;
            IE.Visible = false;
        }

        private void propiedad6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prop8y9.Visible = true;
            Prop6y7.Visible = false;
            Prop4y5.Visible = false;
            Prop3.Visible = false;
            Prop2.Visible = false;
            Prop1.Visible = false;
            Multiplicativa.Visible = false;
            Aditiva.Visible = false;
            Transitiva.Visible = false;
            Tricotomia.Visible = false;
            Signos.Visible = false;
            Prop10P11y12.Visible = false;
            ID1.Visible = false;
            II2.Visible = false;
            IIA3.Visible = false;
            IE.Visible = false;
        }

        private void desigualdadesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void propiedad7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prop10P11y12.Visible = true;
            Prop8y9.Visible = false;
            Prop6y7.Visible = false;
            Prop4y5.Visible = false;
            Prop3.Visible = false;
            Prop2.Visible = false;
            Prop1.Visible = false;
            Multiplicativa.Visible = false;
            Aditiva.Visible = false;
            Transitiva.Visible = false;
            Tricotomia.Visible = false;
            Signos.Visible = false;
            ID1.Visible = false;
            II2.Visible = false;
            IIA3.Visible = false;
            IE.Visible = false;
        }

        private void inecuaciónDeterminadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ID1.Visible = true;
            Prop10P11y12.Visible = false;
            Prop8y9.Visible = false;
            Prop6y7.Visible = false;
            Prop4y5.Visible = false;
            Prop3.Visible = false;
            Prop2.Visible = false;
            Prop1.Visible = false;
            Multiplicativa.Visible = false;
            Aditiva.Visible = false;
            Transitiva.Visible = false;
            Tricotomia.Visible = false;
            Signos.Visible = false;
            II2.Visible = false;
            IIA3.Visible = false;
            IE.Visible = false;
        }

        private void inecuaciónIndeterminadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            II2.Visible = true;
            ID1.Visible = false;
            Prop10P11y12.Visible = false;
            Prop8y9.Visible = false;
            Prop6y7.Visible = false;
            Prop4y5.Visible = false;
            Prop3.Visible = false;
            Prop2.Visible = false;
            Prop1.Visible = false;
            Multiplicativa.Visible = false;
            Aditiva.Visible = false;
            Transitiva.Visible = false;
            Tricotomia.Visible = false;
            Signos.Visible = false;
            IIA3.Visible = false;
            IE.Visible = false;
        }

        private void inecuaciónImposibleOAbsurdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IIA3.Visible = true;
            II2.Visible = false;
            ID1.Visible = false;
            Prop10P11y12.Visible = false;
            Prop8y9.Visible = false;
            Prop6y7.Visible = false;
            Prop4y5.Visible = false;
            Prop3.Visible = false;
            Prop2.Visible = false;
            Prop1.Visible = false;
            Multiplicativa.Visible = false;
            Aditiva.Visible = false;
            Transitiva.Visible = false;
            Tricotomia.Visible = false;
            Signos.Visible = false;
            IE.Visible = false;
        }

        private void clasesDeDesigualdadesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void inecuacionesEquivalentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IE.Visible = true;
            IIA3.Visible = false;
            II2.Visible = false;
            ID1.Visible = false;
            Prop10P11y12.Visible = false;
            Prop8y9.Visible = false;
            Prop6y7.Visible = false;
            Prop4y5.Visible = false;
            Prop3.Visible = false;
            Prop2.Visible = false;
            Prop1.Visible = false;
            Multiplicativa.Visible = false;
            Aditiva.Visible = false;
            Transitiva.Visible = false;
            Tricotomia.Visible = false;
            Signos.Visible = false;
        }
    }
}
