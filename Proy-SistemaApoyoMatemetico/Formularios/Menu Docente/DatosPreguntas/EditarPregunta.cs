using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaEntidad;
using CapaNegocio;
using System.Drawing.Imaging;
using System.IO;
using System.Configuration;

namespace Proy_SistemaApoyoMatemetico
{
    public partial class EditarPregunta : Form
    {
        public string ruta = ConfigurationManager.ConnectionStrings["cadenaconexion"].ConnectionString;
        public byte[] buffer;
        E_Preguntas Pre = new E_Preguntas();
        N_Pregunta NP = new N_Pregunta();
        private int? idbusqueda = null;


        public EditarPregunta()
        {
            InitializeComponent();
        }

        private void AgregarPregunta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'datosExamenOficial.Examenes' Puede moverla o quitarla según sea necesario.
            this.examenesTableAdapter.Fill(this.datosExamenOficial.Examenes);


            TablaPreguntasEditar.DataSource = NP.ListarPregunta().Tables["tbl"];
            //bitsFoto =(byte[])
            TablaPreguntasEditar.Columns["IDPreg"].Visible = false;
            TablaPreguntasEditar.Columns["Foto"].Visible = false;
            TablaPreguntasEditar.Columns["FechaActualizacion"].Visible = false;
            TablaPreguntasEditar.Columns["IDC_Fk"].Visible = false;
            TablaPreguntasEditar.Columns["IDEx_Fk"].Visible = false;

            CBDatoExamen.SelectedValue = 0;
            DatoCombobox.Text = "0";
            if (idbusqueda.HasValue)
                LblIDDoc.Text = Convert.ToString(idbusqueda);
            //DatoCombobox.Text = CBDatoExamen.SelectedValue.ToString();
        }

        
       

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
               // MessageBox.Show(this.buffer.ToString());

                //PBFoto.Image = Image.FromFile(ofd.FileName);
            }
            else
            {
                ofd.FileName = "boton-cerrar.png";
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
        private byte[] ConvertirIma()
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            PBFoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
            return ms.GetBuffer();
        }

        int dato;
        private void BtnAgregarPregunta_Click(object sender, EventArgs e)
        {
            bool respuesta;
            Pre.ID =(int) TxtIDP.Value;
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
            DatoCombobox.Text = CBDatoExamen.SelectedValue.ToString();
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
            TablaPreguntasEditar.DataSource = NP.ListarPregunta().Tables["tbl"];
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
                servidor.ejecutar("[dbo].[EditarPregunta]", false, ref rpta, ref mensaje
                   , (int)TxtIDP.Value//se guarda el id que tenga
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
        public EditarPregunta(int idbusqueda) : this()
        {
            this.idbusqueda = idbusqueda;
        }
        private void Limpiar()
        {
            TxtIDP.Value = 0;
            PBFoto.Image = null;
            TxtPregunta.Text = string.Empty;
            TxtOpA.Text = string.Empty;
            TxtOpB.Text = string.Empty;
            TxtOpC.Text = string.Empty;
            TxtOpD.Text = string.Empty;
            TxtOpCorrecto.Text = string.Empty;
            CBDatoExamen.SelectedValue = 7;
        }
        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (TablaPreguntasEditar.SelectedRows.Count > 0)
            {
                TxtIDP.Value = (int)TablaPreguntasEditar.CurrentRow.Cells["IDPreg"].Value;
                byte[] buffer = (byte[])TablaPreguntasEditar.CurrentRow.Cells["Foto"].Value;
                System.IO.MemoryStream ms = new System.IO.MemoryStream(buffer);
                PBFoto.Image = System.Drawing.Image.FromStream(ms);
                TxtPregunta.Text = TablaPreguntasEditar.CurrentRow.Cells["Titulo"].Value.ToString();
                TxtOpA.Text = TablaPreguntasEditar.CurrentRow.Cells["opA"].Value.ToString();
                TxtOpB.Text = TablaPreguntasEditar.CurrentRow.Cells["opB"].Value.ToString();
                TxtOpC.Text = TablaPreguntasEditar.CurrentRow.Cells["opC"].Value.ToString();
                TxtOpD.Text = TablaPreguntasEditar.CurrentRow.Cells["opD"].Value.ToString();
                TxtOpCorrecto.Text = TablaPreguntasEditar.CurrentRow.Cells["opCorrecto"].Value.ToString();
                DatoCombobox.Text = TablaPreguntasEditar.CurrentRow.Cells["IDEx_Fk"].Value.ToString();
                CBDatoExamen.SelectedValue = DatoCombobox.Text;


            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }
        private void DatoExamen_SelectedIndexChanged(object sender, EventArgs e)
        {
            DatoCombobox.Text = CBDatoExamen.SelectedValue.ToString();
        }
        private void TablaPreguntasEditar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

       
    }
