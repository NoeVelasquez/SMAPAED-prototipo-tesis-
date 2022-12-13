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
    public partial class CuestTipFun : Form
    {
        int i, puntos = 0; 
        string Opcorrecto;
        private readonly D_Notas notas = new D_Notas();
        private readonly N_Notas NNota = new N_Notas();
        private readonly Funciones MenFun = new Funciones();
        
        D_Pregunta rc = new D_Pregunta();
        
        
        private int? idbusqueda = null;
        decimal notaex = 0;
        int inc = 0;
        private AgentObjects.IAgentCtlCharacter Avatar;
        decimal resultado = 0;
        int seleccion = 0;
        public CuestTipFun()
        {
            InitializeComponent();
        }
        public CuestTipFun(int idbusqueda) : this()
        {
            this.idbusqueda = idbusqueda;

        }
        private void CuestTipFun_Load(object sender, EventArgs e)
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
                CLblIDE.Text = Convert.ToString(idbusqueda);
            }
            lblNombreCuestionario.Text = rc.scalerReturn("Select Nombre From Usuario where IDU= '" + idbusqueda + "'");
            LblApellido.Text = rc.scalerReturn("Select Apellido From Usuario where IDU= '" + idbusqueda + "'");
            LblNotaPre.Text = rc.scalerReturn("Select PreExamen From Notas where IDU= '" + idbusqueda + "'");
            //LblNotaT1.Text = rc.scalerReturn("Select Tema1 From NotasParcial where IDU= '" + idbusqueda + "'");
            //LblNotaT2.Text = rc.scalerReturn("Select Tema2 From NotasParcial where IDU= '" + idbusqueda + "'");
            //LblNotaT3.Text = rc.scalerReturn("Select Tema3 From NotasParcial where IDU= '" + idbusqueda + "'");
            //LblNotaT4.Text = rc.scalerReturn("Select Tema4 From NotasParcial where IDU= '" + idbusqueda + "'");
            //LblNotaT5.Text = rc.scalerReturn("Select Tema5 From NotasParcial where IDU= '" + idbusqueda + "'");
            //LblNotaT6.Text = rc.scalerReturn("Select Tema6 From NotasParcial where IDU= '" + idbusqueda + "'");


            DatosPuntos.Text = puntos.ToString();
            i = Convert.ToInt32(rc.scalerReturn("select  min (IDPreg) from PreguntaFunDer where IDEx_Fk=8"));
            pregunta.Text = rc.scalerReturn("select Titulo  from PreguntaFunDer where IDPreg = '" + i + "'and IDEx_Fk=8");
            opcion1.Text = rc.scalerReturn("select opA  from PreguntaFunDer where IDPreg = '" + i + "'and IDEx_Fk=8");
            opcion2.Text = rc.scalerReturn("select opB  from PreguntaFunDer where IDPreg = '" + i + "'and IDEx_Fk=8");
            opcion3.Text = rc.scalerReturn("select opC  from PreguntaFunDer where IDPreg = '" + i + "'and IDEx_Fk=8");
            opcion4.Text = rc.scalerReturn("select opD  from PreguntaFunDer where IDPreg = '" + i + "'and IDEx_Fk=8");
            Opcorrecto = rc.scalerReturn("select opCorrecto  from PreguntaFunDer where IDPreg = '" + i + "'and IDEx_Fk=8");
            CantidadPuntos.Text = rc.scalerReturn("Select count(*) From PreguntaFunDer where IDEx_Fk= 8");
            
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
            else if (opcion4.Checked == true)
            {
                selectvalor = opcion4.Text;
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
                int cont = (int)(Convert.ToInt64(CantidadPuntos.Text)/2);
                if (inc >= cont)
                {
                    ControlAgEVA.Characters.Load("merlin", "merlin.acs");
                    //Avatar = (IAgentCtlCharacter)ControlAgTED.Characters["Athena"];
                    Avatar = (IAgentCtlCharacter)ControlAgEVA.Characters["merlin"];
                    Avatar.Show(0);
                    Avatar.MoveTo(800, 234, 1);
                    Avatar.Speak(lblNombreCuestionario.Text +" Debemos de Volver a Repasar la parte teorica, no podras avanzar mas adelante");
                    Avatar.Hide();
                    BtnSiguiente.Enabled = false;
                }
            }
            E_Notas Nt = new E_Notas();
                    string nota = puntos.ToString();
            s = rc.scalerReturn("select min(IDPreg) from PreguntaFunDer where IDPreg > '" + i + "' and IDEx_Fk = 8");
            if (s.Equals(""))
            {
                Nt.PreExamen = Convert.ToInt64(LblNotaPre.Text);
                Nt.ExamenTipFun = Convert.ToInt64(puntos);
                string dato = CLblIDE.Text;
                NNota.ActulizaNota(Nt, dato);

                ControlAgEVA.Characters.Load("merlin", "merlin.acs");
                //Avatar = (IAgentCtlCharacter)ControlAgTED.Characters["Athena"];
                Avatar = (IAgentCtlCharacter)ControlAgEVA.Characters["merlin"];
                Avatar.Show(0);
                Avatar.MoveTo(800, 234, 1);
                Avatar.Speak(lblNombreCuestionario.Text + "Muchas Felicidades tienes" + Nt.ExamenTipFun + "Puedes avanzar ");
                Avatar.Hide();

                LblNotaTIP.Text = resultado.ToString();
                Funciones frm = new Funciones();
                //AddOwnedForm(frm);
                frm.FLblNotaTipFun.Text = LblNotaTIP.Text;
                frm.FlblNombre.Text = lblNombreCuestionario.Text;
                frm.FlblApellido.Text = LblApellido.Text;
                frm.FlblIDE.Text = CLblIDE.Text;
                BtnSiguiente.Enabled = false;
                this.Hide();
            }
            else
            {
                i = Convert.ToInt32(s);
                //byte[] buffer = (byte[])TablaPreguntasEditar.CurrentRow.Cells["Foto"].Value;
                //System.IO.MemoryStream ms = new System.IO.MemoryStream(buffer);
                //PBFoto.Image = System.Drawing.Image.FromStream(ms);
                pregunta.Text = rc.scalerReturn("select Titulo  from PreguntaFunDer where IDPreg = '" + i + "'and IDEx_Fk=8");
                opcion1.Text = rc.scalerReturn("select opA  from PreguntaFunDer where IDPreg = '" + i + "'and IDEx_Fk=8");
                opcion2.Text = rc.scalerReturn("select opB  from PreguntaFunDer where IDPreg = '" + i + "'and IDEx_Fk=8");
                opcion3.Text = rc.scalerReturn("select opC  from PreguntaFunDer where IDPreg = '" + i + "'and IDEx_Fk=8");
                opcion4.Text = rc.scalerReturn("select opD  from PreguntaFunDer where IDPreg = '" + i + "'and IDEx_Fk=8");
                Opcorrecto = rc.scalerReturn("select opCorrecto  from PreguntaFunDer where IDPreg = '" + i + "'and IDEx_Fk=8");
            }
            radiobtn();
            //if (puntos >= 50)
            //        {
            //            Nt.PreExamen = Convert.ToInt64(LblNotaPre.Text);
            //             //Nt.ExamenTipFun = Math.Ceiling(puntos);
            //            Nt.ExamenTipFun = Convert.ToInt64(puntos);
            //            string dato = CLblIDE.Text;
            //            NNota.ActulizaNota(Nt, dato);

            //            //LblNotaTIP.Text = resultado.ToString();
            //            //Funciones frm = new Funciones();
            //            //AddOwnedForm(frm);
            //            //frm.FLblNotaTipFun.Text = LblNotaTIP.Text;
            //            //frm.FlblNombre.Text = lblNombreCuestionario.Text;
            //            //frm.FlblApellido.Text = LblApellido.Text;
            //            //frm.FlblIDE.Text= CLblIDE.Text;
            //            this.Hide();
            //            frm.ShowDialog();
                        
            //            MessageBox.Show("Tienes: " + Nt.ExamenTipFun + "/100", "FELICITACIONES", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            //MessageBox.Show("Bienvenido " + est.Nombre + ", " + est.Apellido);

            //            //LblNotaTIP.Text = resultado.ToString();
            //            //MessageBox.Show(Convert.ToString(LblNotaTIP.Text));
            //            BtnSiguiente.Enabled = false;

            //        }
            //        else
            //        {
            //            Nt.PreExamen = Convert.ToInt64(LblNotaPre.Text);
            //            Nt.ExamenTipFun = Math.Ceiling(resultado) ;
            //            string dato = CLblIDE.Text;
            //            NNota.ActulizaNota(Nt, dato);
            //            LblNotaTIP.Text = resultado.ToString();
                        
            //            Funciones frm = new Funciones();
            //            AddOwnedForm(frm);
            //            frm.FLblNotaTipFun.Text = LblNotaTIP.Text;
            //            frm.FlblNombre.Text = lblNombreCuestionario.Text;
            //            frm.FlblApellido.Text = LblApellido.Text;
            //            frm.FlblIDE.Text = CLblIDE.Text;
            //            frm.FlblNota.Text = LblNotaPre.Text;
            //            this.Hide();
            //            frm.ShowDialog();
            //            //MessageBox.Show("Tienes: " + resultado+ "/100", "DEBES REPASAR MAS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            BtnSiguiente.Enabled = false;
            //            //Application.Exit();
            //        }

        }

        
        public void radiobtn()
        {
            opcion1.Checked = false;
            opcion2.Checked = false;
            opcion3.Checked = false;
            opcion4.Checked = false;
        }
        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ControlAgEVA_ActivateInput(object sender, AxDoubleAgentCtl._DaCtlEvents2_ActivateInputEvent e)
        {

        }

        private void pregunta_TextChanged(object sender, EventArgs e)
        {

        }

        private void opcion1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void opcion2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void opcion3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
