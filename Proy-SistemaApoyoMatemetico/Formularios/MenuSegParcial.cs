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
using Proy_SistemaApoyoMatemetico.Formularios._2doParcial.Cuestionarios;

namespace Proy_SistemaApoyoMatemetico
{
   
    public partial class MenuSegParcial : Form
    {
        public int xClic, yClic;
        public MenuSegParcial()
        {
            InitializeComponent();
        }
        private void BtnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnMaxim_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuSegParcial_Load(object sender, EventArgs e)
        {
            BotonesIniciales();//localizacion inicial
            PanelBoton1.Hide();
            PanelBoton2.Hide();
            PanelBoton3.Hide();
            PanelBoton4.Hide();
            PanelBoton5.Hide();
            PanelBoton6.Hide();
            PanelBoton7.Hide();
            PanelBoton8.Hide();
            PanelBoton0.Hide();

            timer1.Enabled = true;

        }
        private void BotonesIniciales()
        {
            BtnBoton1.Location = new Point(10, 90);
            BtnBoton2.Location = new Point(10, 142);
            BtnBoton3.Location = new Point(10, 178);//*
            BtnBoton4.Location = new Point(10, 214);//4*
            BtnBoton0.Location = new Point(10, 265);//0*
            BtnBoton5.Location = new Point(10, 317);//5
            BtnBoton6.Location = new Point(10, 353);//6*
            BtnBoton7.Location = new Point(10, 393);//7*
            BtnBoton8.Location = new Point(10, 443);//8

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }
        private void BotonMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuAdministrador IrMenGe = new MenuAdministrador();
            IrMenGe.lblNombre.Text = SGlblNombre.Text;
            IrMenGe.LblApellido.Text = SGlblApellido.Text;
            IrMenGe.lblNota.Text = SGlblNota.Text;
            IrMenGe.LblIDE.Text = SGlblIDE.Text;
            //IrMenGe.TxtNota.Value = Nota SGTxtNota.Value;
            //IrMenGe.LblNotaFinalFun.Text = SGLblNFinal.Text;
            //IrMenGe.LblNotaTF.Text = FLblNotaTipFun.Text;
            //IrMenGe.LblNotaDom.Text = FLblNDom.Text;
            //IrMenGe.LblNotaExpo.Text = FLblNExp.Text;
            //IrMenGe.LblNotaTrig.Text = FLblNTrig.Text;
            //IrMenGe.LblNotaLog.Text = FLblNLog.Text;

            decimal dato = Convert.ToDecimal(SGlblNota.Text);
            if (dato > 70)
            {
                IrMenGe.BtnFunc.Enabled = false;
                IrMenGe.BtnDeriv.Enabled = true;
            }
            else
            {
                IrMenGe.BtnFunc.Enabled = true;
                IrMenGe.BtnDeriv.Enabled = false;
            }
            IrMenGe.Show();
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

