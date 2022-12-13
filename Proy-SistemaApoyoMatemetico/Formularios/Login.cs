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
using System.Data.SqlClient;
using CapaDatos;
using CapaEntidad;
using CapaNegocio;
using AgentObjects;
using DoubleAgentCtl;

namespace Proy_SistemaApoyoMatemetico
{
    public partial class Login : Form
    {
        public AgentObjects.IAgentCtlCharacter Avatar;
        public static string fk_ad;
        private readonly D_Estudiante estudiantes = new D_Estudiante();
        N_Estudiante estu = new N_Estudiante();
        public Login()
        {
            InitializeComponent();
            
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrarUs ir = new RegistrarUs();
            ir.Show();
        }

        private void BtnIniciarSesion_Click(object sender, EventArgs e)
        {

            entrar();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void PBMostrar_Click(object sender, EventArgs e)
        {
            PBOcultar.BringToFront();
            //Mostrar la contraseña
            TxtDContraseña.PasswordChar = '\0';
        }

        private void PBOcultar_Click(object sender, EventArgs e)
        {
            PBMostrar.BringToFront();
            //Ocultar la contraseña
            TxtDContraseña.PasswordChar = '*';
        }

        private void TxtDUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxtDContraseña.Focus();
            }
        }

        private void TxtDContraseña_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                entrar();
            }
        }

        private void entrar()
        {
            if (TxtDUsuario.Text != "")
            {
                if (TxtDContraseña.Text != "")
                {
                    E_Estudiante est = new E_Estudiante();
                    E_Notas nt = new E_Notas();
                    est.User = TxtDUsuario.Text;
                    est.Pass = TxtDContraseña.Text;
                    N_Estudiante ES = new N_Estudiante();
                    N_Notas NT = new N_Notas();

                    var validLogin = ES.LoginUser(est);

                    var validNot = NT.LoginNotas(est, nt);
                    if (validLogin == true)
                    {

                        //si usuario es nuevo debe ingresar al examen
                        if (est.IDCargo == 1)
                        {
                            ControlAgCAP.Characters.Load("merlin", "merlin.acs");
                            Avatar = (IAgentCtlCharacter)ControlAgCAP.Characters["merlin"];
                            Avatar.Show(0);
                            Avatar.MoveTo(800, 234, 1);
                            Avatar.Speak("Bienvenido " + est.Nombre + " " + est.Apellido + " Sere tu Compañero de Aprendizaje");
                            Avatar.MoveTo(800, 234, 1);
                            Avatar.Hide();
                            //MessageBox.Show("Bienvenido " + est.Nombre + ", " + est.Apellido);
                            if (validNot == true)
                            {
                                MenuAdministrador irMenu = new MenuAdministrador();
                                irMenu.lblNombre.Text = est.Nombre;
                                irMenu.LblApellido.Text = est.Apellido;
                                irMenu.LblIDE.Text = Convert.ToString(est.IDE);
                                MessageBox.Show("Felicidades su nota del Examen es:  " + nt.PreExamen);
                                irMenu.lblNota.Text = Convert.ToString(nt.PreExamen);
                                irMenu.LblNotaFinalFun.Text = Convert.ToString(nt.ExamenFinal);
                                irMenu.TxtNota.Value = (int)nt.PreExamen;
                                decimal dato = Convert.ToDecimal(nt.PreExamen);
                                //decimal nota = nota = Decimal.Parse(LblNotaFinalFun.Text);
                                if (dato >= 51 && dato < 69 /*|| nota >70*/ )
                                {
                                    irMenu.BtnFunc.Enabled = false;
                                    irMenu.BtnDeriv.Enabled = true;

                                }
                                else if (dato > 69)
                                {
                                    irMenu.BtnFunc.Enabled = false;
                                    irMenu.BtnDeriv.Enabled = false;
                                }

                                else
                                {
                                    irMenu.BtnFunc.Enabled = true;
                                    irMenu.BtnDeriv.Enabled = false;
                                }
                                irMenu.Show();
                                this.Hide();
                            }
                            else
                            {
                                CuesInicial ircues = new CuesInicial();
                                ircues.lblNombre.Text = est.Nombre;
                                ircues.LblApellido.Text = est.Apellido;
                                ircues.LblIDE.Text = Convert.ToString(est.IDE);

                                ircues.Show();
                                this.Hide();
                            }
                        }
                        else if (est.IDCargo == 2)
                        {
                            MessageBox.Show("Bienvenido Docente: " + est.Nombre + ", " + est.Apellido);
                            fk_ad = ("select IDU from Usuario where Nombre ='" + est.Nombre + "'");
                            MenuDocente MD = new MenuDocente();
                            MD.DoclblNombre.Text = est.Nombre;
                            MD.DoclblApellido.Text = est.Apellido;
                            MD.DoclblIDE.Text = Convert.ToString(est.IDE);
                            MD.Show();
                            this.Hide();
                        }
                        else if (est.IDCargo == 3 || est.IDCargo == 4)
                        {
                            MessageBox.Show("Bienvenido" + est.Nombre + ", " + est.Apellido);
                            MenuADM ADM = new MenuADM();
                            ADM.DoclblNombre.Text = est.Nombre;
                            ADM.DoclblApellido.Text = est.Apellido;
                            ADM.DoclblIDE.Text = Convert.ToString(est.IDE);
                            ADM.Show();
                            this.Hide();
                        }

                        // sino debe ingresar al menu directamente
                        //mainMenu.FormClosed += Logout;

                    }
                    else
                    {
                        MessageBox.Show("Nombre de usuario o contraseña ingresados ​​incorrectamente. \n Vuelva a intentarlo.");
                        TxtDContraseña.Text = "";
                        TxtDContraseña.UseSystemPasswordChar = false;
                        TxtDUsuario.Focus();
                    }
                }
                else MessageBox.Show("Por favor, ingrese Contraseña.");
            }
            else MessageBox.Show("Por favor ingrese Nombre de Usuario.");
        }
        private void TxtDContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
