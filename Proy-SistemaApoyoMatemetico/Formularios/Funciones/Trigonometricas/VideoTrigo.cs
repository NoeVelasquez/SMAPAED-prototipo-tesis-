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
    public partial class VideoTrigo : Form
    {
        private AgentObjects.IAgentCtlCharacter Avatar;
        public VideoTrigo()
        {
            InitializeComponent();
        }

        private void VideoTrigo_Load(object sender, EventArgs e)
        {
            ControlAgTED.Characters.Load("Robby", "Robby.acs");
            Avatar = (IAgentCtlCharacter)ControlAgTED.Characters["Robby"];
            Avatar.Show(0);
            Avatar.MoveTo(690, 7, 1);
            Avatar.Speak("Podemos ver el video de Funciones Trigonometricas");


            string html = ("<html> <head>");
            html += ("<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>");
            html += ("<iframe width='800' height='500'  src='https://www.youtube.com/embed/WdfWMMrsCLo' title='YouTube video player' frameborder='0' allow='accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture' allowfullscreen></iframe>");
            html += (" </body>  </html> ");
            string text = "https://www.youtube.com/embed/WdfWMMrsCLo";
            //txtLink.Text.Split('=')[1]
            this.webBrowser1.DocumentText = string.Format(html, text);
            Avatar.Speak("son funciones de un ángulo o de una cantidad " +
                "abstracta usada en trigonometría. Estas funciones incluyen " +
                "al seno, coseno, tangente, cosecante, secante y cotangente. " +
                "Las funciones trigonométricas tienen una gran variedad de " +
                "aplicaciones en diferentes áreas como ingeniería, ciencia, " +
                "arquitectura y construcción.");
            Avatar.Hide(50);
        }
    }
}