            BtnBoton1.Location = new Point(10, 90);
            PanelBoton1.Location = new Point(10, 140);
            BtnBoton2.Location = new Point(10, 313);//localizacion cambia
            BtnBoton3.Location = new Point(10, 349);//localizacion cambia
            BtnBoton4.Location = new Point(10, 385);//localizacion cambia
            BtnBoton0.Location = new Point(10, 436);//localizacion cambia
            BtnBoton5.Location = new Point(10, 488);//localizacion cambia
            BtnBoton6.Location = new Point(10, 524);
            BtnBoton7.Location = new Point(10, 564);
            BtnBoton8.Location = new Point(10, 614);
            PanelBoton2.Hide();
            PanelBoton3.Hide();
            PanelBoton4.Hide();
            PanelBoton0.Hide();
            PanelBoton5.Hide();
            PanelBoton6.Hide();
            PanelBoton7.Hide();
            PanelBoton8.Hide();

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
            BtnBoton1.Location = new Point(10, 90);
            PanelBoton1.Hide();
            PanelBoton3.Hide();
            PanelBoton4.Hide();
            PanelBoton0.Hide();
            PanelBoton5.Hide();
            PanelBoton6.Hide();
            PanelBoton7.Hide();
            PanelBoton8.Hide();
            BtnBoton2.Location = new Point(10, 142);
            PanelBoton2.Location = new Point(10, 175);
            BtnBoton3.Location = new Point(10, 349);//localizacion cambia
            BtnBoton4.Location = new Point(10, 385);//localizacion cambia
            BtnBoton0.Location = new Point(10, 436);//localizacion cambia
            BtnBoton5.Location = new Point(10, 488);//localizacion cambia
            BtnBoton6.Location = new Point(10, 524);
            BtnBoton7.Location = new Point(10, 564);
            BtnBoton8.Location = new Point(10, 614);

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
            BtnBoton1.Location = new Point(10, 90);
            BtnBoton2.Location = new Point(10, 142);
            PanelBoton1.Hide();
            PanelBoton2.Hide();
            PanelBoton4.Hide();
            PanelBoton0.Hide();
            PanelBoton5.Hide();
            PanelBoton6.Hide();
            PanelBoton7.Hide();
            PanelBoton8.Hide();
            BtnBoton3.Location = new Point(10, 178);
            PanelBoton3.Location = new Point(10, 212);
            BtnBoton4.Location = new Point(10, 385);
            BtnBoton0.Location = new Point(10, 436);
            BtnBoton5.Location = new Point(10, 488);//localizacion cambia
            BtnBoton6.Location = new Point(10, 524);
            BtnBoton7.Location = new Point(10, 564);
            BtnBoton8.Location = new Point(10, 614);

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
            BtnBoton1.Location = new Point(10, 90);
            BtnBoton2.Location = new Point(10, 142);
            BtnBoton3.Location = new Point(10, 178);
            PanelBoton1.Hide();
            PanelBoton2.Hide();
            PanelBoton3.Hide();
            PanelBoton0.Hide();
            PanelBoton5.Hide();
            PanelBoton6.Hide();
            PanelBoton7.Hide();
            PanelBoton8.Hide();
            BtnBoton4.Location = new Point(10, 214);
            PanelBoton4.Location = new Point(10, 263);
            BtnBoton0.Location = new Point(10, 436);
            BtnBoton5.Location = new Point(10, 488);//localizacion cambia
            BtnBoton6.Location = new Point(10, 524);
            BtnBoton7.Location = new Point(10, 564);
            BtnBoton8.Location = new Point(10, 614);

            if (PanelBoton4.Visible == false)
            {
                BotonesIniciales();
            }

        }
        private void BtnBoton0_Click(object sender, EventArgs e)
        {
            if (PanelBoton0.Visible == true)
            {
                PanelBoton0.Visible = false;
            }
            else
            {
                PanelBoton0.Visible = true;
            }
            BtnBoton1.Location = new Point(10, 90);
            BtnBoton2.Location = new Point(10, 142);
            BtnBoton3.Location = new Point(10, 178);
            BtnBoton4.Location = new Point(10, 214);
            PanelBoton1.Hide();
            PanelBoton2.Hide();
            PanelBoton3.Hide();
            PanelBoton4.Hide();
            PanelBoton5.Hide();
            PanelBoton6.Hide();
            PanelBoton7.Hide();
            PanelBoton8.Hide();
            BtnBoton0.Location = new Point(10, 265);
            PanelBoton0.Location = new Point(10, 315);
            BtnBoton5.Location = new Point(10, 488);//localizacion cambia
            BtnBoton6.Location = new Point(10, 524);
            BtnBoton7.Location = new Point(10, 564);
            BtnBoton8.Location = new Point(10, 614);

            if (PanelBoton0.Visible == false)
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
            BtnBoton1.Location = new Point(10, 90);
            BtnBoton2.Location = new Point(10, 142);
            BtnBoton3.Location = new Point(10, 178);//*
            BtnBoton4.Location = new Point(10, 214);//4*
            BtnBoton0.Location = new Point(10, 265);//0*
            PanelBoton1.Hide();
            PanelBoton2.Hide();
            PanelBoton3.Hide();
            PanelBoton4.Hide();
            PanelBoton6.Hide();
            PanelBoton7.Hide();
            PanelBoton8.Hide();
            BtnBoton5.Location = new Point(10, 317);
            PanelBoton5.Location = new Point(10, 351);
            BtnBoton6.Location = new Point(10, 524);
            BtnBoton7.Location = new Point(10, 564);
            BtnBoton8.Location = new Point(10, 614);

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
            BtnBoton1.Location = new Point(10, 90);
            BtnBoton2.Location = new Point(10, 142);
            BtnBoton3.Location = new Point(10, 178);//*
            BtnBoton4.Location = new Point(10, 214);//4*
            BtnBoton0.Location = new Point(10, 265);//0*
            PanelBoton1.Hide();
            PanelBoton2.Hide();
            PanelBoton3.Hide();
            PanelBoton4.Hide();
            PanelBoton0.Hide();
            PanelBoton5.Hide();
            PanelBoton7.Hide();
            PanelBoton8.Hide();
            BtnBoton6.Location = new Point(10, 353);//6*
            PanelBoton6.Location = new Point(10, 392);
            BtnBoton7.Location = new Point(10, 429);
            BtnBoton8.Location = new Point(10, 479);

            if (PanelBoton6.Visible == false)
            {
                BotonesIniciales();
            }

        }

