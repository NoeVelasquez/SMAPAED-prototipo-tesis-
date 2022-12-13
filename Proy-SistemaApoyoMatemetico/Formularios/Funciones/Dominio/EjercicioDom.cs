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
    public partial class EjercicioDom : Form
    {
        private AgentObjects.IAgentCtlCharacter Avatar;
        public EjercicioDom()
        {
            InitializeComponent();
        }

        private void BtnSolucion_Click(object sender, EventArgs e)
        {
            SolucionEj1.Visible = true;
            SolucionEj2.Visible = false;
        }
        
        private void EjercicioDom_Load(object sender, EventArgs e)
        {
            ControlAgTED.Characters.Load("Robby", "Robby.acs");
            Avatar = (IAgentCtlCharacter)ControlAgTED.Characters["Robby"];
            Avatar.Show(0);
            Avatar.MoveTo(690, 7, 1);
            Avatar.Speak("Podemos ver el primer ejercicio de dominios");
            Avatar.Hide();

            
        }

        private void pictureBox12_Click(object sende)
        {

        }

        private void BtnSolucionEj2_Click(object sender, EventArgs e)
        {
            SolucionEj2.Visible = true;
            SolucionEj1.Visible = false;
        }

        private void BtnSiguientEj_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ejercicio2Dom IrTED = new Ejercicio2Dom();
            IrTED.Show();
        }

        private void Ejemplo1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
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

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Avatar.Show(0);
            Avatar.MoveTo(690, 7, 1);
            Avatar.Speak("El dominio de una función racional es ℛ menos los valores que anulan el denominador" +
                " Tenemos que igualar el denominador a cero y resolver la ecuación. Las soluciones a la ecuación " +
                "son los puntos que no pertenecen al dominio, ya que anulan el denominador");
            Avatar.Hide();
        }
    }
}
