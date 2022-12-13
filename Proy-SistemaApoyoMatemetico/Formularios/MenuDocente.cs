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
    public partial class MenuDocente : Form
    {
        public int xClic, yClic;
        public MenuDocente()
        {
            InitializeComponent();
        }


        //METODO PARA ABRIR FORM DENTRO DE PANEL-----------------------------------------------------
        private void AbrirFormEnPanel(object formHijo)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();
        }
        private void BotonesIniciales()
        {
            BtnBoton1.Location = new Point(5, 74);
            BtnBoton2.Location = new Point(5, 109);
            BtnBoton3.Location = new Point(5, 144);
            BtnBoton4.Location = new Point(5, 179);


        }
        private void BtnBoton1_Click(object sender, EventArgs e)
        {
            if (PanelBoton1.Visible == true)
            {
                PanelBoton1.Visible = false;
            }
            else
            {
                PanelBoton1.Visible = true;
            }

            BtnBoton1.Location = new Point(5, 74);
            PanelBoton1.Location = new Point(5, 108);
            BtnBoton2.Location = new Point(5,152);//localizacion cambia
            BtnBoton3.Location = new Point(5, 187);//localizacion cambia
            BtnBoton4.Location = new Point(5, 222);
            PanelBoton2.Hide();
            PanelBoton3.Hide();
            PanelBoton4.Hide();
            if (PanelBoton1.Visible == false)
            {
                BotonesIniciales();
            }
        }
        private void BtnBoton2_Click(object sender, EventArgs e)
        {
            if (PanelBoton2.Visible == true)
            {
                PanelBoton2.Visible = false;
            }
            else
            {
                PanelBoton2.Visible = true;
            }

            BtnBoton1.Location = new Point(5, 74);
            BtnBoton2.Location = new Point(5, 109);//localizacion cambia
            PanelBoton2.Location = new Point(5, 144);
            BtnBoton3.Location = new Point(5, 280);//localizacion cambia 290 
            BtnBoton4.Location = new Point(5, 315);//325
            PanelBoton1.Hide();
            PanelBoton3.Hide();
            PanelBoton4.Hide();

            if (PanelBoton2.Visible == false)
            {
                BotonesIniciales();
            }
        }

        private void BtnBoton3_Click(object sender, EventArgs e)
        {
            if (PanelBoton3.Visible == true)
            {
                PanelBoton3.Visible = false;
            }
            else
            {
                PanelBoton3.Visible = true;
            }

            BtnBoton1.Location = new Point(5, 74);
            BtnBoton2.Location = new Point(5, 109);//localizacion cambia
            BtnBoton3.Location = new Point(5, 144);//localizacion cambia
            PanelBoton3.Location = new Point(5, 178);//178
            BtnBoton4.Location = new Point(5, 257);//259
            PanelBoton1.Hide();
            PanelBoton2.Hide();
            PanelBoton4.Hide();

            if (PanelBoton3.Visible == false)
            {
                BotonesIniciales();
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (PanelBoton4.Visible == true)
            {
                PanelBoton4.Visible = false;
            }
            else
            {
                PanelBoton4.Visible = true;
            }

            BtnBoton1.Location = new Point(5, 74);
            BtnBoton2.Location = new Point(5, 109);//localizacion cambia
            BtnBoton3.Location = new Point(5, 144);//localizacion cambia
            BtnBoton4.Location = new Point(5, 179);
            PanelBoton4.Location = new Point(5, 213); 
            PanelBoton1.Hide();
            PanelBoton2.Hide();
            PanelBoton3.Hide();

            if (PanelBoton4.Visible == false)
            {
                BotonesIniciales();
            }
        }
        //AbrirFormEnPanel(new CuestParabola());
        //    CuestParabola CP = new CuestParabola();
        ////CP.Show();
        private void BtnMaxim_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        

        private void BtnBoton2P1_Click(object sender, EventArgs e)
        {
            int idbusqueda = Convert.ToInt32(DoclblIDE.Text);
            AbrirFormEnPanel(new AdicionarPregunta(idbusqueda));
            //AbrirFormEnPanel(new AdicionarPregunta());
            //AdicionarPregunta ap = new AdicionarPregunta();
            //ap.LblIDDoc.Text = DoclblIDE.Text;
            //ap.Show();
        }
        private void BtnBoton2P2_Click(object sender, EventArgs e)
        {
            int idbusqueda = Convert.ToInt32(DoclblIDE.Text);
            AbrirFormEnPanel(new AdicionarPreguntasFunDer(idbusqueda));
        }
        private void BtnBoton2P4_Click(object sender, EventArgs e)
        {
            int idbusqueda = Convert.ToInt32(DoclblIDE.Text);
            AbrirFormEnPanel(new EditarPreguntaFunDer(idbusqueda));
        }
        private void BtnBoton1P1_Click(object sender, EventArgs e)
        {
            DatosEstudiante fm = new DatosEstudiante();
            //fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void BtnBoton3P1_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new ReporteNotas());
            //VP.Show();
            //VP.LblIDDoc.Text = DoclblIDE.Text;
            //AbrirFormEnPanel(new VistaPregunta());
            //VistaPregunta vg = new VistaPregunta();
            //vg.LblIDDoc.Text = DoclblIDE.Text;
            //vg.Show();
        }

        private void MenuDocente_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            BotonesIniciales();//localizacion inicial
            PanelBoton1.Hide();
            PanelBoton2.Hide();
            PanelBoton3.Hide();
            PanelBoton4.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            //AbrirFormEnPanel(new VerPreguntas());
            //VerPreguntas VP = new VerPreguntas();
            int idbusqueda = Convert.ToInt32(DoclblIDE.Text);
            AbrirFormEnPanel(new EditarPregunta(idbusqueda));
        }

        private void BtnBoton4P1_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new ListadoEstudianteNotas());
            ListadoEstudianteNotas CP = new ListadoEstudianteNotas();
        }

        private void lblFecha_Click(object sender, EventArgs e)
        {

        }

        private void BotonMenu_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new ReporteNotasParcial());
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new ListadoEstudianteNotasParcial());
        }

        

        private void bunifuGradientPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                xClic = e.X;
                yClic = e.Y;
            }
            else
            {
                this.Left = this.Left + (e.X);
                this.Top = this.Top + (e.Y);
            }
        }
    }
}
