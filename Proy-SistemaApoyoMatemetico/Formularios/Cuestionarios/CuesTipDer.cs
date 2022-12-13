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
    public partial class CuesTipDer : Form
    {
        private readonly D_Notas notas = new D_Notas();
        private readonly N_Notas NNota = new N_Notas();
        private int? idbusqueda = null;
        D_Pregunta rc = new D_Pregunta();

        private AgentObjects.IAgentCtlCharacter Avatar;
        decimal resultado = 0;
        int seleccion = 0;
        public CuesTipDer()
        {
            InitializeComponent();
        }
        public CuesTipDer(int idbusqueda) : this()
        {
            this.idbusqueda = idbusqueda;

        }

        private void CuesTipDer_Load(object sender, EventArgs e)
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

            pregunta1();
        }

        private void pregunta1()
        {
            this.pregunta.Text = "Calcula la velocidad media cuando f(t)=3t-2 " +
                "en el intervalo de tiempo[1, 3].";
            this.opcion1.Text = "V=3"; // Correcto
            this.opcion2.Text = "V=1";
            this.opcion3.Text = "V=23";
            //this.opcion4.Text = "120";
            seleccion++;
        }
        private void regunta2()
        {
            this.pregunta.Text = "Calcula la velocidad media cuando f(t)=e^t " +
                " en el intervalo de tiempo[0, 1].";
            //this.PboxFoto.Image = Proy_SistemaApoyoMatemetico.Properties.Resources.Exa1;
            this.opcion1.Text = "V=e";
            this.opcion2.Text = "V=e-1";//Correcto
            this.opcion3.Text = "V=1";
            //this.opcion4.Text = "120";
            seleccion++;
        }
        private void pregunta3()
        {
            this.pregunta.Text = "Calcula la velocidad instantánea cuando f(t)=4 " +
                "en el instante t = 2.";
            //this.PboxFoto.Image = Proy_SistemaApoyoMatemetico.Properties.Resources.EP3;
            this.opcion1.Text = "V=t";
            this.opcion2.Text = "V=1";
            this.opcion3.Text = "V=0";//correcto
            //this.opcion4.Text = "]-1,1[";
            seleccion++;
        }
        //PReguntas derivadas
        private void pregunta4()
        {
            this.pregunta.Text = "¿Que son Derivadas?";
            //this.PboxFoto.Image = Proy_SistemaApoyoMatemetico.Properties.Resources.EP4;
            this.opcion1.Text = "es la resultante de un límite \n " +
                "que representa a la  pendiente \n" +
                "de una recta tangente";//Correcto
            this.opcion2.Text = "es la resultante de un lmte que \n" +
                " representa a la pendiente \n " +
                "de una recta tangente";
            this.opcion3.Text = "Ninguno";
            //this.opcion4.Text = "Una Paabola";
            seleccion++;
        }
        private void pregunta5()
        {
            this.pregunta.Text = "Calcula la derivada de  f(x)=x^2en el punto x=2 . El valor obtenido es";
            this.opcion1.Text = "f'(2)=4";//correcto
            //this.PboxFoto.Image = Proy_SistemaApoyoMatemetico.Properties.Resources.Exlog2;
            this.opcion2.Text = "f'(2)=+-4";
            this.opcion3.Text = "f'(2)=2";
            //this.opcion4.Text = "Una semicircunferencia centrada en (1,0) y radio 2";
            seleccion++;
        }

        private void pregunta6()
        {
            this.pregunta.Text = "Teniendo en cuenta las fórmulas vistas, ¿Cuál es la derivada dex^3 ?";
            this.opcion1.Text = "f'(x)=2x^3";
            this.opcion2.Text = "f'(x)=3x^2";//correcto
            this.opcion3.Text = "f'(x)=x^2";
            //this.opcion4.Text = "V = -3";
            seleccion++;
        }
        private void pregunta7()
        {
            this.pregunta.Text = "Cual seria el grafico de derivadas";
            this.opcion1.Text = "Opcion 1";
            this.PboxFoto.Image = Proy_SistemaApoyoMatemetico.Properties.Resources._2022_07_16_15_19_59_Window ;
            this.opcion2.Text = "Opcion 2";//correcto
            this.pictureBox1.Image = Proy_SistemaApoyoMatemetico.Properties.Resources.Recta_tangente_y_derivada_svg;
            this.opcion3.Text = "Ninguno";
            //this.opcion4.Text = "V = -3";
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
                        resultado = resultado + (decimal)14;
                    }
                    regunta2();
                    Limpiar();
                    break;

                case 2:
                    if (this.opcion2.Checked == true)
                    {
                        resultado = resultado + (decimal)15;
                    }
                    pregunta3();
                    Limpiar();
                    break;

                case 3:
                    if (this.opcion3.Checked == true)//1
                    {
                        resultado = resultado + (decimal)14;
                    }
                    pregunta4();
                    Limpiar();
                    break;

                case 4:
                    if (this.opcion1.Checked == true)//3
                    {
                        resultado = resultado + (decimal)15;
                    }
                    pregunta5();
                    Limpiar();
                    break;

                case 5:
                    if (this.opcion1.Checked == true)//1
                    {
                        resultado = resultado + (decimal)14;
                    }
                    pregunta6();
                    Limpiar();
                    break;

                case 6:
                    if (this.opcion2.Checked == true)//1
                    {
                        resultado = resultado + (decimal)14;
                    }
                    pregunta7();
                    Limpiar();
                    break;
                case 7:
                    if (this.opcion2.Checked == true)//1
                    {
                        resultado = resultado + (decimal)14;
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
                        Nt.ExamenTipDeriv =  Math.Ceiling(resultado);
                        string dato = LblIDE.Text;
                        NNota.ActulizaNota(Nt, dato);

                        LblNotaTipDeriv.Text = resultado.ToString();
                        Derivadas frm = new Derivadas();
                        AddOwnedForm(frm);
                        frm.DlblNotaTipDeriv.Text = LblNotaTipDeriv.Text;
                        frm.FlblNombre.Text = lblNombre.Text;
                        frm.FlblApellido.Text = LblApellido.Text;
                        frm.FlblIDE.Text = LblIDE.Text;
                        frm.FlblNota.Text = LblNotaPre.Text;
                        //this.Hide();
                        //frm.ShowDialog();

                        MessageBox.Show("Tienes: " + Nt.ExamenTipDeriv + "/100", "FELICITACIONES", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        Nt.ExamenTipDeriv = Math.Ceiling(resultado);
                        string dato = LblIDE.Text;
                        NNota.ActulizaNota(Nt, dato);

                        LblNotaTipDeriv.Text = resultado.ToString();
                        MessageBox.Show("Tienes: " + Nt.ExamenTipDeriv + "/100", "SIGUE ESTUDIANDO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Derivadas frm = new Derivadas();
                        AddOwnedForm(frm);
                        frm.DlblNotaTipDeriv.Text = LblNotaTipDeriv.Text;
                        frm.FlblNombre.Text = lblNombre.Text;
                        frm.FlblApellido.Text = LblApellido.Text;
                        frm.FlblIDE.Text = LblIDE.Text;
                        frm.FlblNota.Text = LblNotaPre.Text;
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
