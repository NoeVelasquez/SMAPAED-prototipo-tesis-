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

namespace Proy_SistemaApoyoMatemetico
{
    public partial class DefinicionVide : Form
    {
        private AgentObjects.IAgentCtlCharacter Avatar;
        public DefinicionVide()
        {
            InitializeComponent();
        }

        private void DefinicionVideoDer_Load(object sender, EventArgs e)
        {
            ControlAgTED.Characters.Load("Robby", "Robby.acs");
            Avatar = (IAgentCtlCharacter)ControlAgTED.Characters["Robby"];
            Avatar.Show(0);
            Avatar.MoveTo(800, 234, 1);
            Avatar.Speak("Hola Bienvenido al Menú de Derivadas, Mi Nombre es TED, Sere tu tutor " +
                "y te indicare todo lo que sea necesario para que puedas entender cada tema");
            Avatar.MoveTo(800, 234, 1);
            Avatar.Speak("Para entender mejor puede ver el video sobre derivadas");
            Avatar.Hide();
            string html = ("<html> <head>");
            html += ("<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>");
            html += ("<iframe width='920' height='565' src='https://www.youtube.com/embed/AzTGmJGIpI8' title='YouTube video player' frameborder='0' allow='accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture' allowfullscreen></iframe>");
            html += (" </body>  </html> ");
            string text = "https://www.youtube.com/embed/4G_A74UkDPs";
            //txtLink.Text.Split('=')[1]
            this.webBrowser1.DocumentText = string.Format(html, text);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
