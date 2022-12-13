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
    public partial class CuestFinal2P : Form
    {
        int i, puntos = 0;
        string Opcorrecto;
        private readonly N_Parcial Nota = new N_Parcial();
        D_Pregunta rc = new D_Pregunta();
        private int? idbusqueda = null;

        public CuestFinal2P()
        {
            InitializeComponent();
        }
        public CuestFinal2P(int idbusqueda) : this()
        {
            this.idbusqueda = idbusqueda;

        }
        private void CuestFinal2P_Load(object sender, EventArgs e)
        {
            if (idbusqueda.HasValue)
            {
                DatoIDE.Text = Convert.ToString(idbusqueda);
            }
            lblNombreCuestionario.Text = rc.scalerReturn("Select Nombre From Usuario where IDU= '" + idbusqueda + "'");
            LblApellido.Text = rc.scalerReturn("Select Apellido From Usuario where IDU= '" + idbusqueda + "'");
            LblNotaPre.Text = rc.scalerReturn("Select PreExamen From Notas where IDU= '" + idbusqueda + "'");
            LblNotaT1.Text = rc.scalerReturn("Select Tema1 From NotasParcial where IDU= '" + idbusqueda + "'");
            LblNotaT2.Text = rc.scalerReturn("Select Tema2 From NotasParcial where IDU= '" + idbusqueda + "'");
            LblNotaT3.Text = rc.scalerReturn("Select Tema3 From NotasParcial where IDU= '" + idbusqueda + "'");
            LblNotaT4.Text = rc.scalerReturn("Select Tema4 From NotasParcial where IDU= '" + idbusqueda + "'");
            LblNotaT5.Text = rc.scalerReturn("Select Tema5 From NotasParcial where IDU= '" + idbusqueda + "'");
            LblNotaT6.Text = rc.scalerReturn("Select Tema6 From NotasParcial where IDU= '" + idbusqueda + "'");
            LblNotaT7.Text = rc.scalerReturn("Select Tema7 From NotasParcial where IDU= '" + idbusqueda + "'");


            DatosPuntos.Text = puntos.ToString();
            //i = Convert.ToInt32(rc.scalerReturn("select min (IDPreg) from Preguntas"));
            //TxtPregunta.Text = rc.scalerReturn("select Titulo  from Preguntas where IDPreg = '" + i + "'");
            //Rb1.Text = rc.scalerReturn("select opA  from Preguntas where IDPreg = '" + i + "'");
            //Rb2.Text = rc.scalerReturn("select opB  from Preguntas where IDPreg = '" + i + "'");
            //Rb3.Text = rc.scalerReturn("select opC  from Preguntas where IDPreg = '" + i + "'");
            //Rb4.Text = rc.scalerReturn("select opD  from Preguntas where IDPreg = '" + i + "'");
            //Opcorrecto = rc.scalerReturn("select opCorrecto  from Preguntas where IDPreg = '" + i + "'");
            i = Convert.ToInt32(rc.scalerReturn("select  min (IDPreg) from Preguntas"));
            TxtPregunta.Text = rc.scalerReturn("select Titulo  from Preguntas where IDPreg = '" + i + "'");
            Rb1.Text = rc.scalerReturn("select opA  from Preguntas where IDPreg = '" + i + "'");
            Rb2.Text = rc.scalerReturn("select opB  from Preguntas where IDPreg = '" + i + "'");
            Rb3.Text = rc.scalerReturn("select opC  from Preguntas where IDPreg = '" + i + "'");
            Rb4.Text = rc.scalerReturn("select opD  from Preguntas where IDPreg = '" + i + "'");
            Opcorrecto = rc.scalerReturn("select opCorrecto  from Preguntas where IDPreg = '" + i + "'");
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
            s = rc.scalerReturn("select min(IDPreg) from Preguntas where IDPreg > '" + i + "'");
            if (s.Equals(""))
            {
                Nt.Tema1 = Convert.ToDecimal(LblNotaT1.Text);
                Nt.Tema2 = Convert.ToDecimal(LblNotaT2.Text);
                Nt.Tema3 = Convert.ToDecimal(LblNotaT3.Text);
                Nt.Tema4 = Convert.ToDecimal(LblNotaT4.Text);
                Nt.Tema5 = Convert.ToDecimal(LblNotaT5.Text);
                Nt.Tema6 = Convert.ToDecimal(LblNotaT6.Text);
                Nt.Tema7 = Convert.ToDecimal(LblNotaT7.Text);
                Nt.ExamenFinal = (decimal)puntos;
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
                MS.LblNotaT2.Text = LblNotaT2.Text;
                MS.LblNotaT3.Text = LblNotaT3.Text;
                MS.LblNotaT4.Text = LblNotaT4.Text;
                MS.LblNotaT5.Text = LblNotaT5.Text;
                MS.LblNotaT6.Text = LblNotaT6.Text;
                MS.LblNotaT7.Text = LblNotaT7.Text;
                MS.LblNotaFinal.Text = puntos.ToString();

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
                //string dato= rc.scalerReturn("select Foto from Preguntas where IDPreg = '" + i + "'");
                //byte[] buffer = (byte[])dato;
                //System.IO.MemoryStream ms = new System.IO.MemoryStream(buffer);
                //ImagenPregunta.Image = rc.scalerReturn("select Foto from Preguntas where IDPreg = '" + i + "'");
                TxtPregunta.Text = rc.scalerReturn("select Titulo  from Preguntas where IDPreg = '" + i + "'");
                Rb1.Text = rc.scalerReturn("select opA  from Preguntas where IDPreg = '" + i + "'");
                Rb2.Text = rc.scalerReturn("select opB  from Preguntas where IDPreg = '" + i + "'");
                Rb3.Text = rc.scalerReturn("select opC  from Preguntas where IDPreg = '" + i + "'");
                Rb4.Text = rc.scalerReturn("select opD  from Preguntas where IDPreg = '" + i + "'");
                Opcorrecto = rc.scalerReturn("select opCorrecto  from Preguntas where IDPreg = '" + i + "'");
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
