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
    public partial class CuesRegCadena : Form
    {
        private readonly D_Notas notas = new D_Notas();
        private readonly N_Notas NNota = new N_Notas();
        private int? idbusqueda = null;
        D_Pregunta rc = new D_Pregunta();

        private AgentObjects.IAgentCtlCharacter Avatar;
        decimal resultado = 0;
        int seleccion = 0;
        public CuesRegCadena()
        {
            InitializeComponent();
        }
        public CuesRegCadena(int idbusqueda) : this()
        {
            this.idbusqueda = idbusqueda;

        }
        private void CuesRegCadena_Load(object sender, EventArgs e)
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
            LblNotaTF.Text = rc.scalerReturn("Select ExamenTipFun From Notas where IDU= '" + idbusqueda + "'");
            LblNotaDom.Text = rc.scalerReturn("Select ExamenDominio From Notas where IDU= '" + idbusqueda + "'");
            LblNotaExpo.Text = rc.scalerReturn("Select ExamenExpo From Notas where IDU= '" + idbusqueda + "'");
            LblNotaTrig.Text = rc.scalerReturn("Select ExamenTrigo From Notas where IDU= '" + idbusqueda + "'");
            LblNotaLog.Text = rc.scalerReturn("Select ExamenLogar From Notas where IDU= '" + idbusqueda + "'");
            LblNotaFinal.Text = rc.scalerReturn("Select ExamenFinal From Notas where IDU= '" + idbusqueda + "'");
            LblNotaTipDeriv.Text = rc.scalerReturn("Select ExamenTipDeriv From Notas where IDU= '" + idbusqueda + "'");
            pregunta1();
        }
        private void pregunta1()
        {
            this.pregunta.Text = "Calcula la derivada de la siguiente composición de funciones con la regla de la cadena:";
            this.PreguntaEX.Image = Proy_SistemaApoyoMatemetico.Properties.Resources.P1RC;
            this.opcion1.Text = ""; // Correcto
            this.PboxFoto.Image = Proy_SistemaApoyoMatemetico.Properties.Resources.RP1RC;
            this.opcion2.Text = "";
            this.PboxFoto1.Image = Proy_SistemaApoyoMatemetico.Properties.Resources.RP2RC;
            this.opcion3.Text = "";
            this.PboxFoto2.Image = Proy_SistemaApoyoMatemetico.Properties.Resources.RP3RC;
            //this.opcion4.Text = "120";
            seleccion++;
        }
        private void regunta2()
        {
            this.pregunta.Text = "Calcula la derivada de la siguiente composición de funciones con la regla de la cadena:";
            this.PreguntaEX.Image = Proy_SistemaApoyoMatemetico.Properties.Resources.P2RC;
            this.opcion1.Text = ""; 
            this.PboxFoto.Image = Proy_SistemaApoyoMatemetico.Properties.Resources.R2P3RC;
            this.opcion2.Text = "";// Correcto
            this.PboxFoto1.Image = Proy_SistemaApoyoMatemetico.Properties.Resources.R2P2RC;
            this.opcion3.Text = "";
            this.PboxFoto2.Image = Proy_SistemaApoyoMatemetico.Properties.Resources.RP1RC;
            seleccion++;
        }
        private void pregunta3()
        {
            this.pregunta.Text = "Calcula la derivada de la siguiente composición de funciones con la regla de la cadena:";
            this.PreguntaEX.Image = Proy_SistemaApoyoMatemetico.Properties.Resources.P3RC;
            this.opcion1.Text = "";
            this.PboxFoto.Image = Proy_SistemaApoyoMatemetico.Properties.Resources.R1P3RC;
            this.opcion2.Text = "";// Correcto
            this.PboxFoto1.Image = Proy_SistemaApoyoMatemetico.Properties.Resources.R2P3RC;
            this.opcion3.Text = "";
            this.PboxFoto1.Image = Proy_SistemaApoyoMatemetico.Properties.Resources.RP2RC;
            seleccion++;
        }
        //PReguntas derivadas
        private void pregunta4()
        {
            this.pregunta.Text = "Calcula la derivada de la siguiente composición de funciones con la regla de la cadena:";
            this.PreguntaEX.Image = Proy_SistemaApoyoMatemetico.Properties.Resources.P4RC;
            this.opcion1.Text = "";
            this.PboxFoto.Image = Proy_SistemaApoyoMatemetico.Properties.Resources.R1P4RC;
            this.opcion2.Text = "";
            this.PboxFoto1.Image = Proy_SistemaApoyoMatemetico.Properties.Resources.R2P4RC;
            this.opcion3.Text = "";// Correcto
            this.PboxFoto2.Image = Proy_SistemaApoyoMatemetico.Properties.Resources.R3P4RC;
            seleccion++;
        }
        private void Limpiar()
        {
            this.opcion1.Checked = false;
            this.opcion2.Checked = false;
            this.opcion3.Checked = false;
            //this.opcion4.Checked = false;
        }
        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            switch (seleccion)
            {
                case 1:
                    if (this.opcion1.Checked == true)
                    {
                        resultado = resultado + (decimal)25;
                    }
                    regunta2();
                    Limpiar();
                    break;

                case 2:
                    if (this.opcion2.Checked == true)
                    {
                        resultado = resultado + (decimal)25;
                    }
                    pregunta3();
                    Limpiar();
                    break;

                case 3:
                    if (this.opcion2.Checked == true)//1
                    {
                        resultado = resultado + (decimal)25;
                    }
                    pregunta4();
                    Limpiar();
                    break;

                case 4:
                    if (this.opcion3.Checked == true)//3
                    {
                        resultado = resultado + (decimal)25;
                    }


                    E_Notas Nt = new E_Notas();
                    string nota = resultado.ToString();
                    E_Notas N = new E_Notas();
                    if (resultado >= 50)
                    {

                        Nt.PreExamen = Convert.ToInt64(LblNotaPre.Text);
                        Nt.ExamenTipFun = Convert.ToInt64(LblNotaTF.Text);
                        Nt.ExamenDominio = Convert.ToInt64(LblNotaDom.Text);
                        Nt.ExamenExpo = Convert.ToInt64(LblNotaExpo.Text);
                        Nt.ExamenTrigo = Convert.ToInt64(LblNotaTrig.Text);
                        Nt.ExamenLogar = Convert.ToInt64(LblNotaLog.Text);
                        Nt.ExamenFinal = Convert.ToInt64(LblNotaFinal.Text);
                        Nt.ExamenTipDeriv = Convert.ToInt64(LblNotaTipDeriv.Text);
                        Nt.ExamenRegDer = Math.Ceiling(resultado);
                        string dato = LblIDE.Text;
                        NNota.ActulizaNota(Nt, dato);

                        LblNotaRegCadena.Text = resultado.ToString();
                        Derivadas frm = new Derivadas();
                        AddOwnedForm(frm);
                        frm.DlblNotaRegCadena.Text = LblNotaRegCadena.Text;
                        frm.FlblNombre.Text = lblNombre.Text;
                        frm.FlblApellido.Text = LblApellido.Text;
                        frm.FlblIDE.Text = LblIDE.Text;
                        frm.FlblNota.Text = LblNotaPre.Text;
                        frm.DlblNotaTipDeriv.Text = LblNotaTipDeriv.Text;
                        //this.Hide();
                        //frm.ShowDialog();

                        MessageBox.Show("Tienes: " + Nt.ExamenRegDer + "/100", "FELICITACIONES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //MessageBox.Show("Bienvenido " + est.Nombre + ", " + est.Apellido);

                        //LblNotaTIP.Text = resultado.ToString();
                        //MessageBox.Show(Convert.ToString(LblNotaTIP.Text));
                        BtnSiguiente.Enabled = false;

                    }
                    else
                    {
                        Nt.PreExamen = Convert.ToInt64(LblNotaPre.Text);
                        Nt.ExamenTipFun = Convert.ToInt64(LblNotaTF.Text);
                        Nt.ExamenDominio = Convert.ToInt64(LblNotaDom.Text);
                        Nt.ExamenExpo = Convert.ToInt64(LblNotaExpo.Text);
                        Nt.ExamenTrigo = Convert.ToInt64(LblNotaTrig.Text);
                        Nt.ExamenLogar = Convert.ToInt64(LblNotaLog.Text);
                        Nt.ExamenFinal = Convert.ToInt64(LblNotaFinal.Text);
                        Nt.ExamenTipDeriv = Convert.ToInt64(LblNotaTipDeriv.Text);
                        Nt.ExamenRegDer = Math.Ceiling(resultado);
                        string dato = LblIDE.Text;
                        NNota.ActulizaNota(Nt, dato);

                        LblNotaRegCadena.Text = resultado.ToString();
                        MessageBox.Show("Tienes: " + Nt.ExamenRegDer + "/100", "SIGUE ESTUDIANDO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Derivadas frm = new Derivadas();
                        AddOwnedForm(frm);
                        frm.DlblNotaRegCadena.Text = LblNotaRegCadena.Text;
                        frm.FlblNombre.Text = lblNombre.Text;
                        frm.FlblApellido.Text = LblApellido.Text;
                        frm.FlblIDE.Text = LblIDE.Text;
                        frm.FlblNota.Text = LblNotaPre.Text;
                        frm.DlblNotaTipDeriv.Text = LblNotaTipDeriv.Text;
                        //this.Hide();
                        //frm.ShowDialog();

                        BtnSiguiente.Enabled = false;
                    }
                    break;
                default:
                    break;

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
