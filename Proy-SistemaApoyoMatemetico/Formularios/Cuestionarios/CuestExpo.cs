using AgentObjects;
using CapaDatos;
using CapaEntidad;
using CapaNegocio;
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
    public partial class CuestExpo : Form
    {
        private readonly D_Notas notas = new D_Notas();
        private readonly N_Notas NNota = new N_Notas();
        D_Pregunta rc = new D_Pregunta();

        private AgentObjects.IAgentCtlCharacter Avatar;
        decimal resultado = 0;
        int seleccion = 0;
        int i, puntos = 0;
        string Opcorrecto;

        private int? idbusqueda = null;
        decimal notaex = 0;
        int inc = 0;
        
        public CuestExpo()
        {
            InitializeComponent();
        }
        public CuestExpo(int idbusqueda) : this()
        {
            this.idbusqueda = idbusqueda;

        }

        private void CuestExpo_Load(object sender, EventArgs e)
        {
            ControlAgEVA.Characters.Load("Athena", "Athena.acs");
            //ControlAgEVA.Characters.Load("Peedy", "Peedy.acs");
            Avatar = (IAgentCtlCharacter)ControlAgEVA.Characters["Athena"];
            //Avatar = (IAgentCtlCharacter)ControlAgEVA.Characters["Peedy"];
            Avatar.Show(0);
            Avatar.MoveTo(800, 234, 1);
            Avatar.Speak("Hola nuevamente debes de llenar el examen para pasar al siguiente nivel.");
            Avatar.Speak("Mucha Suerte y que la fuerza te acompañe");
            Avatar.Hide();
            //pregunta1();
            if (idbusqueda.HasValue)
            {
                LblIDE.Text = Convert.ToString(idbusqueda);
            }
            lblNombre.Text = rc.scalerReturn("Select Nombre From Usuario where IDU= '" + idbusqueda + "'");
            LblApellido.Text = rc.scalerReturn("Select Apellido From Usuario where IDU= '" + idbusqueda + "'");
            LblNotaPre.Text = rc.scalerReturn("Select PreExamen From Notas where IDU= '" + idbusqueda + "'");
            LblNotaTF.Text = rc.scalerReturn("Select ExamenTipFun From Notas where IDU= '" + idbusqueda + "'");
            LblNotaDom.Text = rc.scalerReturn("Select ExamenDominio From Notas where IDU= '" + idbusqueda + "'");
            //LblNotaExpo.Text = rc.scalerReturn("Select ExamenExpo From Notas where IDU= '" + idbusqueda + "'");


            DatosPuntos.Text = puntos.ToString();
            i = Convert.ToInt32(rc.scalerReturn("select  min (IDPreg) from PreguntaFunDer where IDEx_Fk=10"));
            pregunta.Text = rc.scalerReturn("select Titulo  from PreguntaFunDer where IDPreg = '" + i + "'and IDEx_Fk=10");
            opcion1.Text = rc.scalerReturn("select opA  from PreguntaFunDer where IDPreg = '" + i + "'and IDEx_Fk=10");
            opcion2.Text = rc.scalerReturn("select opB  from PreguntaFunDer where IDPreg = '" + i + "'and IDEx_Fk=10");
            opcion3.Text = rc.scalerReturn("select opC  from PreguntaFunDer where IDPreg = '" + i + "'and IDEx_Fk=10");
            //opcion4.Text = rc.scalerReturn("select opD  from PreguntaFunDer where IDPreg = '" + i + "'and IDEx_Fk=8");
            Opcorrecto = rc.scalerReturn("select opCorrecto  from PreguntaFunDer where IDPreg = '" + i + "'and IDEx_Fk=10");
            CantidadPuntos.Text = rc.scalerReturn("Select count(*) From PreguntaFunDer where IDEx_Fk= 10");
        }
        
        private void pregunta5()
        {
            this.pregunta.Text = "Un cultivo de bacterias, con un número inicial de 1000 bacterias,\n" +
                " dobla su tamaño cadahora. Encuentra una fórmula para el número N(t) de bacterias \n " +
                " presentes después de thoras. Cuantas bacterias estarán presentes después \n" +
                "de 8 horas. ";
            //this.PboxFoto.Image = Proy_SistemaApoyoMatemetico.Properties.Resources.EP5;
            this.opcion1.Text = "N(8) = 1000(28) = 25,6000. ";
            this.opcion2.Text = "N(8) = 1000(8) = 26,000. ";
            this.opcion3.Text = "N(8) = 1000(28) = 256,000. "; // Correcto
            //this.opcion4.Text = "Una semicircunferencia centrada en (1,0) y radio 2";
            seleccion++;
        }
        //PReguntas derivadas
        private void pregunta6()
        {
            this.pregunta.Text = "La población proyectada P de una ciudad esta dada por P = 100,000e0.05t,\n" +
                "Donde t es el número de años después de 1990.Predecir la población para el año 2010";
            this.opcion1.Text = "P ≈ 100,000(2.1828) = 21.828.";
            this.opcion2.Text = "P ≈ 100,000(2.71828) = 271.828.";//Correcto
            this.opcion3.Text = "P ≈ 100,000(217.1828) = 217.828.";
            //this.opcion4.Text = "V = -3";
            seleccion++;
        }
        string s, selectvalor;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            Funciones MF = new Funciones();
            if (opcion1.Checked == true)
            {
                selectvalor = opcion1.Text;
            }
            else if (opcion2.Checked == true)
            {
                selectvalor = opcion2.Text;
            }
            else if (opcion3.Checked == true)
            {
                selectvalor = opcion3.Text;
            }
            else
            {
                MessageBox.Show("Por favor elija una opcion");
            }

            if (selectvalor.Equals(Opcorrecto))
            {
                notaex = 100 / Convert.ToInt64(CantidadPuntos.Text);
                puntos = (int)(puntos + Math.Round(notaex));
                DatosPuntos.Text = puntos.ToString();
            }
            else
            {
                MessageBox.Show("Recuerda lo que vimos en la parte Teorica", "Evaluacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                inc = inc + 1;
                int cont = (int)(Convert.ToInt64(CantidadPuntos.Text) / 2);
                if (inc >= cont)
                {
                    ControlAgEVA.Characters.Load("merlin", "merlin.acs");
                    //Avatar = (IAgentCtlCharacter)ControlAgTED.Characters["Athena"];
                    Avatar = (IAgentCtlCharacter)ControlAgEVA.Characters["merlin"];
                    Avatar.Show(0);
                    Avatar.MoveTo(800, 234, 1);
                    Avatar.Speak(lblNombre.Text + " Debemos de Volver a Repasar la parte teorica, no podras avanzar mas adelante");
                    Avatar.Hide();
                    BtnSiguiente.Enabled = false;
                }
            }
            E_Notas Nt = new E_Notas();
            string nota = puntos.ToString();
            s = rc.scalerReturn("select min(IDPreg) from PreguntaFunDer where IDPreg > '" + i + "' and IDEx_Fk = 10");
            if (s.Equals(""))
            {
                Nt.PreExamen = Convert.ToInt64(LblNotaPre.Text);
                Nt.ExamenTipFun = Convert.ToInt64(LblNotaTF.Text);
                Nt.ExamenDominio = Convert.ToInt64(LblNotaDom.Text);
                Nt.ExamenExpo = Convert.ToInt64(puntos);
                /*Math.Ceiling(resultado);*/
                string dato = LblIDE.Text;
                NNota.ActulizaNota(Nt, dato);

                ControlAgEVA.Characters.Load("merlin", "merlin.acs");
                Avatar = (IAgentCtlCharacter)ControlAgEVA.Characters["merlin"];
                Avatar.Show(0);
                Avatar.MoveTo(800, 234, 1);
                Avatar.Speak(lblNombre.Text + "Muchas Felicidades tienes" + Nt.ExamenExpo + "Puedes avanzar ");
                Avatar.Hide();


                LblNotaExpo.Text = resultado.ToString();
                Funciones frm = new Funciones();
               //AddOwnedForm(frm);
                frm.FLblNExp.Text = LblNotaExpo.Text;
                frm.FlblNombre.Text = lblNombre.Text;
                frm.FlblApellido.Text = LblApellido.Text;
                frm.FlblIDE.Text = LblIDE.Text;
                frm.FlblNota.Text = LblNotaPre.Text;
                frm.FLblNotaTipFun.Text = LblNotaTF.Text;
                frm.FLblNDom.Text = LblNotaDom.Text;
                BtnSiguiente.Enabled = false;
                this.Hide();
               //frm.ShowDialog();

            }
            else
            {
                i = Convert.ToInt32(s);
                //byte[] buffer = (byte[])TablaPreguntasEditar.CurrentRow.Cells["Foto"].Value;
                //System.IO.MemoryStream ms = new System.IO.MemoryStream(buffer);
                //PBFoto.Image = System.Drawing.Image.FromStream(ms);
                pregunta.Text = rc.scalerReturn("select Titulo  from PreguntaFunDer where IDPreg = '" + i + "'and IDEx_Fk=10");
                opcion1.Text = rc.scalerReturn("select opA  from PreguntaFunDer where IDPreg = '" + i + "'and IDEx_Fk=10");
                opcion2.Text = rc.scalerReturn("select opB  from PreguntaFunDer where IDPreg = '" + i + "'and IDEx_Fk=10");
                opcion3.Text = rc.scalerReturn("select opC  from PreguntaFunDer where IDPreg = '" + i + "'and IDEx_Fk=10");
                //opcion4.Text = rc.scalerReturn("select opD  from PreguntaFunDer where IDPreg = '" + i + "'and IDEx_Fk=8");
                Opcorrecto = rc.scalerReturn("select opCorrecto  from PreguntaFunDer where IDPreg = '" + i + "'and IDEx_Fk=10");
            }
            radiobtn();
        }

        public void radiobtn()
        {
            opcion1.Checked = false;
            opcion2.Checked = false;
            opcion3.Checked = false;
            //opcion4.Checked = false;
        }
    }
}
