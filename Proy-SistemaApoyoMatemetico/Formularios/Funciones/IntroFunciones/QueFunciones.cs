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

namespace Proy_SistemaApoyoMatemetico
{
    public partial class QueFunciones : Form
    {
        public AgentObjects.IAgentCtlCharacter Avatar;
        
        public QueFunciones()
        {
            InitializeComponent();
        }
        
        private void QueFunciones_Load(object sender, EventArgs e)
        {
            ControlAgTED.Characters.Load("Robby", "Robby.acs");
            Avatar = (IAgentCtlCharacter)ControlAgTED.Characters["Robby"];
            Avatar.Show(0);
            Avatar.MoveTo(800, 234, 1);
            Avatar.Speak("El concepto de función es uno de los más importantes tanto en Matemáticas," +
            "como en Física, Química, Medicina, Estadística, Economía, Ingeniería, Psicología," +
            "entre otras.");
            Avatar.Speak("Y probablemente te has preguntado cuales serían ejemplos de funciones en la vida" +
            "cotidiana podemos pensar en una máquina expendedora, ya que uno ingresa un código y la maquina te regresa un producto," +
            "el llamar por teléfono también es un ejemplo de una función, tu ingresas un número y" +
            "se te conecta con el otro teléfono.");
            Avatar.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            Avatar.Show(0);
            Avatar.MoveTo(690, 7, 1);
            Avatar.Speak("Existe dos tipos de funcion:algebraica y trascendentes" +
                "en este punto explicare sobre las algebraicas que se subdivide en " +
                "Polinomicas, racionales, radicales y a trazos; ademas las polinomicas " +
                "se subdivide a de primer grado" +
                "En la parte de trascendentes existe: Exponencial, Logaritmica y Trigonometrica." +
                "La parte de Trascendentes Una característica común es que suelen tener bases y " +
                "exponentes en ambos lados de la ecuación. Así, para hallar el valor de la incógnita, " +
                "se puede transformar la ecuación, buscando que las bases sean iguales, y, de esta forma, " +
                "los exponentes también podrán igualarse.se lo revisara en los siguientes capitulos de el sistema... ");
            Avatar.Hide();
        }
    }
}
