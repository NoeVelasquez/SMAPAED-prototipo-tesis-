using CapaNegocio;
using Proy_SistemaApoyoMatemetico.Formularios;

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
    public partial class Funciones : Form
    {
        public string datoNombre;
        public Funciones()
        {
            InitializeComponent();
                     

        }
        
        private void BotonesIniciales()
        {
            BtnBoton1.Location = new Point(4, 74);
            BtnBoton2.Location = new Point(4, 109);
            BtnBoton3.Location = new Point(4, 144);
            BtnBoton4.Location = new Point(4, 179);
            BtnBoton5.Location = new Point(4, 214);
            BtnBoton6.Location = new Point(4, 249);
        }
        /*AREA PARA INTRO A FUNCIONES*/
        private void AbrirArea(object FormHijo)
        {
            if (this.PanelContenedor.Controls.Count > 0)
            {
                this.PanelContenedor.Controls.RemoveAt(0);

            }

            Form fh = FormHijo as Form;
            
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;

            fh.Show();


        }
        //Segunda Forma de creacion para agregar
        private void abriform<MiFormulario>()where MiFormulario: Form, new()
        {
            Form Frm;
            Frm = PanelContenedor.Controls.OfType<MiFormulario>().FirstOrDefault();

            if(Frm == null)
            {
                Frm = new MiFormulario();
                Frm.TopLevel = false;
                Frm.FormBorderStyle = FormBorderStyle.None;
                Frm.Dock = DockStyle.Fill;
                PanelContenedor.Controls.Add(Frm);
                PanelContenedor.Tag = Frm;
                Frm.Show();
                Frm.BringToFront();
            }
            else
            {
                Frm.BringToFront();
            }
        }

        private void BtnBoton1_Click(object sender, EventArgs e)
        {
            if(PanelBoton1.Visible == true)
            {
                PanelBoton1.Visible = false;
            }
            else
            {
                PanelBoton1.Visible = true;
            }

            BtnBoton1.Location = new Point(4, 74);
            PanelBoton1.Location = new Point(4,108);
            BtnBoton2.Location = new Point(4, 228);//localizacion cambia
            BtnBoton3.Location = new Point(4, 263);//localizacion cambia
            BtnBoton4.Location = new Point(4, 298);//localizacion cambia
            BtnBoton5.Location = new Point(4, 333);//localizacion cambia
            BtnBoton6.Location = new Point(4, 368);
            PanelBoton2.Hide();
            PanelBoton3.Hide();
            PanelBoton4.Hide();
            PanelBoton5.Hide();
            PanelBoton6.Hide();

            if (PanelBoton1.Visible == false)
            {
                BotonesIniciales();
            }
            
        }

        private void Funciones_Load(object sender, EventArgs e)
        {
            BotonesIniciales();//localizacion inicial
            PanelBoton1.Hide();
            PanelBoton2.Hide();
            PanelBoton3.Hide();
            PanelBoton4.Hide();
            PanelBoton5.Hide();
            PanelBoton6.Hide();
            //AbrirArea(new IntroFuncion());
            abriform<IntroFuncion>();
           



        }
        private void BtnBoton2_Click(object sender, EventArgs e)
        {
            
            String nota = "0";
            FlblNota.Text = nota;
            MessageBox.Show(nota);//hay que validar las notas de los examenes en este caso se debe jalar de la base de dato mejor llevarlo a un label y convertirlo a otro dato para generarlo
            /*if (Convert.ToInt64(nota) > 51)
            {*/
                
                if (PanelBoton2.Visible == true)
                {
                    PanelBoton2.Visible = false;
                }
                else
                {
                    PanelBoton2.Visible = true;
                }
                BtnBoton1.Location = new Point(4, 74);
                PanelBoton1.Hide();
                PanelBoton3.Hide();
                PanelBoton4.Hide();
                PanelBoton5.Hide();
                PanelBoton6.Hide();
                BtnBoton2.Location = new Point(4, 109);
                PanelBoton2.Location = new Point(4, 143);
                BtnBoton3.Location = new Point(4, 300);//localizacion cambia
                BtnBoton4.Location = new Point(4, 335);//localizacion cambia
                BtnBoton5.Location = new Point(4, 370);//localizacion cambia
                BtnBoton6.Location = new Point(4, 405);

                if (PanelBoton2.Visible == false)
                {
                    BotonesIniciales();

                }
            /*}
            else
            {
                MessageBox.Show("No puedes acceder por que tu nota en el examen anterior es: /100","NO PUEDES ACCEDER AÚN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
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
            BtnBoton1.Location = new Point(4, 74);
            BtnBoton2.Location = new Point(4, 109);
            PanelBoton1.Hide();
            PanelBoton2.Hide();
            PanelBoton4.Hide();
            PanelBoton5.Hide();
            PanelBoton6.Hide();
            BtnBoton3.Location = new Point(4, 144);
            PanelBoton3.Location = new Point(4,178);
            BtnBoton4.Location = new Point(4, 335);
            BtnBoton5.Location = new Point(4, 370);
            BtnBoton6.Location = new Point(4, 405);

            if (PanelBoton3.Visible == false)
            {
                BotonesIniciales();
            }
        }

        private void BtnBoton4_Click(object sender, EventArgs e)
        {
            if (PanelBoton4.Visible == true)
            {
                PanelBoton4.Visible = false;
            }
            else
            {
                PanelBoton4.Visible = true;
            }
            BtnBoton1.Location = new Point(4, 74);
            BtnBoton2.Location = new Point(4, 109);
            BtnBoton3.Location = new Point(4, 144);
            PanelBoton1.Hide();
            PanelBoton2.Hide();
            PanelBoton3.Hide();
            PanelBoton5.Hide();
            PanelBoton6.Hide();
            BtnBoton4.Location = new Point(4, 179);
            PanelBoton4.Location = new Point(4, 213);
            BtnBoton5.Location = new Point(4, 370);
            BtnBoton6.Location = new Point(4, 405);

            if (PanelBoton4.Visible == false)
            {
                BotonesIniciales();
            }
        }

        private void BtnBoton5_Click(object sender, EventArgs e)
        {
            if (PanelBoton5.Visible == true)
            {
                PanelBoton5.Visible = false;
            }
            else
            {
                PanelBoton5.Visible = true;
            }
            BtnBoton1.Location = new Point(4, 74);
            BtnBoton2.Location = new Point(4, 109);
            BtnBoton3.Location = new Point(4, 144);
            BtnBoton4.Location = new Point(4, 179);
            PanelBoton1.Hide();
            PanelBoton2.Hide();
            PanelBoton3.Hide();
            PanelBoton4.Hide();
            PanelBoton6.Hide();
            BtnBoton5.Location = new Point(4, 214);
            PanelBoton5.Location = new Point(4,248);
            BtnBoton6.Location = new Point(4, 405);


            if (PanelBoton5.Visible == false)
            {
                BotonesIniciales();
            }
        }

        private void BtnBoton6_Click(object sender, EventArgs e)
        {
            if (PanelBoton6.Visible == true)
            {
                PanelBoton6.Visible = false;
            }
            else
            {
                PanelBoton6.Visible = true;
            }
            BtnBoton1.Location = new Point(4, 74);
            BtnBoton2.Location = new Point(4, 109);
            BtnBoton3.Location = new Point(4, 144);
            BtnBoton4.Location = new Point(4, 179);
            BtnBoton5.Location = new Point(4, 214);
            PanelBoton1.Hide();
            PanelBoton2.Hide();
            PanelBoton3.Hide();
            PanelBoton4.Hide();
            PanelBoton5.Hide();
            BtnBoton6.Location = new Point(4, 249);
            PanelBoton6.Location = new Point(4, 283);

            if (PanelBoton6.Visible == false)
            {
                BotonesIniciales();
            }
        }

        private void BotonMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuGeneral IrMenGe = new MenuGeneral();
            IrMenGe.lblNombre.Text=FlblNombre.Text;
            IrMenGe.LblApellido.Text=FlblApellido.Text ;
            IrMenGe.lblNota.Text=FlblNota.Text ;
            IrMenGe.LblIDE.Text=FlblIDE.Text;
            IrMenGe.TxtNota.Value= FTxtNota.Value;
            IrMenGe.Show();
        }

        private void BtnMaxim_Click(object sender, EventArgs e)
        {
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void BtnMin_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PanelBoton4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnBoton1P1_Click(object sender, EventArgs e)
        {
            //abriform<>(TiposFun);
            AbrirArea(new TiposFun());
        }

        private void PanelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnBoton2P1_Click(object sender, EventArgs e)
        {
            AbrirArea(new DominioVideo());
        }

        private void BtnBoton2P2_Click(object sender, EventArgs e)
        {
            AbrirArea(new EjercicioDom());
        }

        private void BtnBoton2P3_Click(object sender, EventArgs e)
        {
            AbrirArea(new Ejercicio2Dom());
        }

        private void BtnBoton3P1_Click(object sender, EventArgs e)
        {
            AbrirArea(new VideoExpo());
        }

        private void BtnBoton3P2_Click(object sender, EventArgs e)
        {
            AbrirArea(new EjerExpo());
        }

        private void BtnBoton3P3_Click(object sender, EventArgs e)
        {
            AbrirArea(new Ejer2Expo());
        }

        private void BtnBoton4P1_Click(object sender, EventArgs e)
        {
            AbrirArea(new VideoTrigo());
        }

        private void BtnBoton4P2_Click(object sender, EventArgs e)
        {
            AbrirArea(new EjercicioTrigo());
        }

        private void BtnBoton4P3_Click(object sender, EventArgs e)
        {
            AbrirArea(new Ejericcio2Trigo());
        }

        private void BtnBoton5P1_Click(object sender, EventArgs e)
        {
            AbrirArea(new VideoLogar());
        }

        private void BtnBoton5P2_Click(object sender, EventArgs e)
        {
            AbrirArea(new EjercicioLogar());
        }

        private void BtnBoton5P3_Click(object sender, EventArgs e)
        {
            AbrirArea(new Ejercicio2Logar());
        }

        private void BtnBoton1P2_Click(object sender, EventArgs e)
        {
            AbrirArea(new QueFunciones());
        }

        private void BtnBoton6P01_Click(object sender, EventArgs e)
        {

        }

        private void BtnBoton1P3_Click(object sender, EventArgs e)
        {
            CuestTipFun tipFun = new CuestTipFun();
             
            tipFun.CLblIDE.Text = FlblIDE.Text.ToString();
            tipFun.Show();
            
            
        }

        private void BtnBoton2P4_Click(object sender, EventArgs e)
        {
            AbrirArea(new CuestDom());
        }

        private void BtnBoton3P4_Click(object sender, EventArgs e)
        {
            AbrirArea(new CuestExpo());
        }

        private void BtnBoton4P4_Click(object sender, EventArgs e)
        {
            AbrirArea(new CuesTrigo());
        }

        private void BtnBoton5P4_Click(object sender, EventArgs e)
        {
            AbrirArea(new CuesLogar());
        }

       
    }
}
