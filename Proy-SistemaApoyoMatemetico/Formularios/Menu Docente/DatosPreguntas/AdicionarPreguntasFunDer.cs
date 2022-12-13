using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Configuration;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;
using CapaNegocio;

namespace Proy_SistemaApoyoMatemetico
{
    public partial class AdicionarPreguntasFunDer : Form
    {
        public string ruta = ConfigurationManager.ConnectionStrings["cadenaconexion"].ConnectionString;
        public byte[] buffer;
        E_Preguntas Pre = new E_Preguntas();
        N_Pregunta NP = new N_Pregunta();
        private int? idbusqueda = null;
        public AdicionarPreguntasFunDer()
        {
            InitializeComponent();
        }
        public AdicionarPreguntasFunDer(int idbusqueda) : this()
        {
            this.idbusqueda = idbusqueda;
        }
        int dato;
        private void BtAgregarPregunta_Click(object sender, EventArgs e)
        {
            /*****IMPORTANTE *****/
            bool respuesta;

            //Pre.FOTO = this.buffer;
            Pre.TITULO = TxtPregunta.Text;
            Pre.OPA = TxtOpA.Text;
            Pre.OPB = TxtOpB.Text;
            Pre.OPC = TxtOpC.Text;
            Pre.OPD = TxtOpD.Text;
            Pre.CORRECTO = TxtOpCorrecto.Text;
            Pre.ACTUALIZA = System.DateTime.Now.ToShortDateString();
            Pre.IDC = Convert.ToInt32(LblIDDoc.Text);
            Pre.IDE = CBDatoExamen.SelectedValue.ToString();

            respuesta = NP.ValidarPregunta(Pre);
            if (respuesta == false)
            {
                return;
            }
            //NP.CrearPregunta(Pre);
            if (MessageBox.Show("¿Esta seguro de registrar la Pregunta?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Mantenimiento("N");
                dato = Convert.ToInt32(LblIDDoc.Text);
            }
            Limpiar();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            string nombrearchivo = "";

            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "All Bitmap files|*.bmp;*.jpg;*.jpeg;*.png";

            ofd.Title = "Open a Bitmap File";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                nombrearchivo = ofd.FileName;

                FileStream fs;

                fs = new FileStream(nombrearchivo, FileMode.Open);

                FileInfo fi;

                fi = new FileInfo(nombrearchivo);

                long longitud;

                longitud = fi.Length;
                buffer = new byte[longitud];

                fs.Read(buffer, 0, Convert.ToInt32(longitud));

                fs.Close();

                Bitmap imagen = new Bitmap(new MemoryStream(buffer));

                PBFoto.Image = imagen;
                MessageBox.Show(this.buffer.ToString());

                //PBFoto.Image = Image.FromFile(ofd.FileName);
            }
            else
            {

                ofd.FileName = "boton-cerrar.png";
                //ofd.FileName = "Proy_SistemaApoyoMatemetico.Properties.Resources.boton-cerrar.png";
                nombrearchivo = ofd.FileName;

                FileStream fs;

                fs = new FileStream(nombrearchivo, FileMode.Open);

                FileInfo fi;

                fi = new FileInfo(nombrearchivo);

                long longitud;

                longitud = fi.Length;
                buffer = new byte[longitud];
                fs.Read(buffer, 0, Convert.ToInt32(longitud));

                fs.Close();

                Bitmap imagen = new Bitmap(new MemoryStream(buffer));

                PBFoto.Image = imagen;
            }
        }

        private void AdicionarPreguntasFunDer_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'datosExamenOficial.Examenes' Puede moverla o quitarla según sea necesario.
            this.examenesTableAdapter.Fill(this.datosExamenOficial.Examenes);
            if (idbusqueda.HasValue)
                LblIDDoc.Text = Convert.ToString(idbusqueda);
        }

        int rpta = -1;
        string mensaje = "";
        public string __mesajeerror = "";
        private void Mantenimiento(string operacion)
        {
            AccesoDatos.clsaccesodatos servidor = new AccesoDatos.clsaccesodatos();
            servidor.cadenaconexion = ruta;
            if (servidor.abrirconexiontrans() == true)
            {
                servidor.ejecutar("[dbo].[ParaCrePreguntaFyD]", false, ref rpta, ref mensaje
                   , 1
                   , TxtPregunta.Text
                   , this.buffer
                   , TxtOpA.Text
                   , TxtOpB.Text
                   , TxtOpC.Text
                   , TxtOpD.Text
                   , TxtOpCorrecto.Text
                   , System.DateTime.Now.ToShortDateString()
                   , LblIDDoc.Text
                   , CBDatoExamen.SelectedValue.ToString()
                   , operacion, 0, "");
                if (rpta > 0)
                {
                    servidor.cerrarconexiontrans();
                    __mesajeerror = mensaje;
                    MessageBox.Show(__mesajeerror, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    servidor.cancelarconexiontrans();
                    __mesajeerror = mensaje;
                    MessageBox.Show(__mesajeerror, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                servidor.cancelarconexiontrans();
                __mesajeerror = servidor.getMensageError();
                MessageBox.Show(__mesajeerror, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Limpiar()
        {
            PBFoto.Image = null;
            TxtPregunta.Text = string.Empty;
            TxtOpA.Text = string.Empty;
            TxtOpB.Text = string.Empty;
            TxtOpC.Text = string.Empty;
            TxtOpD.Text = string.Empty;
            TxtOpCorrecto.Text = string.Empty;
            CBDatoExamen.SelectedValue = 0;
        }
    }
}
