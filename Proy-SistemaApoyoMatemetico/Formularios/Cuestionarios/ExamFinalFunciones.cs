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
    public partial class ExamFinalFunciones : Form
    {
        int i, puntos = 0;
        string Opcorrecto;
        private readonly D_Notas notas = new D_Notas();
        private readonly N_Notas NNota = new N_Notas();
        D_Pregunta rc = new D_Pregunta();

        private int? idbusqueda = null;
        decimal notaex = 0, cantex = 0;
        int inc = 0;
        private AgentObjects.IAgentCtlCharacter Avatar;
        decimal resultado = 0;
        int seleccion = 0;
        public ExamFinalFunciones()
        {
            InitializeComponent();
        }
        public ExamFinalFunciones(int idbusqueda) : this()
        {
            this.idbusqueda = idbusqueda;
        }
        private void ExamFinalFunciones_Load(object sender, EventArgs e)
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
            if (idbusqueda.HasValue)
            {
                LblIDE.Text = Convert.ToString(idbusqueda);
            }
            lblNombre.Text = rc.scalerReturn("Select Nombre From Usuario where IDU= '" + idbusqueda + "'");
            LblApellido.Text = rc.scalerReturn("Select Apellido From Usuario where IDU= '" + idbusqueda + "'");
            LblNotaPre.Text = rc.scalerReturn("Select PreExamen From Notas where IDU= '" + idbusqueda + "'");
            LblNotaTF.Text = rc.scalerReturn("Select ExamenTipFun From Notas where IDU='" + idbusqueda + "'");
            LblNotaDom.Text = rc.scalerReturn("Select ExamenDominio From Notas where IDU= '" + idbusqueda + "'");
            LblNotaExpo.Text = rc.scalerReturn("Select ExamenExpo From Notas where IDU= '" + idbusqueda + "'");
            LblNotaTrig.Text = rc.scalerReturn("Select ExamenTrigo From Notas where IDU= '" + idbusqueda + "'");
            LblNotaLog.Text = rc.scalerReturn("Select ExamenLogar From Notas where IDU= '" + idbusqueda + "'");


            DatosPuntos.Text = puntos.ToString();
            i = Convert.ToInt32(rc.scalerReturn("select  min (IDPreg) from PreguntaFunDer "));
            pregunta.Text = rc.scalerReturn("select Titulo  from PreguntaFunDer where IDPreg = '" + i + "'");
            opcion1.Text = rc.scalerReturn("select opA  from PreguntaFunDer where IDPreg = '" + i + "'");
            opcion2.Text = rc.scalerReturn("select opB  from PreguntaFunDer where IDPreg = '" + i + "'");
            opcion3.Text = rc.scalerReturn("select opC  from PreguntaFunDer where IDPreg = '" + i + "'");
            //opcion4.Text = rc.scalerReturn("select opD  from PreguntaFunDer where IDPreg = '" + i + "'and IDEx_Fk=8");
            Opcorrecto = rc.scalerReturn("select opCorrecto  from PreguntaFunDer where IDPreg = '" + i + "'");
            CantidadPuntos.Text = rc.scalerReturn("Select count(*) From PreguntaFunDer");
            
        }
        string s, selectvalor;
        

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
                cantex = (Convert.ToInt64(CantidadPuntos.Text) / 3);
                //MessageBox.Show(Convert.ToString(cantex));
                notaex = 100 / cantex;
                //MessageBox.Show(Convert.ToString(notaex));
                puntos = (int)(puntos + Math.Floor(notaex)); /*Math.Round(notaex)*/
                DatosPuntos.Text = puntos.ToString();
            }
            else
            {
                MessageBox.Show("Recuerda lo que vimos en la parte Teorica", "Evaluacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                inc = inc + 1;
                int cont = (int)(((Convert.ToInt64(CantidadPuntos.Text)-1) / 3)/2);
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
            s = rc.scalerReturn("select min(IDPreg) from PreguntaFunDer where IDPreg > '" + i + "'");
            if (s.Equals(""))
            {
                Nt.PreExamen = Convert.ToInt64(LblNotaPre.Text);
                Nt.ExamenTipFun = Convert.ToInt64(LblNotaTF.Text);
                Nt.ExamenDominio = Convert.ToInt64(LblNotaDom.Text);
                Nt.ExamenExpo = Convert.ToInt64(LblNotaExpo.Text);
                Nt.ExamenTrigo = Convert.ToInt64(LblNotaTrig.Text);
                Nt.ExamenLogar = Convert.ToInt64(LblNotaLog.Text);
                Nt.ExamenFinal = Convert.ToInt64(puntos);
                string dato = LblIDE.Text;
                NNota.ActulizaNota(Nt, dato);

                ControlAgEVA.Characters.Load("merlin", "merlin.acs");
                //Avatar = (IAgentCtlCharacter)ControlAgTED.Characters["Athena"];
                Avatar = (IAgentCtlCharacter)ControlAgEVA.Characters["merlin"];
                Avatar.Show(0);
                Avatar.MoveTo(800, 234, 1);
                Avatar.Speak(lblNombre.Text + "Muchas Felicidades tienes: " + Nt.ExamenFinal + " Puedes avanzar ");
                Avatar.Hide();

                LblNotaFinal.Text = resultado.ToString();
                Funciones frm = new Funciones();
                AddOwnedForm(frm);
                frm.FLblNFinal.Text = LblNotaFinal.Text;
                frm.FlblNombre.Text = lblNombre.Text;
                frm.FlblApellido.Text = LblApellido.Text;
                frm.FlblIDE.Text = LblIDE.Text;
                frm.FlblNota.Text = LblNotaPre.Text;
                frm.FLblNotaTipFun.Text = LblNotaTF.Text;
                frm.FLblNDom.Text = LblNotaDom.Text;
                frm.FLblNExp.Text = LblNotaExpo.Text;
                frm.FLblNTrig.Text = LblNotaTrig.Text;
                frm.FLblNLog.Text = LblNotaLog.Text;
                        //this.Hide();
                        //frm.ShowDialog();

                        
                        //MessageBox.Show("Bienvenido " + est.Nombre + ", " + est.Apellido);

                        //LblNotaTIP.Text = resultado.ToString();
                        //MessageBox.Show(Convert.ToString(LblNotaTIP.Text));
                BtnSiguiente.Enabled = false;
            }
            else
            {
                i = Convert.ToInt32(s);
                i = i + 2;
                //MessageBox.Show(Convert.ToString( i));
                pregunta.Text = rc.scalerReturn("select Titulo  from PreguntaFunDer where IDPreg = '" + i + "'");
                opcion1.Text = rc.scalerReturn("select opA  from PreguntaFunDer where IDPreg = '" + i + "'");
                opcion2.Text = rc.scalerReturn("select opB  from PreguntaFunDer where IDPreg = '" + i + "'");
                opcion3.Text = rc.scalerReturn("select opC  from PreguntaFunDer where IDPreg = '" + i + "'");
                //opcion4.Text = rc.scalerReturn("select opD  from PreguntaFunDer where IDPreg = '" + i + "'and IDEx_Fk=8");
                Opcorrecto = rc.scalerReturn("select opCorrecto  from PreguntaFunDer where IDPreg = '" + i + "'");
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