        private void BtnBoton7_Click(object sender, EventArgs e)
        {
            if (PanelBoton7.Visible == true)
            {
                PanelBoton7.Visible = false;
            }
            else
            {
                PanelBoton7.Visible = true;
            }
            BtnBoton1.Location = new Point(10, 90);
            BtnBoton2.Location = new Point(10, 142);
            BtnBoton3.Location = new Point(10, 178);//*
            BtnBoton4.Location = new Point(10, 214);//4*
            BtnBoton0.Location = new Point(10, 265);//0*
            BtnBoton5.Location = new Point(10, 317);//5
            BtnBoton6.Location = new Point(10, 353);//6*
            PanelBoton1.Hide();
            PanelBoton2.Hide();
            PanelBoton3.Hide();
            PanelBoton4.Hide();
            PanelBoton0.Hide();
            PanelBoton5.Hide();
            PanelBoton6.Hide();
            PanelBoton8.Hide();
            BtnBoton7.Location = new Point(10, 393);//7*
            PanelBoton7.Location = new Point(10, 441);
            BtnBoton8.Location = new Point(10, 479);

            if (PanelBoton7.Visible == false)
            {
                BotonesIniciales();
            }

        }
        private void BtnBoton8_Click(object sender, EventArgs e)
        {
            if (PanelBoton8.Visible == true)
            {
                PanelBoton8.Visible = false;
            }
            else
            {
                PanelBoton8.Visible = true;
            }
            BtnBoton1.Location = new Point(10, 90);
            BtnBoton2.Location = new Point(10, 142);
            BtnBoton3.Location = new Point(10, 178);//*
            BtnBoton4.Location = new Point(10, 214);//4*
            BtnBoton0.Location = new Point(10, 265);//0*
            BtnBoton5.Location = new Point(10, 317);//5
            BtnBoton6.Location = new Point(10, 353);//6*
            BtnBoton7.Location = new Point(10, 393);//7*
            PanelBoton1.Hide();
            PanelBoton2.Hide();
            PanelBoton3.Hide();
            PanelBoton4.Hide();
            PanelBoton0.Hide();
            PanelBoton5.Hide();
            PanelBoton6.Hide();
            PanelBoton7.Hide();
            BtnBoton8.Location = new Point(10, 443);
            PanelBoton8.Location = new Point(10, 475);

            if (PanelBoton8.Visible == false)
            {
                BotonesIniciales();
            }

        }

       
        private void AbrirSegPar(object FormHijo)
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

       
        /*************************************************/
        private void BtnBoton1P2_Click(object sender, EventArgs e)
        {
            AbrirSegPar(new TeoQueParabola());
        }
        private void BtnBoton1P1_Click(object sender, EventArgs e)
        {
            AbrirSegPar(new EcuacionesParabola());
        }

        private void BtnBoton1P3_Click(object sender, EventArgs e)
        {
            AbrirSegPar(new EjeParabola1());
        }

        private void BtnBoton1P4_Click(object sender, EventArgs e)
        {
            AbrirSegPar(new EjerParabola2());
        }

        private void BtnBoton2P1_Click(object sender, EventArgs e)
        {
            AbrirSegPar(new VidElipse());
        }

        private void BtnBoton2P2_Click(object sender, EventArgs e)
        {
            AbrirSegPar(new TeoriaElipse());
        }

        private void BtnBoton2P3_Click(object sender, EventArgs e)
        {
            AbrirSegPar(new EjeElipse1());
        }

        private void BtnBoton2P4_Click(object sender, EventArgs e)
        {
            AbrirSegPar(new EjeElipse2());
        }
        private void BtnBoton3P1_Click(object sender, EventArgs e)
        {
            AbrirSegPar(new VideHiperbola());
        }

        private void BtnBoton3P2_Click(object sender, EventArgs e)
        {
            AbrirSegPar(new TeoHiperbola());
        }

