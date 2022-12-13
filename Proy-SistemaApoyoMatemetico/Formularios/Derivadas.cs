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
    public partial class Derivadas : Form
    {
        public int xClic, yClic;
        public Derivadas()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);

        }
        //private const int cGrip = 16;
        //private const int cCaption = 32;
        //protected override void WndProc(ref Message m)
        //{
        //    if (m.Msg == 0x84)
        //    {
        //        Point pos = new Point(m.LParam.ToInt32());
        //        pos = this.PointToClient(pos);
        //        if (pos.Y < cCaption)
        //        {
        //            m.Result = (IntPtr)2;
        //            return;
        //        }
        //        if(pos.Y>=this.ClientSize.Width-cGrip && pos.Y >= this.ClientSize.Height - cGrip)
        //        {
        //            m.Result = (IntPtr)17;
        //            return;
        //        }
        //    }
        //    base.WndProc(ref m);
        //}
        private void BotonesIniciales()
        {
            BtnBoton1Dev.Location = new Point(4, 74);
            BtnBoton2Dev.Location = new Point(4, 109);
            BtnBoton3Dev.Location = new Point(4, 144);
            BtnBoton4.Location = new Point(4, 179);
            BtnBoton5.Location = new Point(4, 214);
            BtnBoton6.Location = new Point(4, 249);
        }
        private void AbrirDerivada(object FormHijo)
        {
            if (this.PanelContenedor.Controls.Count > 0)
            {
                this.PanelContenedor.Controls.RemoveAt(0);

            }

            Form fh = FormHijo as Form;
            fh.TopLevel = false;
            this.PanelContenedor.Controls.Add(fh);
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Tag = fh;
            
            fh.Show();

        }
        private void Derivadas_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            BotonesIniciales();//localizacion inicial
            PanelBoton1.Hide();
            PanelBoton2.Hide();
            PanelBoton3.Hide();
            PanelBoton4.Hide();
            PanelBoton5.Hide();
            PanelBoton6.Hide();
            AbrirDerivada(new DefinicionVide());
        }

        private void BtnBoton1_Click_1(object sender, EventArgs e)
        {
            if (PanelBoton1.Visible == true)
            {
                PanelBoton1.Visible = false;
            }
            else
            {
                PanelBoton1.Visible = true;
            }

            BtnBoton1Dev.Location = new Point(4, 74);
            PanelBoton1.Location = new Point(4, 108);
            BtnBoton2Dev.Location = new Point(4, 259);//localizacion cambia
            BtnBoton3Dev.Location = new Point(4, 294);//localizacion cambia
            BtnBoton4.Location = new Point(4, 329);//localizacion cambia
            BtnBoton5.Location = new Point(4, 364);//localizacion cambia
            BtnBoton6.Location = new Point(4, 399);
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

        private void BtnBoton2_Click_1(object sender, EventArgs e)
        {
            Decimal nota;
            nota = Decimal.Parse(DlblNotaTipDeriv.Text);

            //MessageBox.Show(nota.ToString());//hay que validar las notas de los examenes en este caso se debe jalar de la base de dato mejor llevarlo a un label y convertirlo a otro dato para generarlo
            if (nota > 60)
            {
                if (PanelBoton2.Visible == true)
                {
                    PanelBoton2.Visible = false;
                }
                else
                {
                    PanelBoton2.Visible = true;
                }
                BtnBoton1Dev.Location = new Point(4, 74);
                PanelBoton1.Hide();
                PanelBoton3.Hide();
                PanelBoton4.Hide();
                PanelBoton5.Hide();
                PanelBoton6.Hide();
                BtnBoton2Dev.Location = new Point(4, 109);
                PanelBoton2.Location = new Point(4, 143);
                BtnBoton3Dev.Location = new Point(4, 295);//localizacion cambia
                BtnBoton4.Location = new Point(4, 330);//localizacion cambia
                BtnBoton5.Location = new Point(4, 365);//localizacion cambia
                BtnBoton6.Location = new Point(4, 400);

                if (PanelBoton2.Visible == false)
                {
                    BotonesIniciales();

                }
            }
            else
            {
                MessageBox.Show("No puedes acceder por que tu nota en el examen anterior es:" + nota + " /100", "NO PUEDES ACCEDER AÚN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnBoton3_Click_1(object sender, EventArgs e)
        {
            Decimal nota, nota1;
            nota = Decimal.Parse(DlblNotaRegCadena.Text);
            nota1 = Decimal.Parse(DlblNotaTipDeriv.Text);
            //MessageBox.Show(nota.ToString());//hay que validar las notas de los examenes en este caso se debe jalar de la base de dato mejor llevarlo a un label y convertirlo a otro dato para generarlo
            if (nota1 >65 || nota > 55)
            {
                if (PanelBoton3.Visible == true)
                {
                    PanelBoton3.Visible = false;
                }
                else
                {
                    PanelBoton3.Visible = true;
                }
                BtnBoton1Dev.Location = new Point(4, 74);
                BtnBoton2Dev.Location = new Point(4, 109);
                PanelBoton1.Hide();
                PanelBoton2.Hide();
                PanelBoton4.Hide();
                PanelBoton5.Hide();
                PanelBoton6.Hide();
                BtnBoton3Dev.Location = new Point(4, 144);
                PanelBoton3.Location = new Point(4, 178);
                BtnBoton4.Location = new Point(4, 219);
                BtnBoton5.Location = new Point(4, 254);
                BtnBoton6.Location = new Point(4, 289);

                if (PanelBoton3.Visible == false)
                {
                    BotonesIniciales();
                }
            }
            else
            {
                MessageBox.Show("No puedes acceder por que tu nota en el examen anterior es:" + nota + " /100", "NO PUEDES ACCEDER AÚN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnBoton4_Click_1(object sender, EventArgs e)
        {
            if (PanelBoton4.Visible == true)
            {
                PanelBoton4.Visible = false;
            }
            else
            {
                PanelBoton4.Visible = true;
            }
            BtnBoton1Dev.Location = new Point(4, 74);
            BtnBoton2Dev.Location = new Point(4, 109);
            BtnBoton3Dev.Location = new Point(4, 144);
            PanelBoton1.Hide();
            PanelBoton2.Hide();
            PanelBoton3.Hide();
            PanelBoton5.Hide();
            PanelBoton6.Hide();
            BtnBoton4.Location = new Point(4, 179);
            PanelBoton4.Location = new Point(4, 211);
            BtnBoton5.Location = new Point(4, 334);
            BtnBoton6.Location = new Point(4, 369);

            if (PanelBoton4.Visible == false)
            {
                BotonesIniciales();
            }
        }

        private void BtnBoton5_Click_1(object sender, EventArgs e)
        {
            if (PanelBoton5.Visible == true)
            {
                PanelBoton5.Visible = false;
            }
            else
            {
                PanelBoton5.Visible = true;
            }
            BtnBoton1Dev.Location = new Point(4, 74);
            BtnBoton2Dev.Location = new Point(4, 109);
            BtnBoton3Dev.Location = new Point(4, 144);
            BtnBoton4.Location = new Point(4, 179);
            PanelBoton1.Hide();
            PanelBoton2.Hide();
            PanelBoton3.Hide();
            PanelBoton4.Hide();
            PanelBoton6.Hide();
            BtnBoton5.Location = new Point(4, 214);
            PanelBoton5.Location = new Point(4, 248);
            BtnBoton6.Location = new Point(4, 369);


            if (PanelBoton5.Visible == false)
            {
                BotonesIniciales();
            }
        }

        private void BtnBoton6_Click_1(object sender, EventArgs e)
        {
            if (PanelBoton6.Visible == true)
            {
                PanelBoton6.Visible = false;
            }
            else
            {
                PanelBoton6.Visible = true;
            }
            BtnBoton1Dev.Location = new Point(4, 74);
            BtnBoton2Dev.Location = new Point(4, 109);
            BtnBoton3Dev.Location = new Point(4, 144);
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

        private void BotonMenu_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MenuAdministrador IrMenGe = new MenuAdministrador();
            IrMenGe.lblNombre.Text = FlblNombre.Text;
            IrMenGe.LblApellido.Text = FlblApellido.Text;
            IrMenGe.lblNota.Text = FlblNota.Text;
            IrMenGe.LblIDE.Text = FlblIDE.Text;
            IrMenGe.TxtNota.Value = FTxtNota.Value;
            IrMenGe.LblNotaFinalFun.Text = NotaFinalFunc.Text;
            IrMenGe.LblNotaTF.Text = NotaTipFuncion.Text;
            IrMenGe.LblNotaDom.Text = NotaDominio.Text;
            IrMenGe.LblNotaExpo.Text = NotaExponencial.Text;
            IrMenGe.LblNotaTrig.Text = NotaTrigo.Text;
            IrMenGe.LblNotaLog.Text = NotaLogar.Text;
            IrMenGe.Show();
        }

        private void BtnBoton1P1_Click(object sender, EventArgs e)
        {
            AbrirDerivada(new DefinicionVideoDer());
        }

        private void BtnBoton1P2_Click(object sender, EventArgs e)
        {
            AbrirDerivada(new DefVid2Dervcs());
        }

        private void BtnBoton1P3_Click(object sender, EventArgs e)
        {
            AbrirDerivada(new TeoriaDefDerivadas());
        }

        private void BtnBoton2P1_Click(object sender, EventArgs e)
        {
            AbrirDerivada(new VidReglaCadDerivadas());
        }

        private void BtnBoton2P2_Click(object sender, EventArgs e)
        {
            AbrirDerivada(new EjercicioRegCadDer());
        }

        private void BtnBoton2P3_Click(object sender, EventArgs e)
        {
            AbrirDerivada(new Ejericicio3RegCadDer());
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void BtnBoton1P4_Click(object sender, EventArgs e)
        {
            E_Estudiante est = new E_Estudiante();
            E_Notas nt = new E_Notas();
            N_Estudiante ES = new N_Estudiante();
            N_Notas NT = new N_Notas();
            est.IDE = Int32.Parse(FlblIDE.Text);

            var validNot = NT.LoginNotaTF(est, nt);
            if (validNot == true && nt.ExamenTipDeriv != 0)
            {
                MessageBox.Show("YA REALIZO EL EXAMEN Y SU NOTA FUE DE: " + nt.ExamenTipDeriv.ToString());
            }
            else
            {
                int idbusqueda = Convert.ToInt32(FlblIDE.Text);
                AbrirDerivada(new CuesTipDer(idbusqueda));
                //CuesTipDer tipDer = new CuesTipDer();
                //tipDer.LblIDE.Text = FlblIDE.Text.ToString();
                //tipDer.lblNombre.Text = FlblNombre.Text;
                //tipDer.LblApellido.Text = FlblApellido.Text;
                //tipDer.LblNotaPre.Text = nt.PreExamen.ToString();
                //tipDer.LblNotaTF.Text = nt.ExamenTipFun.ToString();
                //tipDer.LblNotaDom.Text = nt.ExamenDominio.ToString();
                //tipDer.LblNotaExpo.Text = nt.ExamenExpo.ToString();
                //tipDer.LblNotaTrig.Text = nt.ExamenTrigo.ToString();
                //tipDer.LblNotaLog.Text = nt.ExamenLogar.ToString();
                //tipDer.LblNotaFinal.Text = nt.ExamenFinal.ToString();
                //tipDer.Show();
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
            if (validNot == true && nt.ExamenRegDer != 0)
            {
                MessageBox.Show("YA REALIZO EL EXAMEN Y SU NOTA FUE DE: " + nt.ExamenRegDer.ToString());
            }
            else
            {
                int idbusqueda = Convert.ToInt32(FlblIDE.Text);
                AbrirDerivada(new CuesRegCadena(idbusqueda));
                //CuesRegCadena RegCad = new CuesRegCadena();
                //RegCad.LblIDE.Text = FlblIDE.Text.ToString();
                //RegCad.lblNombre.Text = FlblNombre.Text;
                //RegCad.LblApellido.Text = FlblApellido.Text;
                //RegCad.LblNotaPre.Text = nt.PreExamen.ToString();
                //RegCad.LblNotaTF.Text = nt.ExamenTipFun.ToString();
                //RegCad.LblNotaDom.Text = nt.ExamenDominio.ToString();
                //RegCad.LblNotaExpo.Text = nt.ExamenExpo.ToString();
                //RegCad.LblNotaTrig.Text = nt.ExamenTrigo.ToString();
                //RegCad.LblNotaLog.Text = nt.ExamenLogar.ToString();
                //RegCad.LblNotaFinal.Text = nt.ExamenFinal.ToString();
                //RegCad.LblNotaTipDeriv.Text = nt.ExamenTipDeriv.ToString();
                //RegCad.Show();
                //this.Hide();
            }
        }

        private void BtnBoton3P1_Click(object sender, EventArgs e)
        {
            E_Estudiante est = new E_Estudiante();
            E_Notas nt = new E_Notas();
            N_Estudiante ES = new N_Estudiante();
            N_Notas NT = new N_Notas();
            est.IDE = Int32.Parse(FlblIDE.Text);

            var validNot = NT.LoginNotaTF(est, nt);
            if (validNot == true && nt.ExamenFinalDerivada != 0)
            {
                MessageBox.Show("YA REALIZO EL EXAMEN Y SU NOTA FUE DE: " + nt.ExamenFinalDerivada.ToString());
            }
            else
            {
                int idbusqueda = Convert.ToInt32(FlblIDE.Text);
                AbrirDerivada(new ExamenFinalDerivadas(idbusqueda));
                //ExamenFinalDerivadas FinalD = new ExamenFinalDerivadas();
                //FinalD.LblIDE.Text = FlblIDE.Text.ToString();
                //FinalD.lblNombre.Text = FlblNombre.Text;
                //FinalD.LblApellido.Text = FlblApellido.Text;
                //FinalD.LblNotaPre.Text = nt.PreExamen.ToString();
                //FinalD.LblNotaTF.Text = nt.ExamenTipFun.ToString();
                //FinalD.LblNotaDom.Text = nt.ExamenDominio.ToString();
                //FinalD.LblNotaExpo.Text = nt.ExamenExpo.ToString();
                //FinalD.LblNotaTrig.Text = nt.ExamenTrigo.ToString();
                //FinalD.LblNotaLog.Text = nt.ExamenLogar.ToString();
                //FinalD.LblNotaFinal.Text = nt.ExamenFinal.ToString();
                //FinalD.LblNotaTipDeriv.Text = nt.ExamenTipDeriv.ToString();
                //FinalD.LblNotaRegCadena.Text = nt.ExamenRegDer.ToString();
                //FinalD.Show();
                //this.Hide();
            }

        }


        private void PanelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHoraADM.Text = DateTime.Now.ToString("hh:mm:ss");
            lblFechaADM.Text = DateTime.Now.ToLongDateString();
        }

        private void PanelCabeceraMenu_MouseMove(object sender, MouseEventArgs e)
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
