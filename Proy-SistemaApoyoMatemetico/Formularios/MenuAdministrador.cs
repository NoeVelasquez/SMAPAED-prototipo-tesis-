using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proy_SistemaApoyoMatemetico;
using CapaDatos;
using CapaEntidad;
using CapaNegocio;

namespace Proy_SistemaApoyoMatemetico
{
    public partial class MenuAdministrador : Form
    {
        public int xClic, yClic;
        private readonly N_Notas nota = new N_Notas();
        E_Estudiante est = new E_Estudiante();
        E_Notas nt = new E_Notas();
        N_Estudiante ES = new N_Estudiante();
        N_Notas NT = new N_Notas();
        N_Parcial NP = new N_Parcial();
        E_Parcial np = new E_Parcial();
        public MenuAdministrador()
        {   
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Btn2Par_Click(object sender, EventArgs e)
        {
            this.Hide();
            est.IDE = Int32.Parse(LblIDE.Text);
            var validNotp = NP.LoginNotasParcial(est, np);
            MenuSegParcial IrSegPar = new MenuSegParcial();
            IrSegPar.SGlblNombre.Text = lblNombre.Text;
            IrSegPar.SGlblApellido.Text = LblApellido.Text;
            IrSegPar.SGlblNota.Text = lblNota.Text;
            IrSegPar.SGlblIDE.Text = LblIDE.Text;
            if(validNotp == true)
            {
                IrSegPar.LblNotaT1.Text = np.Tema1.ToString();
                IrSegPar.LblNotaT2.Text = np.Tema2.ToString();
                IrSegPar.LblNotaT3.Text = np.Tema3.ToString();
                IrSegPar.LblNotaT4.Text = np.Tema4.ToString();
                IrSegPar.LblNotaT5.Text = np.Tema5.ToString();
                IrSegPar.LblNotaT6.Text = np.Tema6.ToString();
                IrSegPar.LblNotaT7.Text = np.Tema7.ToString();
                IrSegPar.LblNotaFinal.Text = np.ExamenFinal.ToString();


            }
            IrSegPar.Show();
        }

        private void BtnFunc_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            est.IDE = Int32.Parse(LblIDE.Text);

            var validNot = NT.LoginNotaTF(est, nt);
            
            Funciones IrFun = new Funciones();
            IrFun.FlblNombre.Text = lblNombre.Text;
            IrFun.FlblApellido.Text = LblApellido.Text;
            IrFun.FlblNota.Text = lblNota.Text;
            IrFun.FlblIDE.Text = LblIDE.Text;
            IrFun.FTxtNota.Value = (int)TxtNota.Value;
            if (validNot == true )
            {
                IrFun.FLblNotaTipFun.Text = nt.ExamenTipFun.ToString();
                IrFun.FLblNDom.Text = nt.ExamenDominio.ToString();
                IrFun.FLblNExp.Text = nt.ExamenExpo.ToString();
                IrFun.FLblNTrig.Text = nt.ExamenTrigo.ToString();
                IrFun.FLblNLog.Text = nt.ExamenLogar.ToString();
                IrFun.FLblNFinal.Text = nt.ExamenFinal.ToString();
                
            }
            IrFun.Show();
            
        }

        private void BtnDeriv_Click(object sender, EventArgs e)
        {
            this.Hide();
            est.IDE = Int32.Parse(LblIDE.Text);

            var validNot = NT.LoginNotaTF(est, nt);

            Derivadas IrDev = new Derivadas();
            IrDev.FlblNombre.Text = lblNombre.Text;
            IrDev.FlblApellido.Text = LblApellido.Text;
            IrDev.FlblNota.Text = lblNota.Text;
            IrDev.FlblIDE.Text = LblIDE.Text;
            IrDev.NotaTipFuncion.Text = LblNotaTF.Text;
            IrDev.NotaDominio.Text = LblNotaDom.Text;
            IrDev.NotaExponencial.Text = LblNotaExpo.Text;
            IrDev.NotaTrigo.Text = LblNotaTrig.Text;
            IrDev.NotaLogar.Text = LblNotaLog.Text;
            IrDev.NotaFinalFunc.Text = LblNotaFinalFun.Text;
            IrDev.FTxtNota.Value = (int)TxtNota.Value;
            if (validNot == true)
            {
                IrDev.NotaTipFuncion.Text = nt.ExamenTipFun.ToString();
                IrDev.NotaDominio.Text = nt.ExamenDominio.ToString();
                IrDev.NotaExponencial.Text = nt.ExamenExpo.ToString();
                IrDev.NotaTrigo.Text = nt.ExamenTrigo.ToString();
                IrDev.NotaLogar.Text = nt.ExamenLogar.ToString();
                IrDev.DlblNotaFinal.Text = nt.ExamenFinal.ToString();
                IrDev.DlblNotaTipDeriv.Text = nt.ExamenTipDeriv.ToString();
                IrDev.DlblNotaRegCadena .Text = nt.ExamenRegDer.ToString();
                IrDev.DlblNotaFinal.Text = nt.ExamenFinalDerivada.ToString();

            }
            IrDev.Show();

        }
        
        private void MenuGeneral_Load(object sender, EventArgs e)
        {
            
           
            
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
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
