using AgentObjects;
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
   
    public partial class CuesInicial : Form
    {
        private readonly D_Notas notas = new D_Notas();
        private readonly N_Notas NNota = new N_Notas();

        private AgentObjects.IAgentCtlCharacter Avatar;
        int resultado = 0;
        int seleccion = 1;
        int datoE = 0;
        private void MostrarRegistros()
        {
            //DatosNotas.DataSource = NNota.ListarNotas().Tables["tbl"];
        }

        public CuesInicial()
        {
            InitializeComponent();
            
            //MostrarRegistros();
        }
       
        private void CuesInicial_Load(object sender, EventArgs e)
        {
            ControlAgTED.Characters.Load("Athena", "Athena.acs");
            //ControlAgTED.Characters.Load("Peedy", "Peedy.acs");
            Avatar = (IAgentCtlCharacter)ControlAgTED.Characters["Athena"];
            //Avatar = (IAgentCtlCharacter)ControlAgTED.Characters["Peedy"];
            Avatar.Show(0);
            Avatar.MoveTo(800, 234, 1);
            Avatar.Speak("Hola Antes de Ingresar Deberas de llenar un Examen" +
                "de Funciones y derivadas");
            Avatar.Speak("Mucha Suerte y que la suerte te acompañe");
            Avatar.Hide();
            Iniciar();

        }
        //Preguntas de Funciones
        private void Iniciar()
        {
            if (MessageBox.Show("Bienvenido a la evaluación sobre Funciones", "Evaluacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                this.pregunta.Text = "¿Cuál es la suma de los diez primeros números naturales?";
                this.opcion1.Text = "55";
                this.opcion2.Text = "75";
                this.opcion3.Text = "50";
                this.opcion4.Text = "54";
            }
            else
            {
                Application.Exit();
            }

        }
        
        private void pregunta2()
        {
            this.pregunta.Text = "¿Cuál es la suma de los quince primeros números naturales?";
            this.opcion1.Text = "110";
            this.opcion2.Text = "115";
            this.opcion3.Text = "150";
            this.opcion4.Text = "120";
            seleccion++;
        }
        private void pregunta3()
        {
            this.pregunta.Text = "La grafica de la siguiente funcion es: f(x)= 1/x";
            //this.PboxFoto.Image = Proy_SistemaApoyoMatemetico.Properties.Resources.EP3;
            this.opcion1.Text = "R";
            this.opcion2.Text = "{0}";
            this.opcion3.Text = "R - {0}";
            this.opcion4.Text = "]-1,1[";
            seleccion++;
        }
        private void pregunta4()
        {
            this.pregunta.Text = "La grafica de la siguiente funcion es: f(x)= x^2";
            //this.PboxFoto.Image = Proy_SistemaApoyoMatemetico.Properties.Resources.EP4;
            this.opcion1.Text = "Una Parabola";
            this.opcion2.Text = "Una Hiperbola";
            this.opcion3.Text = "Una Recta";
            this.opcion4.Text = "Una Paabola";
            seleccion++;
        }
        private void pregunta5()
        {
            this.pregunta.Text = "Cual seria la grafica de la siguiente  funcion: √4 - x^2 ";
            //this.PboxFoto.Image = Proy_SistemaApoyoMatemetico.Properties.Resources.EP5;
            this.opcion1.Text = "Una semicircunferencia de radio 4";
            this.opcion2.Text = "Una semicircunferencia de diametro 4";
            this.opcion3.Text = "Una semicircunferencia centrada en (0,0) y radio 2";
            this.opcion4.Text = "Una semicircunferencia centrada en (1,0) y radio 2";
            seleccion++;
        }
        //PReguntas derivadas
        private void pregunta6()
        {
            this.pregunta.Text = "Calcula la velocidad media cuando f(t)=3t-2 en el intervalo de tiempo[1, 3].";
            this.opcion1.Text = "V = 3";
            this.opcion2.Text = "V = 1";
            this.opcion3.Text = "V = 23";
            this.opcion4.Text = "V = -3";
            seleccion++;
        }
        private void pregunta7()
        {
            this.pregunta.Text = "Calcula la derivada de  f(x)=x^2en el punto x = 2.El valor obtenido es";
            this.opcion1.Text = "f'(2)=+-4";
            this.opcion2.Text = "f'(2)=4";
            this.opcion3.Text = "f'(2)=2";
            this.opcion4.Text = "f'(2)=-4";
            seleccion++;
        }
        private void pregunta8()
        {
            this.pregunta.Text = "Calcula la velocidad instantánea cuando f(t)= 4  :";
            this.opcion1.Text = "V=0";
            this.opcion2.Text = "V=1";
            this.opcion3.Text = "V=t";
            this.opcion4.Text = "V=-1";
            seleccion++;
        }
        private void pregunta9()
        {
            this.pregunta.Text = "¿Cuál es la derivada de x^3 ?";
            this.opcion1.Text = "f'(x)=3x^2";
            this.opcion2.Text = "f'(x)=2x^3";
            this.opcion3.Text = "f'(x)=x^2";
            this.opcion4.Text = "f'(x)=x^3";
            seleccion++;
        }
        private void pregunta10()
        {
            this.pregunta.Text = "¿Que son Derivadas?";
            this.opcion1.Text = "es la resultante de un limite que representa a la pendente de una recta tangente";
            this.opcion2.Text = "es la resultante de un lmte que representa a la pendiente de una recta tangente";
            this.opcion3.Text = "es la resultante de un límite que representa a la pendiente de una recta tangente";
            this.opcion4.Text = "Ninguna de las anteriores";
            seleccion++;
        }
        private void Limpiar()
        {
            this.opcion1.Checked = false;
            this.opcion2.Checked = false;
            this.opcion3.Checked = false;
            this.opcion4.Checked = false;
        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            switch (seleccion)
            {
                case 1:
                    if (this.opcion1.Checked == true)
                    {
                        resultado = resultado + 10;
                    }
                    pregunta2();
                    Limpiar();
                    break;

                case 2:
                    if (this.opcion2.Checked == true)
                    {
                        resultado =resultado+10;
                    }
                    pregunta3();
                    Limpiar();
                    break;

                case 3:
                    if (this.opcion3.Checked == true)//1
                    {
                        resultado = resultado + 10;
                    }
                    pregunta4();
                    Limpiar();
                    break;

                case 4:
                    if (this.opcion1.Checked == true)//3
                    {
                        resultado = resultado + 10;
                    }
                    pregunta5();
                    Limpiar();
                    break;

                case 5:
                    if (this.opcion3.Checked == true)//1
                    {
                        resultado = resultado + 10;
                    }
                    pregunta6();
                    Limpiar();
                    break;

                case 6:
                    if (this.opcion1.Checked == true)
                    {
                        resultado =resultado+10;
                    }
                    pregunta7();
                    Limpiar();
                    break;

                case 7:
                    if (this.opcion2.Checked == true)
                    {
                        resultado =resultado+10;
                    }
                    pregunta8();
                    Limpiar();
                    break;

                case 8:
                    if (this.opcion1.Checked == true)
                    {
                        resultado =resultado+10;
                    }
                    pregunta9();
                    Limpiar();
                    break;
                    
                case 9:
                    if (this.opcion1.Checked == true)
                    {
                        resultado =resultado+10;
                    }
                    pregunta10();
                    Limpiar();
                    break;
                
                case 10:
                    if (this.opcion3.Checked == true)//1
                    {
                        resultado = resultado + 10;
                    }

                    
                    E_Notas N = new E_Notas();
                    if (resultado >= 50 )
                    {
                        
                        N.PreExamen = resultado;
                        string dato = LblIDE.Text;
                        MessageBox.Show("Tienes: "+resultado.ToString()+"/100", "FELICITACIONES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //MessageBox.Show("Bienvenido " + est.Nombre + ", " + est.Apellido);
                        NNota.CrearNota(N, dato);
                        
                        MenuAdministrador mainMenu = new MenuAdministrador();
                        mainMenu.lblNombre.Text = lblNombre.Text;
                        mainMenu.LblApellido.Text = LblApellido.Text;
                        mainMenu.LblIDE.Text = LblIDE.Text;
                        mainMenu.lblNota.Text = Convert.ToString(N.PreExamen);
                        mainMenu.TxtNota.Value = (int)N.PreExamen;
                        decimal nota = Convert.ToDecimal(N.PreExamen);
                        //decimal nota = nota = Decimal.Parse(LblNotaFinalFun.Text);
                        if (nota >= 51 && nota < 69 /*|| nota >70*/ )
                        {
                            mainMenu.BtnFunc.Enabled = false;
                            mainMenu.BtnDeriv.Enabled = true;

                        }
                        else if (nota > 69)
                        {
                            mainMenu.BtnFunc.Enabled = false;
                            mainMenu.BtnDeriv.Enabled = false;
                        }

                        else
                        {
                            mainMenu.BtnFunc.Enabled = true;
                            mainMenu.BtnDeriv.Enabled = false;
                        }
                        mainMenu.Show();
                        this.Hide();
                    }
                    else
                    {
                        MenuAdministrador menu = new MenuAdministrador();
                        menu.lblNombre.Text = lblNombre.Text;
                        menu.LblApellido.Text = LblApellido .Text;
                        menu.LblIDE.Text=LblIDE.Text;
                        N.PreExamen = resultado;
                        string dato = LblIDE.Text;
                        NNota.CrearNota(N, dato);
                        MessageBox.Show("Tienes: "+resultado.ToString()+"/100", "DEBES REPASAR MAS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        menu.lblNota.Text = Convert.ToString(N.PreExamen);
                        menu.TxtNota.Value = (int)N.PreExamen;
                        decimal nota = Convert.ToDecimal(N.PreExamen);
                        //decimal nota = nota = Decimal.Parse(LblNotaFinalFun.Text);
                        if (nota >= 51 && nota < 69 /*|| nota >70*/ )
                        {
                            menu.BtnFunc.Enabled = false;
                            menu.BtnDeriv.Enabled = true;

                        }
                        else if (nota > 69)
                        {
                            menu.BtnFunc.Enabled = false;
                            menu.BtnDeriv.Enabled = false;
                        }

                        else
                        {
                            menu.BtnFunc.Enabled = true;
                            menu.BtnDeriv.Enabled = false;
                        }
                        menu.Show();
                            this.Hide();
                    
                        //Application.Exit();
               
                       
                    }

                    break;
                default:
                    break;
            }
        }

        private void bunifuGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
