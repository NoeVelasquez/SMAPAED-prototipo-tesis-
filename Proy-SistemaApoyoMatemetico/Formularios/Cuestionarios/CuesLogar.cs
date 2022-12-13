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
    public partial class CuesLogar : Form
    {
        private int? idbusqueda = null;
        D_Pregunta rc = new D_Pregunta();
        private readonly D_Notas notas = new D_Notas();
        private readonly N_Notas NNota = new N_Notas();

        private AgentObjects.IAgentCtlCharacter Avatar;
        decimal resultado = 0;
        int seleccion = 0;
        public CuesLogar()
        {
            InitializeComponent();
        }
        public CuesLogar(int idbusqueda) : this()
        {
            this.idbusqueda = idbusqueda;

        }
        private void pregunta1()
        {
            this.pregunta.Text = "¿Que es la funcion logaritmica?";
            this.opcion1.Text = "inversa de la exponencial"; // Correcto
            this.opcion2.Text = "es sobreyectiva";
            this.opcion3.Text = "es la inversa de la inyectiva";
            //this.opcion4.Text = "120";
            seleccion++;
        }
        private void pregunta2()
        {
            this.pregunta.Text = "¿Cuando existe un 0 en un logaritmo que es lo que pasa?";
            //this.PboxFoto.Image = Proy_SistemaApoyoMatemetico.Properties.Resources.Exa1;
            this.opcion1.Text = "Sale resultado negativo";
            this.opcion2.Text = "Error";//Correcto
            this.opcion3.Text = "se vuelve 1";
            //this.opcion4.Text = "120";
            seleccion++;
        }
        private void pregunta3()
        {
            this.pregunta.Text = "Reescribe a la función exponencial 5^2=25 a su función logarítmica equivalente.";
            //this.PboxFoto.Image = Proy_SistemaApoyoMatemetico.Properties.Resources.EP3;
            this.opcion1.Text = "2 log 5=10";
            this.opcion2.Text = "25 log 2= 50";
            this.opcion3.Text = "5 log 25 =2";//correcto
            //this.opcion4.Text = "]-1,1[";
            seleccion++;
        }
        //PReguntas derivadas
        private void pregunta4()
        {
            this.pregunta.Text = "¿El dominio de una funcion logaritmica en que rango se encuentra?";
            //this.PboxFoto.Image = Proy_SistemaApoyoMatemetico.Properties.Resources.EP4;
            this.opcion1.Text = "(0,infinito)";//Correcto
            this.opcion2.Text = "[0,infinito]";
            this.opcion3.Text = "]0,infinito]";
            //this.opcion4.Text = "Una Paabola";
            seleccion++;
        }
        private void pregunta5()
        {
            this.pregunta.Text = "Cual seria la grafica de la siguiente funcion  f(x) = log2x. ";
            this.opcion1.Text = "Opcion 1";//correcto
            this.PboxFoto.Image = Proy_SistemaApoyoMatemetico.Properties.Resources.Exlog2;
            this.opcion2.Text = "Todos los números \n reales, que sean menores a 2";
            this.pictureBox1.Image = Proy_SistemaApoyoMatemetico.Properties.Resources.Exlog3;
            this.opcion3.Text = "Ninguno de los anteriores.";
            //this.opcion4.Text = "Una semicircunferencia centrada en (1,0) y radio 2";
            seleccion++;
        }

        private void pregunta6()
        {
            this.pregunta.Text = "Cual seria el grafico  de la función f(x)=log a(x) cuando a>1";
            this.opcion1.Text = "Opcion 1";
            this.PboxFoto.Image = Proy_SistemaApoyoMatemetico.Properties.Resources.Exlog1;
            this.opcion2.Text = "Opcion 2";//correcto
            this.pictureBox1.Image = Proy_SistemaApoyoMatemetico.Properties.Resources.ResCorrEJDom1;
            this.opcion3.Text = "Ninguno de los anteriores.";
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
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            switch (seleccion)
            {
                case 1:
                    if (this.opcion1.Checked == true)
                    {
                        resultado = resultado + (decimal)16;
                    }
                    pregunta2();
                    Limpiar();
                    break;

                case 2:
                    if (this.opcion2.Checked == true)
                    {
                        resultado = resultado + (decimal)16;
                    }
                    pregunta3();
                    Limpiar();
                    break;

                case 3:
                    if (this.opcion3.Checked == true)//1
                    {
                        resultado = resultado + (decimal)17;
                    }
                    pregunta4();
                    Limpiar();
                    break;

                case 4:
                    if (this.opcion2.Checked == true)//3
                    {
                        resultado = resultado + (decimal)16;
                    }
                    pregunta5();
                    Limpiar();
                    break;

                case 5:
                    if (this.opcion1.Checked == true)//1
                    {
                        resultado = resultado + (decimal)17;
                    }
                    pregunta6();
                    Limpiar();
                    break;

                case 6:
                    if (this.opcion2.Checked == true)//1
                    {
                        resultado = resultado + (decimal)18;
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
                        Nt.ExamenLogar = Math.Ceiling(resultado);
                        string dato = LblIDE.Text;
                        NNota.ActulizaNota(Nt, dato);

                        LblNotaLog.Text = resultado.ToString();
                        Funciones frm = new Funciones();
                        AddOwnedForm(frm);
                        frm.FLblNLog.Text = LblNotaLog.Text;
                        frm.FlblNombre.Text = lblNombre.Text;
                        frm.FlblApellido.Text = LblApellido.Text;
                        frm.FlblIDE.Text = LblIDE.Text;
                        frm.FlblNota.Text = LblNotaPre.Text;
                        frm.FLblNotaTipFun.Text = LblNotaTF.Text;
                        frm.FLblNDom.Text = LblNotaDom.Text;
                        frm.FLblNExp.Text = LblNotaExpo.Text;
                        frm.FLblNTrig.Text = LblNotaTrig.Text;
                        //this.Hide();
                        //frm.ShowDialog();

                        MessageBox.Show("Tienes: " + Nt.ExamenLogar + "/100", "FELICITACIONES", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        Nt.ExamenLogar = Math.Ceiling(resultado);
                        string dato = LblIDE.Text;
                        NNota.ActulizaNota(Nt, dato);

                        LblNotaLog.Text = resultado.ToString();
                        MessageBox.Show("Tienes: " + Nt.ExamenLogar + "/100", "SIGUE ESTUDIANDO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Funciones frm = new Funciones();
                        AddOwnedForm(frm);
                        frm.FLblNLog.Text = LblNotaLog.Text;
                        frm.FlblNombre.Text = lblNombre.Text;
                        frm.FlblApellido.Text = LblApellido.Text;
                        frm.FlblIDE.Text = LblIDE.Text;
                        frm.FlblNota.Text = LblNotaPre.Text;
                        frm.FLblNotaTipFun.Text = LblNotaTF.Text;
                        frm.FLblNDom.Text = LblNotaDom.Text;
                        frm.FLblNExp.Text = LblNotaExpo.Text;
                        frm.FLblNTrig.Text = LblNotaTrig.Text;
                        //this.Hide();
                        //frm.ShowDialog();


                        BtnSiguiente.Enabled = false;
                    }

                    break;
                default:
                    break;
            }
        }

        private void CuesLogar_Load(object sender, EventArgs e)
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

            pregunta1();
        }

        private void pregunta_TextChanged(object sender, EventArgs e)
        {

        }

        private void ControlAgEVA_ActivateInput(object sender, AxDoubleAgentCtl._DaCtlEvents2_ActivateInputEvent e)
        {

        }

        private void opcion2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void opcion3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void opcion1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void PboxFoto_Click(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LblNotaLog_Click(object sender, EventArgs e)
        {

        }

        private void LblNotaTrig_Click(object sender, EventArgs e)
        {

        }

        private void LblNotaExpo_Click(object sender, EventArgs e)
        {

        }

        private void LblNotaTF_Click(object sender, EventArgs e)
        {

        }

        private void LblNotaDom_Click(object sender, EventArgs e)
        {

        }

        private void TxtResultado_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void LblNotaPre_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void LblIDE_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void LblApellido_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
