using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgentObjects;
using DoubleAgentCtl;


namespace Proy_SistemaApoyoMatemetico.Formularios
{
    public partial class TiposFun : Form
    {
        private AgentObjects.IAgentCtlCharacter Avatar;
       
        
        public TiposFun()
        {
            InitializeComponent();
        }
        
        private void label2_Click(object sender, EventArgs e)
        {
              ControlAgTED.Characters.Load("merlin", "merlin.acs");
            Avatar.Show(0);
            Avatar.MoveTo(690, 7, 1);
            Avatar.Speak("En las funciones algebraicas las operaciones que " +
                "hay que efectuar con la variable independiente son: la adición, " +
                "sustracción, multiplicación, división, potenciación y radicación.");
            Avatar.Hide();
        }
        private void TiposFun_Load(object sender, EventArgs e)
        {
            ControlAgTED.Characters.Load("merlin", "merlin.acs");
            Avatar = (IAgentCtlCharacter)ControlAgTED.Characters["merlin"];
            Avatar.Show();
            Avatar.Speak("Hola Bienvenido me Llamo AREN y sere tu compañero de aprendizaje" +
                "y te ire apoyando en cada tema, por ahora cada que presiones uno de los titulos te ire explicando" +
                " a veces estare en un boton de signo de interrogacion si necesitas mi ayuda");
            Avatar.MoveTo(690, 7, 1);
            Avatar.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Avatar.Show(0);
            Avatar.MoveTo(690, 7, 1);
            Avatar.Speak("Una función en la que la variable dependiente " +
                "se expresa ÚNICAMENTE en términos de la variable independiente " +
                "la ecuacion muestra un ejemplo de una funcion explicita");
            Avatar.Hide();
        }
        private void label5_Click(object sender, EventArgs e)
        {
            Avatar.Show(0);
            Avatar.MoveTo(690, 7, 1);
            Avatar.Speak("Una función implícita es aquella que la variable " +
                "dependiente no está despejada. Es decir, que no está definida " +
                "en función solo de la variable independiente x.");
            Avatar.Hide();
        }
        private void label4_Click(object sender, EventArgs e)
        {
            Avatar.Show(0);
            Avatar.MoveTo(690, 7, 1);
            Avatar.Speak("Son las funciones que vienen definidas " +
                "por un polinomio.Su dominio es R, es decir, cualquier " +
                "número real.");
            Avatar.Hide();
        }
        private void label6_Click(object sender, EventArgs e)
        {
            Avatar.Show(0);
            Avatar.MoveTo(690, 7, 1);
            Avatar.Speak("El criterio viene dado por un número real. " +
                "Con una función constante, para cualesquiera dos puntos " +
                "en el intervalo, un cambio en x resulta en un cambio en cero en f ( x ). ");
            Avatar.Hide();
        }
        private void label15_Click(object sender, EventArgs e)
        {
            Avatar.Show(0);
            Avatar.MoveTo(690, 7, 1);
            Avatar.Speak("es una función que contiene una expresión " +
                "algebraica dentro de los símbolos de valor absoluto. Recuerde" +
                " que el valor absoluto de un número es su distancia desde 0 en " +
                "la recta numérica");
            Avatar.Hide();
        }
        private void label16_Click(object sender, EventArgs e)
        {
            Avatar.Show(0);
            Avatar.MoveTo(690, 7, 1);
            Avatar.Speak("hace corresponder a cada número real el número entero inmediatamente inferior" +
                "Esta función esta definida a trozos con infinitos tramos en los que la función es constante");
            Avatar.Hide();
        }
        private void label17_Click(object sender, EventArgs e)
        {
            Avatar.Show(0);
            Avatar.MoveTo(690, 7, 1);
            Avatar.Speak("hace corresponder a cada número el mismo número" +
                " menos su parte entera.");
            Avatar.Hide();
        }
        private void label18_Click(object sender, EventArgs e)
        {
            Avatar.Show(0);
            Avatar.MoveTo(690, 7, 1);
            Avatar.Speak("es una función matemática especial, devuelve un valor según si un número " +
                "o el resultado de una expresión es mayor, menor o igual que 0. " +
                "Se representa generalmente mediante sgn(x)," +
                " y no debe confundirse con la función seno (sen(x) o bien sin(x)).");
            Avatar.Hide();
        }
        private void label7_Click(object sender, EventArgs e)
        {
            Avatar.Show(0);
            Avatar.MoveTo(690, 7, 1);
            Avatar.Speak("Una función polinómica es una función cuya expresión" +
                " algebraica es un polinomio, es decir, una función polinómica " +
                "está definida por la suma o resta de un número finito de términos" +
                " de diferente grado. son el coeficiente y la variable respectivamente" +
                " de cada monomio que forma la función polinómica.");
            Avatar.Hide();
        }
        private void label8_Click(object sender, EventArgs e)
        {
            Avatar.Show(0);
            Avatar.MoveTo(690, 7, 1);
            Avatar.Speak("Una función afín es una función polinómica de " +
                "primer grado que no pasa por el origen de coordenadas, o sea, por el punto(0, 0)." +
                "Las funciones afines son rectas definidas por la siguiente fórmula: f de x sera igual a " +
                "m por x mas n");
            Avatar.Hide();
        }
        private void label9_Click(object sender, EventArgs e)
        {
            Avatar.Show(0);
            Avatar.MoveTo(690, 7, 1);
            Avatar.Speak("Siendo X la variable independiente, a y b números reales constantes." +
                "Analizando la expresión vemos que dado cualquier valor de X, primero lo multiplicamos " +
                "por a y luego sumamos b.El resultado de toda esa operación será el valor de f de X." +
                "Donde m es la pendiente de la recta.");
            Avatar.Hide();
        }
        private void label10_Click(object sender, EventArgs e)
        {
            Avatar.Show(0);
            Avatar.MoveTo(690, 7, 1);
            Avatar.Speak("es aquella función que tiene como imagen el " +
                "mismo valor que el argumento. La función identidad se puede" +
                "expresar con el término id.");
            Avatar.Hide();
        }
        private void label11_Click(object sender, EventArgs e)
        {
            Avatar.Show(0);
            Avatar.MoveTo(690, 7, 1);
            Avatar.Speak("Una función cuadrática es un tipo de función que" +
                " se caracteriza por ser un polinomio de segundo grado." +
                "también recibe el nombre de función de segundo grado." +
                "forma una parábola simétrica con el eje vertical" +
                "Tiene un Vértice y es mínimo o máximo" +
                "Tiene un único mínimo p un único máximo El coeficiente " +
                "cuadrática debe ser diferente de cero");
            Avatar.Hide();
        }
        private void label12_Click(object sender, EventArgs e)
        {
            Avatar.Show(0);
            Avatar.MoveTo(690, 7, 1);
            Avatar.Speak("la funciones que sólo tienen exponentes enteros no-negativos de la variable independiente." +
                "y está definida como el cociente de polinomios en " +
                "los cuales el denominador tiene un grado de por lo menos 1." +
                " En otras palabras, debe haber una variable en el denominador.");
            Avatar.Hide();
        }
        private void label13_Click(object sender, EventArgs e)
        {
            Avatar.Show(0);
            Avatar.MoveTo(690, 7, 1);
            Avatar.Speak("también conocidas como funciones irracionales; " +
                "que como su nombre indica son aquella funciones en las que " +
                "su definición aparece un radical, o lo que es lo mismo una raíz");
            Avatar.Hide();
        }
        private void label14_Click(object sender, EventArgs e)
        {
            Avatar.Show(0);
            Avatar.MoveTo(690, 7, 1);
            Avatar.Speak("s una función con distinto comportamiento según " +
                "el intervalo de su variable independiente considerado. " +
                "A cada uno de estos intervalos se les conoce con el nombre de ramas. ");
            Avatar.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ControlAgTED_ActivateInput(object sender, AxDoubleAgentCtl._DaCtlEvents2_ActivateInputEvent e)
        {

        }
    }
}
