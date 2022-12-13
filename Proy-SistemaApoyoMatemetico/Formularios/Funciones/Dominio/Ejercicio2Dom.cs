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
    public partial class Ejercicio2Dom : Form
    {
        private AgentObjects.IAgentCtlCharacter Avatar;
        public Ejercicio2Dom()
        {
            InitializeComponent();
        }

        private void Ejercicio2Dom_Load(object sender, EventArgs e)
        {
            ControlAgTED.Characters.Load("Robby", "Robby.acs");
            Avatar = (IAgentCtlCharacter)ControlAgTED.Characters["Robby"];
            Avatar.Show(0);
            Avatar.MoveTo(690, 7, 1);
            Avatar.Speak("Podemos ver el Tercer  ejercicio de dominios");
            Avatar.MoveTo(680, 7, 1);
            Avatar.Speak("Dominio: La función f de X igual a x elevado al cuadrado mas uno está definida para todos " + "" +
                "los valores reales de x ya que no hay restricciones en el valor de x." +
                "Entonces, el dominio de x es: Todos los valores reales de x");
            Avatar.Speak("Rango: Dado que x elevado al cuadrado nunca es negativo, x elevado al cuadrado mas uno nunca es menor que 1. " +
                "Entonces, el rango de f(x) es:");
        }

        private void BtnSolucion_Click(object sender, EventArgs e)
        {
            SolucionEj1.Visible = true;
            SolucionEj2.Visible = false;
        }

        private void BtnSolucionEj2_Click(object sender, EventArgs e)
        {
            SolucionEj2.Visible = true;
            SolucionEj1.Visible = false;
        }

        private void Ejemplo1_Click(object sender, EventArgs e)
        {

        }

        private void SolucionEj1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void SolucionEj2_Enter(object sender, EventArgs e)
        {

        }
    }
}
