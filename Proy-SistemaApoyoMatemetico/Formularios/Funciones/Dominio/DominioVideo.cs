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
    public partial class DominioVideo : Form
    {
        private AgentObjects.IAgentCtlCharacter Avatar;
        public DominioVideo()
        {
            InitializeComponent();
        }

        private void IntroFunTeo_Load(object sender, EventArgs e)
        {
            ControlAgTED.Characters.Load("Robby", "Robby.acs");
            Avatar = (IAgentCtlCharacter)ControlAgTED.Characters["Robby"];
            Avatar.Show(0);
            Avatar.MoveTo(690, 7, 1);
            Avatar.Speak("Podemos ver el video de dominios");
            

            string html = ("<html> <head>");
            html += ("<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>");
            html += ("<iframe width='920' height='565' src='https://www.youtube.com/embed/jBJ2ZgIcmJI' title='YouTube video player' frameborder='0' allow='accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture' allowfullscreen></iframe>");
            html += (" </body>  </html> ");
            string text = "https://www.youtube.com/embed/jBJ2ZgIcmJI";
            //txtLink.Text.Split('=')[1]
            this.webBrowser1.DocumentText = string.Format(html, text);
            //webBrowser1.Navigate($https://youtu.be/Ll7xfe3HoZE);,
            Avatar.Speak("El dominio de una función es el conjunto de todos" +
                " los valores de entrada que una función puede tomar. Podemos " +
                "pensar en el dominio como el conjunto de todos los valores de " +
                "x que hacen que la función tenga salidas reales.");
            Avatar.Speak("El rango de una función es el conjunto de todos los " +
                "valores de salida que una función puede producir.Podemos pensar " +
                "en el rango como el conjunto de los valores de y que resultan " +
                "después de usar todos los valores del dominio.");
            Avatar.Hide(50);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }


        private void ControlAgTED_ActivateInput(object sender, AxDoubleAgentCtl._DaCtlEvents2_ActivateInputEvent e)
        {

        }
    }
}