        private void BtnBoton3P3_Click(object sender, EventArgs e)
        {
            AbrirSegPar(new EjeHiperbola1());
        }

        private void BtnBoton3P4_Click(object sender, EventArgs e)
        {
            AbrirSegPar(new EjeHiperbola2());
        }
        private void BtnBoton4P1_Click(object sender, EventArgs e)
        {
            //AbrirSegPar(new VideLogicaFormal());
            AbrirSegPar(new VideNumeReales());
        }

        private void BtnBoton4P2_Click(object sender, EventArgs e)
        {
            //AbrirSegPar(new TeoriaLogicaFormal());
            AbrirSegPar(new TeoNumReal());
        }

        private void BtnBoton4P3_Click(object sender, EventArgs e)
        {
            //AbrirSegPar(new EjemLogica1());
            AbrirSegPar(new EjeNumReal1());
        }

        private void BtnBoton4P4_Click(object sender, EventArgs e)
        {
            //AbrirSegPar(new EjemLogica2());
            AbrirSegPar(new EjeNumReal2());
        }

        /*PARTE DE EXAMENES*/
        private void BtnBoton1P5_Click(object sender, EventArgs e)
        {
            E_Estudiante est = new E_Estudiante();
            E_Parcial nt = new E_Parcial();
            N_Estudiante ES = new N_Estudiante();
            N_Parcial NT = new N_Parcial();
            est.IDE = Int32.Parse(SGlblIDE.Text);

            var validNot = NT.LoginNotasParcial(est, nt);
            if (validNot == true /*&& nt.Tema1 != 0*/)
            {
                MessageBox.Show("YA REALIZO EL EXAMEN Y SU NOTA FUE DE: " + nt.Tema1.ToString());
            }
            else
            {
                int idbusqueda = Convert.ToInt32(SGlblIDE.Text);
                AbrirSegPar(new CuestParabola(idbusqueda));
                //CuestParabola CP = new CuestParabola();
                //CP.DatoIDE.Text = SGlblIDE.Text.ToString();
                //CP.lblNombreCuestionario.Text = SGlblNombre.Text;
                //CP.LblApellido.Text = SGlblApellido.Text;
                //CP.LblNotaPre.Text = SGlblNota.Text;
                //CP.Show();
                //this.Hide();
            }

        }

        private void BtnBoton2P5_Click(object sender, EventArgs e)
        {
            E_Estudiante est = new E_Estudiante();
            E_Parcial nt = new E_Parcial();
            N_Estudiante ES = new N_Estudiante();
            N_Parcial NT = new N_Parcial();
            est.IDE = Int32.Parse(SGlblIDE.Text);

            var validNot = NT.LoginNotasParcial(est, nt);
            if (validNot == true && nt.Tema2 != 0)
            {
                MessageBox.Show("YA REALIZO EL EXAMEN Y SU NOTA FUE DE: " + nt.Tema2.ToString());
            }
            else
            {
                int idbusqueda = Convert.ToInt32(SGlblIDE.Text);
                AbrirSegPar(new CuestElipse(idbusqueda));
                CuestElipse CE = new CuestElipse();
                CE.LblNotaT1.Text = LblNotaT1.Text;

                //CE.DatoIDE.Text = SGlblIDE.Text.ToString();
                //CE.lblNombreCuestionario.Text = SGlblNombre.Text;
                //CE.LblApellido.Text = SGlblApellido.Text;
                //CE.LblNotaPre.Text = SGlblNota.Text;
                //CE.Show();
                //this.Hide();
            }

        }

        private void BtnBoton3P5_Click(object sender, EventArgs e)
        {
            E_Estudiante est = new E_Estudiante();
            E_Parcial nt = new E_Parcial();
            N_Estudiante ES = new N_Estudiante();
            N_Parcial NT = new N_Parcial();
            est.IDE = Int32.Parse(SGlblIDE.Text);

            var validNot = NT.LoginNotasParcial(est, nt);
            if (validNot == true && nt.Tema2 != 0)
            {
                MessageBox.Show("YA REALIZO EL EXAMEN Y SU NOTA FUE DE: " + nt.Tema2.ToString());
            }
            else
            {
                int idbusqueda = Convert.ToInt32(SGlblIDE.Text);
                AbrirSegPar(new CuestElipse(idbusqueda));
                //CuestElipse CE = new CuestElipse();
                //CE.LblNotaT1.Text = LblNotaT1.Text;
                //CuestElipse CE = new CuestElipse();
                //CE.DatoIDE.Text = SGlblIDE.Text.ToString();
                //CE.lblNombreCuestionario.Text = SGlblNombre.Text;
                //CE.LblApellido.Text = SGlblApellido.Text;
                //CE.LblNotaPre.Text = SGlblNota.Text;
                //CE.Show();
                //this.Hide();
            }
        }

