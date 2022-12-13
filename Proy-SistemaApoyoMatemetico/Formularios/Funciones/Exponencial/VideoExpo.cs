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
    public partial class VideoExpo : Form
    {
        private AgentObjects.IAgentCtlCharacter Avatar;
        public VideoExpo()
        {
            InitializeComponent();
        }

        private void VideoExpo_Load(object sender, EventArgs e)
        {
            ControlAgTED.Characters.Load("Robby", "Robby.acs");
            Avatar = (IAgentCtlCharacter)ControlAgTED.Characters["Robby"];
            Avatar.Show(0);
            Avatar.MoveTo(690, 7, 1);
            Avatar.Speak("Podemos ver el video de Funciones exponenciales");


            string html = ("<html> <head>");
            html += ("<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>");
            html += ("<iframe width='800' height='500' src='https://www.youtube.com/embed/XdaB464Gt4M' title='YouTube video player' frameborder='0' allow='accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture' allowfullscreen></iframe>");
            html += (" </body>  </html> ");
            string text = "https://www.youtube.com/embed/XdaB464Gt4M";
            //txtLink.Text.Split('=')[1]
            this.webBrowser1.DocumentText = string.Format(html, text);
            //webBrowser1.Navigate($https://youtu.be/Ll7xfe3HoZE);,
            Avatar.Speak("es una de las funciones más importantes en matemáticas. " +
                "Para formar una función exponencial, hacemos que la variable " +
                "independiente sea el exponente. Estas funciones son usadas en muchas " +
                "situaciones de la vida real. Principalmente, son usadas para el " +
                "crecimiento poblacional, interés compuesto o radioactividad.");
            Avatar.Hide(50);
        }
    }
}
