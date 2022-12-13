using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaEntidad;
using CapaNegocio;

namespace Proy_SistemaApoyoMatemetico
{
    public partial class VerPreguntas : Form
    {//Cadena de conexion a la Base de Datos
        //public readonly SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
        public string ruta = ConfigurationManager.ConnectionStrings["cadenaconexion"].ConnectionString;

         byte[] bitFoto;
        public VerPreguntas()
        {
            InitializeComponent();
        }
        N_Pregunta NP = new N_Pregunta();
        private void VerPreguntas_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = NP.ListarPregunta().Tables["tbl"];
            //bitsFoto =(byte[])
            dataGridView1.Columns["Foto"].Visible = false;
           
        }
        
        
        public void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           // listar(Convert.ToInt32(TxtIDPRE.Text));
            byte[] buffer = (byte[])dataGridView1.CurrentRow.Cells["Foto"].Value;
            System.IO.MemoryStream ms = new System.IO.MemoryStream(buffer);

            PresentarPregunta Pp = new PresentarPregunta();
            //Pp.PbPreguntaIMG.Image = obtenerImagen((byte[])dataGridView1.CurrentRow.Cells[2].Value);
            //Bitmap imagen = new Bitmap(new System.IO.MemoryStream(buffer));
            //Pp.PbPreguntaIMG.Image = Image.FromStream(ByteImage());

            
            Pp.PbPreguntaIMG.Image = System.Drawing.Image.FromStream(ms);
            

            Pp.TxtPregunta.Text = dataGridView1.CurrentRow.Cells["Titulo"].Value.ToString();
            Pp.RBOPA.Text = dataGridView1.CurrentRow.Cells["opA"].Value.ToString();
            Pp.RBOPB.Text = dataGridView1.CurrentRow.Cells["opB"].Value.ToString();
            Pp.RBOPC.Text = dataGridView1.CurrentRow.Cells["opC"].Value.ToString();
            Pp.RBOPD.Text = dataGridView1.CurrentRow.Cells["opD"].Value.ToString();
            Pp.TxtCorrecto.Text = dataGridView1.CurrentRow.Cells["opCorrecto"].Value.ToString();
            Pp.DatoCombobox.Text = dataGridView1.CurrentRow.Cells["IDEx_Fk"].Value.ToString();
            Pp.ShowDialog();
        }
        private void listar(int da)
        {
            AccesoDatos.clsaccesodatos dato = new AccesoDatos.clsaccesodatos();
            dato.cadenaconexion = ruta;
            if(dato.abrirconexion() == true) 
            {
                DataTable dt = dato.consultar("[dbo].[Listar_Preguntas]",da).Tables[0];
                if(dt.Rows.Count==0)
                {
                    dato.cerrarconexion();
                    MessageBox.Show("Noe encontrado", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    bitFoto = (byte[])dt.Rows[2]["Foto"];
                    dato.cerrarconexion();
                }
               
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
