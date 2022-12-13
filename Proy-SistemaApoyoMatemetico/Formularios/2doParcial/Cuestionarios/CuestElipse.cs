using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaEntidad;
using CapaNegocio;


namespace Proy_SistemaApoyoMatemetico
{
    public partial class CuestElipse : Form
    {
        int i, puntos = 0;
        string Opcorrecto;
        private readonly N_Parcial Nota = new N_Parcial();
        D_Pregunta rc = new D_Pregunta();
        private int? idbusqueda = null;

        public CuestElipse()
        {
            InitializeComponent();
        }
        public CuestElipse(int idbusqueda) : this()
        {
            this.idbusqueda = idbusqueda;

        }
        private void CuestElipse_Load(object sender, EventArgs e)
        {
            if (idbusqueda.HasValue)
            {
                DatoIDE.Text = Convert.ToString(idbusqueda);
            }
            lblNombreCuestionario.Text = rc.scalerReturn("Select Nombre From Usuario where IDU= '" + idbusqueda + "'");
            LblApellido.Text = rc.scalerReturn("Select Apellido From Usuario where IDU= '" + idbusqueda + "'");
            LblNotaPre.Text = rc.scalerReturn("Select PreExamen From Notas where IDU= '" + idbusqueda + "'");
            LblNotaT1.Text = rc.scalerReturn("Select Tema1 From NotasParcial where IDU= '" + idbusqueda + "'");

            
            DatosPuntos.Text = puntos.ToString();
            //i = Convert.ToInt32(rc.scalerReturn("select min (IDPreg) from Preguntas"));
            //TxtPregunta.Text = rc.scalerReturn("select Titulo  from Preguntas where IDPreg = '" + i + "'");
            //Rb1.Text = rc.scalerReturn("select opA  from Preguntas where IDPreg = '" + i + "'");
            //Rb2.Text = rc.scalerReturn("select opB  from Preguntas where IDPreg = '" + i + "'");
            //Rb3.Text = rc.scalerReturn("select opC  from Preguntas where IDPreg = '" + i + "'");
            //Rb4.Text = rc.scalerReturn("select opD  from Preguntas where IDPreg = '" + i + "'");
            //Opcorrecto = rc.scalerReturn("select opCorrecto  from Preguntas where IDPreg = '" + i + "'");
            i = Convert.ToInt32(rc.scalerReturn("select  min (IDPreg) from Preguntas where IDEx_Fk=2"));
            TxtPregunta.Text = rc.scalerReturn("select Titulo  from Preguntas where IDPreg = '" + i + "'and IDEx_Fk=2");
            Rb1.Text = rc.scalerReturn("select opA  from Preguntas where IDPreg = '" + i + "'and IDEx_Fk=2");
            Rb2.Text = rc.scalerReturn("select opB  from Preguntas where IDPreg = '" + i + "'and IDEx_Fk=2");
            Rb3.Text = rc.scalerReturn("select opC  from Preguntas where IDPreg = '" + i + "'and IDEx_Fk=2");
            Rb4.Text = rc.scalerReturn("select opD  from Preguntas where IDPreg = '" + i + "'and IDEx_Fk=2");
            Opcorrecto = rc.scalerReturn("select opCorrecto  from Preguntas where IDPreg = '" + i + "'and IDEx_Fk=2");
        }
        string s, selectvalor;

        private void Siguiente_Click(object sender, EventArgs e)
        {
            if (Rb1.Checked == true)
            {
                selectvalor = Rb1.Text;
            }
            else if (Rb2.Checked == true)
            {
                selectvalor = Rb2.Text;
            }
            else if (Rb3.Checked == true)
            {
                selectvalor = Rb3.Text;
            }
            else if (Rb4.Checked == true)
            {
                selectvalor = Rb4.Text;
            }
            else
            {
                MessageBox.Show("Por favor elija una opcion");
            }

            if (selectvalor.Equals(Opcorrecto))
            {
                puntos = puntos + 5;
                DatosPuntos.Text = puntos.ToString();
            }

            E_Parcial Nt = new E_Parcial();
            string nota = puntos.ToString();
            s = rc.scalerReturn("select min(IDPreg) from Preguntas where IDPreg > '" + i + "' and IDEx_Fk = 2");
            if (s.Equals(""))
            {
                Nt.Tema1 = Convert.ToDecimal(LblNotaT1.Text);
                Nt.Tema2 = (decimal)puntos;
                string dato = DatoIDE.Text;
                Nota.ActulizaNotaParcial(Nt, dato);
                MessageBox.Show("Examen Terminado... tu nota es " + nota);
                MenuSegParcial MS = new MenuSegParcial();
                AddOwnedForm(MS);
                // MS.FLblNotaTipFun.Text = LblNotaTIP.Text;
                //CP.lblNombreCuestionario.Text = SGlblNombre.Text;
                //CP.LblApellido.Text = SGlblApellido.Text;
                //CP.DatoIDE.Text = SGlblIDE.Text;
                //MessageBox.Show(CP.DatoIDE.Text);
                //CP.LblNotaPre.Text = SGlblNota.Text;
                MS.SGlblNombre.Text = lblNombreCuestionario.Text;
                MS.SGlblApellido.Text = LblApellido.Text;
                MS.SGlblIDE.Text = DatoIDE.Text;
                MS.LblNotaT1.Text = LblNotaT1.Text;
                MS.LblNotaT2.Text = Nt.Tema2.ToString();
                MS.ShowDialog();
                Siguiente.Enabled = false;
                this.Hide();
            }
            else
            {
                i = Convert.ToInt32(s);

                //TxtPregunta.Text = rc.scalerReturn("select Titulo  from Preguntas where IDPreg = '" + i + "'");
                //Rb1.Text = rc.scalerReturn("select opA  from Preguntas where IDPreg = '" + i + "'");
                //Rb2.Text = rc.scalerReturn("select opB  from Preguntas where IDPreg = '" + i + "'");
                //Rb3.Text = rc.scalerReturn("select opC  from Preguntas where IDPreg = '" + i + "'");
                //Rb4.Text = rc.scalerReturn("select opD  from Preguntas where IDPreg = '" + i + "'");
                //Opcorrecto = rc.scalerReturn("select opCorrecto  from Preguntas where IDPreg = '" + i + "'");
                TxtPregunta.Text = rc.scalerReturn("select Titulo  from Preguntas where IDPreg = '" + i + "'and IDEx_Fk=2");
                Rb1.Text = rc.scalerReturn("select opA  from Preguntas where IDPreg = '" + i + "'and IDEx_Fk=2");
                Rb2.Text = rc.scalerReturn("select opB  from Preguntas where IDPreg = '" + i + "'and IDEx_Fk=2");
                Rb3.Text = rc.scalerReturn("select opC  from Preguntas where IDPreg = '" + i + "'and IDEx_Fk=2");
                Rb4.Text = rc.scalerReturn("select opD  from Preguntas where IDPreg = '" + i + "'and IDEx_Fk=2");
                Opcorrecto = rc.scalerReturn("select opCorrecto  from Preguntas where IDPreg = '" + i + "'and IDEx_Fk=2");
            }
            radiobtn();
        }
        public void radiobtn()
        {
            Rb1.Checked = false;
            Rb2.Checked = false;
            Rb3.Checked = false;
            Rb4.Checked = false;
        }
        
    }
}