        private void BtnBoton4P5_Click(object sender, EventArgs e)
        {
            E_Estudiante est = new E_Estudiante();
            E_Parcial nt = new E_Parcial();
            N_Estudiante ES = new N_Estudiante();
            N_Parcial NT = new N_Parcial();
            est.IDE = Int32.Parse(SGlblIDE.Text);

            var validNot = NT.LoginNotasParcial(est, nt);
            if (validNot == true && nt.Tema3 != 0)
            {
                MessageBox.Show("YA REALIZO EL EXAMEN Y SU NOTA FUE DE: " + nt.Tema3.ToString());
            }
            else
            {
                int idbusqueda = Convert.ToInt32(SGlblIDE.Text);
                AbrirSegPar(new CuestNumerosReales(idbusqueda));

                //CuestNumerosReales CE = new CuestNumerosReales();
                //CE.DatoIDE.Text = SGlblIDE.Text.ToString();
                //CE.lblNombreCuestionario.Text = SGlblNombre.Text;
                //CE.LblApellido.Text = SGlblApellido.Text;
                //CE.LblNotaPre.Text = SGlblNota.Text;
                //CE.Show();
                //this.Hide();
            }
        }
        private void BtnBoton0P5_Click(object sender, EventArgs e)
        {
            E_Estudiante est = new E_Estudiante();
            E_Parcial nt = new E_Parcial();
            N_Estudiante ES = new N_Estudiante();
            N_Parcial NT = new N_Parcial();
            est.IDE = Int32.Parse(SGlblIDE.Text);

            var validNot = NT.LoginNotasParcial(est, nt);
            if (validNot == true && nt.Tema4 != 0)
            {
                MessageBox.Show("YA REALIZO EL EXAMEN Y SU NOTA FUE DE: " + nt.Tema4.ToString());
            }
            else
            {
                int idbusqueda = Convert.ToInt32(SGlblIDE.Text);
                AbrirSegPar(new CuestLogForm(idbusqueda));
                //CuestElipse CE = new CuestElipse();
                //CE.DatoIDE.Text = SGlblIDE.Text.ToString();
                //CE.lblNombreCuestionario.Text = SGlblNombre.Text;
                //CE.LblApellido.Text = SGlblApellido.Text;
                //CE.LblNotaPre.Text = SGlblNota.Text;
                //CE.Show();
                //this.Hide();
            }
        }
        private void BtnBoton5P1_Click(object sender, EventArgs e)
        {
            AbrirSegPar(new ViDesigualdad());
        }

        private void BtnBoton5P2_Click(object sender, EventArgs e)
        {
            AbrirSegPar(new TeoDesigualdad());
        }

        private void BtnBoton5P3_Click(object sender, EventArgs e)
        {
            AbrirSegPar(new EjeDes1());
        }

        private void BtnBoton5P4_Click(object sender, EventArgs e)
        {
            AbrirSegPar(new EjeDEs2());
        }
        private void BtnBoton5P5_Click(object sender, EventArgs e)
        {
            E_Estudiante est = new E_Estudiante();
            E_Parcial nt = new E_Parcial();
            N_Estudiante ES = new N_Estudiante();
            N_Parcial NT = new N_Parcial();
            est.IDE = Int32.Parse(SGlblIDE.Text);

            var validNot = NT.LoginNotasParcial(est, nt);
            if (validNot == true && nt.Tema5 != 0)
            {
                MessageBox.Show("YA REALIZO EL EXAMEN Y SU NOTA FUE DE: " + nt.Tema5.ToString());
            }
            else
            {
                int idbusqueda = Convert.ToInt32(SGlblIDE.Text);
                AbrirSegPar(new CuestDes(idbusqueda));
                //CuestElipse CE = new CuestElipse();
                //CE.DatoIDE.Text = SGlblIDE.Text.ToString();
                //CE.lblNombreCuestionario.Text = SGlblNombre.Text;
                //CE.LblApellido.Text = SGlblApellido.Text;
                //CE.LblNotaPre.Text = SGlblNota.Text;
                //CE.Show();
                //this.Hide();
            }
        }

