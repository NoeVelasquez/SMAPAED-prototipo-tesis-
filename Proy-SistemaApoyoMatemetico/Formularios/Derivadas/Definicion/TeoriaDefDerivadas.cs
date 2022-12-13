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
    public partial class TeoriaDefDerivadas : Form
    {
        private AgentObjects.IAgentCtlCharacter Avatar;
        public TeoriaDefDerivadas()
        {
            InitializeComponent();
        }

        private void TeoriaDefDerivadas_Load(object sender, EventArgs e)
        {
            ControlAgTED.Characters.Load("Robby", "Robby.acs");
            Avatar = (IAgentCtlCharacter)ControlAgTED.Characters["Robby"];
            Avatar.Show(0);
            Avatar.MoveTo(690, 7, 1);
            Avatar.Speak("La derivada de una función es la que está " +
                "representada, de forma gráfica, como una línea que es recta pero" +
                " superpuesta encima de una curva cualquiera que se denomina función." +
                "Ese valor que tiene  la pendiente respecto al eje en el cual se estudia" +
                " la función es lo que se denomina derivada.");
            Avatar.Speak("En matemáticas, una derivada es la resultante de un " +
                "límite que representa a la pendiente de una recta tangente a una gráfica" +
                " en la función de un punto específico.La derivada en una función es el límite" +
                " hacia el que tiende la razón entre un incremento en la función y el que" +
                " corresponde a la variable si el incremento tiende a ser cero.");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
