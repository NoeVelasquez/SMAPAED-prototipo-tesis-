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
    public partial class DefVid2Dervcs : Form
    {
        public DefVid2Dervcs()
        {
            InitializeComponent();
        }

        private void DefVid2Dervcs_Load(object sender, EventArgs e)
        {
            string html = ("<html> <head>");
            html += ("<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>");
            html += ("<iframe width='920' height='565' src='https://www.youtube.com/embed/7rkTOfW3paw' title='YouTube video player' frameborder='0' allow='accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture' allowfullscreen></iframe>");
            html += (" </body>  </html> ");
            string text = "https://www.youtube.com/embed/7rkTOfW3paw";
            //txtLink.Text.Split('=')[1]
            this.webBrowser1.DocumentText = string.Format(html, text);
        }
    }
}
