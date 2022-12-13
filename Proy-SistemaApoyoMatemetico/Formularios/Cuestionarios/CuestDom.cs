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
    public partial class CuestDom : Form
    {
        private readonly D_Notas notas = new D_Notas();
        private readonly N_Notas NNota = new N_Notas();
        D_Pregunta rc = new D_Pregunta();

        private int? idbusqueda = null;

        private AgentObjects.IAgentCtlCharacter Avatar;
        decimal resultado = 0;
        int seleccion = 0;
        public CuestDom()
        {
            InitializeComponent();
        }
        public CuestDom(int idbusqueda) : this()
        {
            this.idbusqueda = idbusqueda;

        }
        private void pregunta1()
        {
            this.pregunta.Text = "¿Qué es un dominio?.";
            this.opcion1.Text = "conjunto de todos los valores de \n entrada que una función puede tomar."; // Correcto
            this.opcion2.Text = "conjunto de todos los valores \n de salida que una funcion puede tomar.";
            this.opcion3.Text = "Datos de entrada y de salida \n que se puede obtener mediante una \n resolucion matematica";
            //this.opcion4.Text = "120";
            seleccion++;
        }
        private void pregunta2()
        {
            this.pregunta.Text = "Si consideramos que el dominio es el mayor subconjunto de R en el que la función tiene \n sentido, ¿Cuál es el dominio y el rango de la función F(x) =sin(x)?";
            //this.PboxFoto.Image = Proy_SistemaApoyoMatemetico.Properties.Resources.Exa1;
            this.opcion1.Text = "Df = Rf = R";
            this.opcion2.Text = "Df = R  y Rf = [-1 , 1]";//Correcto
            this.opcion3.Text = "Df = R  = Rf = [-1 , 1]";
            //this.opcion4.Text = "120";
            seleccion++;
        }
        private void pregunta3()
        {
            this.pregunta.Text = "¿Qué es el rango?";
            //this.PboxFoto.Image = Proy_SistemaApoyoMatemetico.Properties.Resources.EP3;
            this.opcion1.Text = "Conjunto de todos los valores \n de entrada que una función \n puede recibir.";
            this.opcion2.Text = "Conjunto de todos los valores \n de entrada  y salida que una función \n puede producir y recibir.";
            this.opcion3.Text = "conjunto de todos los valores \n de salida que una función \n puede producir";//correcto
            //this.opcion4.Text = "]-1,1[";
            seleccion++;
        }
        //PReguntas derivadas
        private void pregunta4()
        {
            this.pregunta.Text = "Conjunto de todos los valores de entrada  y salida que una función puede producir y recibir.";
            //this.PboxFoto.Image = Proy_SistemaApoyoMatemetico.Properties.Resources.EP4;
            this.opcion1.Text = "Dominio:Todos los naturales \n Rango: De 4 hacia abajo hasta infinito ";
            this.opcion2.Text = "Dominio:Todos los reales \n Rango: De 4 en Adelante hasta infinito";//Correcto
            this.opcion3.Text = "Dominio: De 4 en Adelante hasta Infinito \n Rango: Todos los Reales ";
            //this.opcion4.Text = "Una Paabola";
            seleccion++;
        }
        private void pregunta5()
        {
            this.pregunta.Text = "Encuentra el dominio y el rango de la función: f(x)= -x^4 + 2";
            //this.PboxFoto.Image = Proy_SistemaApoyoMatemetico.Properties.Resources.TestDom1;
            this.opcion1.Text = "Todos los números reales"; // Correcto
            this.opcion2.Text = "Todos los números \n reales excepto el -1 y el 2";
            this.opcion3.Text = "Todos los números naturales";
            //this.opcion4.Text = "Una semicircunferencia centrada en (1,0) y radio 2";
            seleccion++;
        }
        
        private void pregunta6()
        {
            this.pregunta.Text = "¿Que hace la funcion lineal?";
            this.opcion1.Text = "Vemos que la función \n toma todos los valores de y";
            this.Respuesta1.Image = Proy_SistemaApoyoMatemetico.Properties.Resources.ResIncoEJDom1;
            this.opcion2.Text = "Todos los números \n reales, que sean menores a 2";//correcto
            this.Respuesta2.Image = Proy_SistemaApoyoMatemetico.Properties.Resources.ResCorrEJDom1;
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
                        Nt.ExamenDominio = Math.Ceiling(resultado);
                        string dato = CLblIDE.Text;
                        NNota.ActulizaNota(Nt, dato);

                        LblNotaDom.Text = resultado.ToString();
                        Funciones frm = new Funciones();
                        AddOwnedForm(frm);
                        frm.FLblNDom.Text = LblNotaDom.Text;
                        frm.FlblNombre.Text = lblNombreCuestionario.Text;
                        frm.FlblApellido.Text = LblApellido.Text;
                        frm.FlblIDE.Text = CLblIDE.Text;
                        frm.FlblNota.Text = LblNotaPre.Text;
                        frm.FLblNotaTipFun.Text = LblNotaTF.Text;
                        //this.Hide();
                        //frm.ShowDialog();

                        MessageBox.Show("Tienes: " + Nt.ExamenDominio + "/100", "FELICITACIONES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //MessageBox.Show("Bienvenido " + est.Nombre + ", " + est.Apellido);

                        //LblNotaTIP.Text = resultado.ToString();
                        //MessageBox.Show(Convert.ToString(LblNotaTIP.Text));
                        BtnSiguiente.Enabled = false;

                    }
                    else
                    {
                        Nt.PreExamen = Convert.ToInt64(LblNotaPre.Text);
                        Nt.ExamenTipFun = Convert.ToInt64(LblNotaTF.Text);
                        Nt.ExamenDominio = Math.Ceiling(resultado);
                        string dato = CLblIDE.Text;
                        NNota.ActulizaNota(Nt, dato);
                        LblNotaDom.Text = resultado.ToString();
                        MessageBox.Show("Tienes: " + Nt.ExamenDominio + "/100", "SIGUE ESTUDIANDO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Funciones frm = new Funciones();
                        AddOwnedForm(frm);
                        frm.FLblNDom.Text = LblNotaDom.Text;
                        frm.FlblNombre.Text = lblNombreCuestionario.Text;
                        frm.FlblApellido.Text = LblApellido.Text;
                        frm.FlblIDE.Text = CLblIDE.Text;
                        frm.FlblNota.Text = LblNotaPre.Text;
                        frm.FLblNotaTipFun.Text = LblNotaTF.Text;
                        //this.Hide();
                        //frm.ShowDialog();
                        //MessageBox.Show("Tienes: " + resultado+ "/100", "DEBES REPASAR MAS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                        BtnSiguiente.Enabled = false;
                    }

                    break;
                default:
                    break;
            }
        }

        private void CuestDom_Load(object sender, EventArgs e)
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
                CLblIDE.Text = Convert.ToString(idbusqueda);
            }
            lblNombreCuestionario.Text = rc.scalerReturn("Select Nombre From Usuario where IDU= '" + idbusqueda + "'");
            LblApellido.Text = rc.scalerReturn("Select Apellido From Usuario where IDU= '" + idbusqueda + "'");
            LblNotaPre.Text = rc.scalerReturn("Select PreExamen From Notas where IDU= '" + idbusqueda + "'");
            LblNotaTF.Text = rc.scalerReturn("Select ExamenTipFun From Notas where IDU= '" + idbusqueda + "'");

            pregunta1();
        }

        private void PboxFoto_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
