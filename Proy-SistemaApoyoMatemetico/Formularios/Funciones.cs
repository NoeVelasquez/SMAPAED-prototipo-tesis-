using CapaEntidad;
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
        public int xClic, yClic;
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
            timer1.Enabled = true;
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

            Decimal nota ;
            nota=Decimal.Parse(FLblNotaTipFun.Text) ;
            
            //MessageBox.Show(nota.ToString());//hay que validar las notas de los examenes en este caso se debe jalar de la base de dato mejor llevarlo a un label y convertirlo a otro dato para generarlo
            if (nota > 51)
            {                
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
            }
            else
            {
                MessageBox.Show("No puedes acceder por que tu nota en el examen anterior es:"+nota+" /100","NO PUEDES ACCEDER AÚN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnBoton3_Click(object sender, EventArgs e)
        {
            Decimal nota,nota0;
            nota0 = Decimal.Parse(FLblNotaTipFun.Text);
            nota = Decimal.Parse(FLblNDom.Text);

            //MessageBox.Show(nota.ToString());//hay que validar las notas de los examenes en este caso se debe jalar de la base de dato mejor llevarlo a un label y convertirlo a otro dato para generarlo
            if (nota0 > 60 || nota > 51 )
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
            else
            {
              MessageBox.Show("No puedes acceder por que tu nota en Tipo de Funcion es:" + nota0 + " /100 Y tu nota en el examen Dominios es:" + nota + " /100", "NO PUEDES ACCEDER AÚN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnBoton4_Click(object sender, EventArgs e)
        {
            Decimal nota,nota0;
            nota0 = Decimal.Parse(FLblNotaTipFun.Text);
            nota = Decimal.Parse(FLblNExp.Text);
            //MessageBox.Show(nota.ToString());//hay que validar las notas de los examenes en este caso se debe jalar de la base de dato mejor llevarlo a un label y convertirlo a otro dato para generarlo
            if (nota0 > 60 || nota > 51 )
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
            else
            {
                MessageBox.Show("No puedes acceder por que tu nota en Tipo de Funcion es:" + nota0 + " /100 Y tu nota en el examen exponencial es:" + nota + " /100", "NO PUEDES ACCEDER AÚN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnBoton5_Click(object sender, EventArgs e)
        {
            Decimal nota,nota0,NotaDom;
            NotaDom = Decimal.Parse(FLblNDom.Text);
            nota0 = Decimal.Parse(FLblNotaTipFun.Text);
            nota = Decimal.Parse(FLblNTrig.Text);
            //MessageBox.Show(nota.ToString());//hay que validar las notas de los examenes en este caso se debe jalar de la base de dato mejor llevarlo a un label y convertirlo a otro dato para generarlo
            if (nota > 51 || nota0 > 70 ||NotaDom >70 )
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
            else
            {
                MessageBox.Show("No puedes acceder por que tu nota en Tipo de Funcion es:" + nota0 + " /100 \n y tu nota en Dominio es:" + NotaDom + " /100 \n y tu nota en trigonometrico es:" + nota + " /100 \n Debes de terminar las anteriores lecciones ", "NO PUEDES ACCEDER AÚN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnBoton6_Click(object sender, EventArgs e)
        {
            Decimal nota = 0;
            nota = Decimal.Parse(FLblNLog.Text);
            //MessageBox.Show(nota.ToString());//hay que validar las notas de los examenes en este caso se debe jalar de la base de dato mejor llevarlo a un label y convertirlo a otro dato para generarlo
            if (nota > 51)
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
            else
            {
                MessageBox.Show("No puedes acceder por que tu nota en el examen LOGARITMOS es:" + nota + " /100", "NO PUEDES ACCEDER AÚN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BotonMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuAdministrador IrMenGe = new MenuAdministrador();
            IrMenGe.lblNombre.Text=FlblNombre.Text;
            IrMenGe.LblApellido.Text=FlblApellido.Text ;
            IrMenGe.lblNota.Text=FlblNota.Text ;
            IrMenGe.LblIDE.Text=FlblIDE.Text;
            IrMenGe.TxtNota.Value= FTxtNota.Value;
            IrMenGe.LblNotaFinalFun.Text = FLblNFinal.Text;
            IrMenGe.LblNotaTF.Text = FLblNotaTipFun.Text;
            IrMenGe.LblNotaDom.Text = FLblNDom.Text;
            IrMenGe.LblNotaExpo.Text = FLblNExp.Text;
            IrMenGe.LblNotaTrig.Text = FLblNTrig.Text;
            IrMenGe.LblNotaLog.Text = FLblNLog.Text;

            decimal dato = Convert.ToDecimal(FLblNFinal.Text);
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

        private void BtnMaxim_Click(object sender, EventArgs e)
        {
            Application.Exit();
            /*this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;*/
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
            E_Estudiante est = new E_Estudiante();
            E_Notas nt = new E_Notas();
            N_Estudiante ES = new N_Estudiante();
            N_Notas NT = new N_Notas();
            est.IDE = Int32.Parse(FlblIDE.Text);

            var validNot = NT.LoginNotaTF(est, nt);
            if (validNot == true && nt.ExamenFinal != 0)
            {
                MessageBox.Show("YA REALIZO EL EXAMEN Y SU NOTA FUE DE: " + nt.ExamenFinal.ToString());
            }
            else
            {
                int idbusqueda = Convert.ToInt32(FlblIDE.Text);
                AbrirArea(new ExamFinalFunciones(idbusqueda));
                //ExamFinalFunciones ELO = new ExamFinalFunciones();
                //ELO.LblIDE.Text = FlblIDE.Text.ToString();
                //ELO.lblNombre.Text = FlblNombre.Text;
                //ELO.LblApellido.Text = FlblApellido.Text;
                //ELO.LblNotaPre.Text = FlblNota.Text;
                //ELO.LblNotaTF.Text = FLblNotaTipFun.Text;
                //ELO.LblNotaDom.Text = FLblNDom.Text;
                //ELO.LblNotaExpo.Text = FLblNExp.Text;
                //ELO.LblNotaTrig.Text = FLblNTrig.Text;
                //ELO.LblNotaLog.Text = FLblNLog.Text;
                //ELO.Show();
                //this.Hide();
            }
        }
        
        private void BtnBoton1P3_Click(object sender, EventArgs e)
        {
            E_Estudiante est = new E_Estudiante();
            E_Notas nt = new E_Notas();
            N_Estudiante ES = new N_Estudiante();
            N_Notas NT = new N_Notas();
            est.IDE = Int32.Parse(FlblIDE.Text);

            var validNot = NT.LoginNotaTF(est, nt);
            if (validNot == true && nt.ExamenTipFun !=0)
            {
                MessageBox.Show("YA REALIZO EL EXAMEN Y SU NOTA FUE DE: "+ nt.ExamenTipFun.ToString());
            }
            else
            {
                int idbusqueda = Convert.ToInt32(FlblIDE.Text);
                AbrirArea(new CuestTipFun(idbusqueda));
                //CuestTipFun tipFun = new CuestTipFun();
                //tipFun.CLblIDE.Text = FlblIDE.Text.ToString();
                //tipFun.lblNombreCuestionario.Text = FlblNombre.Text;
                //tipFun.LblApellido.Text = FlblApellido.Text;
                //tipFun.LblNotaPre.Text = FlblNota.Text;
                //tipFun.Show();
                //this.Hide();
            }  

        }

        private void BtnBoton2P4_Click(object sender, EventArgs e)
        {
            E_Estudiante est = new E_Estudiante();
            E_Notas nt = new E_Notas();
            N_Estudiante ES = new N_Estudiante();
            N_Notas NT = new N_Notas();
            est.IDE = Int32.Parse(FlblIDE.Text);

            var validNot = NT.LoginNotaTF(est, nt);
            if (validNot == true && nt.ExamenDominio != 0)
            {
                MessageBox.Show("YA REALIZO EL EXAMEN Y SU NOTA FUE DE: " + nt.ExamenDominio.ToString());
            }
            else
            {
                int idbusqueda = Convert.ToInt32(FlblIDE.Text);
                AbrirArea(new CuestDom(idbusqueda));
                //CuestDom EDom = new CuestDom();
                //EDom.CLblIDE.Text = FlblIDE.Text.ToString();
                //EDom.lblNombreCuestionario.Text = FlblNombre.Text;
                //EDom.LblApellido.Text = FlblApellido.Text;
                //EDom.LblNotaPre.Text = FlblNota.Text;
                //EDom.LblNotaTF.Text = FLblNotaTipFun.Text;
                //EDom.Show();
                //this.Hide();
            }
        }

        private void BtnBoton3P4_Click(object sender, EventArgs e)
        {
            E_Estudiante est = new E_Estudiante();
            E_Notas nt = new E_Notas();
            N_Estudiante ES = new N_Estudiante();
            N_Notas NT = new N_Notas();
            est.IDE = Int32.Parse(FlblIDE.Text);

            var validNot = NT.LoginNotaTF(est, nt);
            if (validNot == true && nt.ExamenExpo != 0)
            {
                MessageBox.Show("YA REALIZO EL EXAMEN Y SU NOTA FUE DE: " + nt.ExamenExpo.ToString());
            }
            else
            {
                int idbusqueda = Convert.ToInt32(FlblIDE.Text);
                AbrirArea(new CuestExpo(idbusqueda));
                //CuestExpo EEX = new CuestExpo();
                //EEX.LblIDE.Text = FlblIDE.Text.ToString();
                //EEX.lblNombre.Text = FlblNombre.Text;
                //EEX.LblApellido.Text = FlblApellido.Text;
                //EEX.LblNotaPre.Text = FlblNota.Text;
                //EEX.LblNotaTF.Text = FLblNotaTipFun.Text;
                //EEX.LblNotaDom.Text = FLblNDom.Text;
                //EEX.Show();
                //this.Hide();
            }
        }

        private void BtnBoton4P4_Click(object sender, EventArgs e)
        {
            E_Estudiante est = new E_Estudiante();
            E_Notas nt = new E_Notas();
            N_Estudiante ES = new N_Estudiante();
            N_Notas NT = new N_Notas();
            est.IDE = Int32.Parse(FlblIDE.Text);

            var validNot = NT.LoginNotaTF(est, nt);
            if (validNot == true && nt.ExamenTrigo != 0)
            {
                MessageBox.Show("YA REALIZO EL EXAMEN Y SU NOTA FUE DE: " + nt.ExamenTrigo.ToString());
            }
            else
            {
                int idbusqueda = Convert.ToInt32(FlblIDE.Text);
                AbrirArea(new CuesTrigo(idbusqueda));
                //CuesTrigo ETRI = new CuesTrigo();
                //ETRI.LblIDE.Text = FlblIDE.Text.ToString();
                //ETRI.lblNombre.Text = FlblNombre.Text;
                //ETRI.LblApellido.Text = FlblApellido.Text;
                //ETRI.LblNotaPre.Text = FlblNota.Text;
                //ETRI.LblNotaTF.Text = FLblNotaTipFun.Text;
                //ETRI.LblNotaDom.Text = FLblNDom.Text;
                //ETRI.LblNotaExpo.Text = FLblNExp.Text;
                //ETRI.Show();
                //this.Hide();
            }
        }

        private void BtnBoton5P4_Click(object sender, EventArgs e)
        {
            E_Estudiante est = new E_Estudiante();
            E_Notas nt = new E_Notas();
            N_Estudiante ES = new N_Estudiante();
            N_Notas NT = new N_Notas();
            est.IDE = Int32.Parse(FlblIDE.Text);

            var validNot = NT.LoginNotaTF(est, nt);
            if (validNot == true && nt.ExamenLogar != 0)
            {
                MessageBox.Show("YA REALIZO EL EXAMEN Y SU NOTA FUE DE: " + nt.ExamenLogar.ToString());
            }
            else
            {
                int idbusqueda = Convert.ToInt32(FlblIDE.Text);
                AbrirArea(new CuesLogar(idbusqueda));
                //CuesLogar ELO = new CuesLogar();
                //ELO.LblIDE.Text = FlblIDE.Text.ToString();
                //ELO.lblNombre.Text = FlblNombre.Text;
                //ELO.LblApellido.Text = FlblApellido.Text;
                //ELO.LblNotaPre.Text = FlblNota.Text;
                //ELO.LblNotaTF.Text = FLblNotaTipFun.Text;
                //ELO.LblNotaDom.Text = FLblNDom.Text;
                //ELO.LblNotaExpo.Text = FLblNExp.Text;
                //ELO.LblNotaTrig.Text = FLblNTrig.Text;
                //ELO.Show();
                //this.Hide();
            }
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TXTNotaTipFun_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void label2_DoubleClick(object sender, EventArgs e)
        {
             
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void FLblNLog_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void FLblNFinal_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void FLblNExp_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FLblNotaTipFun_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void FLblNTrig_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void FLblNDom_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void FlblNota_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void FTxtNota_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FlblIDE_Click(object sender, EventArgs e)
        {

        }

        private void FlblApellido_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FlblNombre_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void PanelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelBoton3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelBoton1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelBoton6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelBoton5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelBoton2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHoraADM.Text = DateTime.Now.ToString("hh:mm:ss");
            lblFechaADM.Text = DateTime.Now.ToLongDateString();
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
