using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using Microsoft.Win32;

namespace Proy_SistemaApoyoMatemetico
{
    public partial class TeoriaLogicaFormal : Form
    {
        public TeoriaLogicaFormal()
        {
            InitializeComponent();
        }
        LF1NaturalYArtificial LF1 = new LF1NaturalYArtificial();
        LF2DimePreposicion LF2 = new LF2DimePreposicion();
        LF3Lenguaje LF3 = new LF3Lenguaje();
        LF31Lenguaje LF31 = new LF31Lenguaje();
        LF4Negacion LF4 = new LF4Negacion();
        LF5TiposProp LF5 = new LF5TiposProp();
        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void Ima1_Click(object sender, EventArgs e)
        {
            LF1.Show();
        }

        private void Ima2_Click(object sender, EventArgs e)
        {
            LF2.Show();
        }

        private void Ima3_Click(object sender, EventArgs e)
        {
            LF3.Show();
        }

        private void Ima4_Click(object sender, EventArgs e)
        {
            LF4.Show();
        }

        private void Ima5_Click(object sender, EventArgs e)
        {
            LF5.Show();
        }
        private void OpenURL(string url)
        {
            //string key = @"htmlfile\shell\open\command";
            string key = @"http\shell\open\command";
            RegistryKey registryKey = Registry.ClassesRoot.OpenSubKey(key, false);
            // Get the default browser path on the system
            string Default_Browser_Path = ((string)registryKey.GetValue(null, null)).Split('"')[1];

            Process p = new Process();
            p.StartInfo.FileName = Default_Browser_Path;
            p.StartInfo.Arguments = url;
            p.Start();
        }
        private void Ima6_Click(object sender, EventArgs e)
        {
              Process.Start("https://logica.fcalzado.es/tema/31-tablas-de-verdad");
            //OpenURL("http://www.codicode.com");
        }
    }
}