        private void BtnBoton6P5_Click(object sender, EventArgs e)
        {
            E_Estudiante est = new E_Estudiante();
            E_Parcial nt = new E_Parcial();
            N_Estudiante ES = new N_Estudiante();
            N_Parcial NT = new N_Parcial();
            est.IDE = Int32.Parse(SGlblIDE.Text);

            var validNot = NT.LoginNotasParcial(est, nt);
            if (validNot == true && nt.Tema6 != 0)
            {
                MessageBox.Show("YA REALIZO EL EXAMEN Y SU NOTA FUE DE: " + nt.Tema6.ToString());
            }
            else
            {
                int idbusqueda = Convert.ToInt32(SGlblIDE.Text);
                AbrirSegPar(new CuestLimites(idbusqueda));
                //CuestElipse CE = new CuestElipse();
                //CE.DatoIDE.Text = SGlblIDE.Text.ToString();
                //CE.lblNombreCuestionario.Text = SGlblNombre.Text;
                //CE.LblApellido.Text = SGlblApellido.Text;
                //CE.LblNotaPre.Text = SGlblNota.Text;
                //CE.Show();
                //this.Hide();
            }
        }

        private void BtnBoton8P1_Click(object sender, EventArgs e)
        {
            E_Estudiante est = new E_Estudiante();
            E_Parcial nt = new E_Parcial();
            N_Estudiante ES = new N_Estudiante();
            N_Parcial NT = new N_Parcial();
            est.IDE = Int32.Parse(SGlblIDE.Text);

            var validNot = NT.LoginNotasParcial(est, nt);
            if (validNot == true && nt.ExamenFinal != 0)
            {
                MessageBox.Show("YA REALIZO EL EXAMEN Y SU NOTA FUE DE: " + nt.ExamenFinal.ToString());
            }
            else
            {
                int idbusqueda = Convert.ToInt32(SGlblIDE.Text);
                AbrirSegPar(new CuestFinal2P(idbusqueda));
                //CuestElipse CE = new CuestElipse();
                //CE.DatoIDE.Text = SGlblIDE.Text.ToString();
                //CE.lblNombreCuestionario.Text = SGlblNombre.Text;
                //CE.LblApellido.Text = SGlblApellido.Text;
                //CE.LblNotaPre.Text = SGlblNota.Text;
                //CE.Show();
                //this.Hide();
            }

        }

        private void axDaControl1_ActivateInput(object sender, AxDoubleAgentCtl._DaCtlEvents2_ActivateInputEvent e)
        {

        }

        private void BtnBoton7P1_Click(object sender, EventArgs e)
        {
            E_Estudiante est = new E_Estudiante();
            E_Parcial nt = new E_Parcial();
            N_Estudiante ES = new N_Estudiante();
            N_Parcial NT = new N_Parcial();
            est.IDE = Int32.Parse(SGlblIDE.Text);

            var validNot = NT.LoginNotasParcial(est, nt);
            if (validNot == true && nt.Tema7 != 0)
            {
                MessageBox.Show("YA REALIZO EL EXAMEN Y SU NOTA FUE DE: " + nt.Tema7.ToString());
            }
            else
            {
                int idbusqueda = Convert.ToInt32(SGlblIDE.Text);
                AbrirSegPar(new CuestCalculo(idbusqueda));
                //CuestElipse CE = new CuestElipse();
                //CE.DatoIDE.Text = SGlblIDE.Text.ToString();
                //CE.lblNombreCuestionario.Text = SGlblNombre.Text;
                //CE.LblApellido.Text = SGlblApellido.Text;
                //CE.LblNotaPre.Text = SGlblNota.Text;
                //CE.Show();
                //this.Hide();
            }
        }

        private void BtnBoton0P1_Click(object sender, EventArgs e)
        {
            AbrirSegPar(new VideLogicaFormal());
        }

        private void BtnBoton0P2_Click(object sender, EventArgs e)
        {
            AbrirSegPar(new TeoriaLogicaFormal());
        }

        private void BtnBoton0P3_Click(object sender, EventArgs e)
        {
            AbrirSegPar(new EjemLogica1());
        }

        private void BtnBoton0P4_Click(object sender, EventArgs e)
        {
            AbrirSegPar(new EjemLogica2());
        }

       

        private void bunifuGradientPanel2_MouseMove(object sender, MouseEventArgs e)
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
