namespace Proy_SistemaApoyoMatemetico
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtDUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtDContraseña = new System.Windows.Forms.TextBox();
            this.BtnIniciarSesion = new Bunifu.Framework.UI.BunifuFlatButton();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.PBOcultar = new System.Windows.Forms.PictureBox();
            this.PBMostrar = new System.Windows.Forms.PictureBox();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.SALIDA = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ControlAgCAP = new AxDoubleAgentCtl.AxDaControl();
            ((System.ComponentModel.ISupportInitialize)(this.PBOcultar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBMostrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SALIDA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ControlAgCAP)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 50;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(67, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(473, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sistema de Apoyo para Matemática";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(232, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "USUARIO";
            // 
            // TxtDUsuario
            // 
            this.TxtDUsuario.BackColor = System.Drawing.Color.MidnightBlue;
            this.TxtDUsuario.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDUsuario.ForeColor = System.Drawing.Color.White;
            this.TxtDUsuario.Location = new System.Drawing.Point(268, 90);
            this.TxtDUsuario.Name = "TxtDUsuario";
            this.TxtDUsuario.Size = new System.Drawing.Size(284, 32);
            this.TxtDUsuario.TabIndex = 5;
            this.TxtDUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtDUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtDUsuario_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(232, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "CONTRASEÑA";
            // 
            // TxtDContraseña
            // 
            this.TxtDContraseña.BackColor = System.Drawing.Color.MidnightBlue;
            this.TxtDContraseña.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDContraseña.ForeColor = System.Drawing.Color.White;
            this.TxtDContraseña.Location = new System.Drawing.Point(269, 194);
            this.TxtDContraseña.Name = "TxtDContraseña";
            this.TxtDContraseña.PasswordChar = '*';
            this.TxtDContraseña.Size = new System.Drawing.Size(284, 32);
            this.TxtDContraseña.TabIndex = 5;
            this.TxtDContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtDContraseña.TextChanged += new System.EventHandler(this.TxtDContraseña_TextChanged);
            this.TxtDContraseña.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtDContraseña_KeyDown);
            // 
            // BtnIniciarSesion
            // 
            this.BtnIniciarSesion.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnIniciarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnIniciarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnIniciarSesion.BorderRadius = 0;
            this.BtnIniciarSesion.ButtonText = "INICIAR SESIÓN";
            this.BtnIniciarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnIniciarSesion.DisabledColor = System.Drawing.Color.Gray;
            this.BtnIniciarSesion.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnIniciarSesion.Iconimage = null;
            this.BtnIniciarSesion.Iconimage_right = null;
            this.BtnIniciarSesion.Iconimage_right_Selected = null;
            this.BtnIniciarSesion.Iconimage_Selected = null;
            this.BtnIniciarSesion.IconMarginLeft = 0;
            this.BtnIniciarSesion.IconMarginRight = 0;
            this.BtnIniciarSesion.IconRightVisible = true;
            this.BtnIniciarSesion.IconRightZoom = 0D;
            this.BtnIniciarSesion.IconVisible = true;
            this.BtnIniciarSesion.IconZoom = 90D;
            this.BtnIniciarSesion.IsTab = false;
            this.BtnIniciarSesion.Location = new System.Drawing.Point(302, 251);
            this.BtnIniciarSesion.Name = "BtnIniciarSesion";
            this.BtnIniciarSesion.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnIniciarSesion.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnIniciarSesion.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnIniciarSesion.selected = false;
            this.BtnIniciarSesion.Size = new System.Drawing.Size(250, 48);
            this.BtnIniciarSesion.TabIndex = 6;
            this.BtnIniciarSesion.Text = "INICIAR SESIÓN";
            this.BtnIniciarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnIniciarSesion.Textcolor = System.Drawing.Color.White;
            this.BtnIniciarSesion.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIniciarSesion.Click += new System.EventHandler(this.BtnIniciarSesion_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.White;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(12, 280);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(183, 19);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "¿Olvidaste tu contraseña?";
            this.linkLabel1.Visible = false;
            // 
            // PBOcultar
            // 
            this.PBOcultar.Image = global::Proy_SistemaApoyoMatemetico.Properties.Resources.esconder;
            this.PBOcultar.Location = new System.Drawing.Point(598, 194);
            this.PBOcultar.Name = "PBOcultar";
            this.PBOcultar.Size = new System.Drawing.Size(46, 30);
            this.PBOcultar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBOcultar.TabIndex = 10;
            this.PBOcultar.TabStop = false;
            this.PBOcultar.Click += new System.EventHandler(this.PBOcultar_Click);
            // 
            // PBMostrar
            // 
            this.PBMostrar.Image = global::Proy_SistemaApoyoMatemetico.Properties.Resources.ojo;
            this.PBMostrar.Location = new System.Drawing.Point(598, 194);
            this.PBMostrar.Name = "PBMostrar";
            this.PBMostrar.Size = new System.Drawing.Size(46, 30);
            this.PBMostrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBMostrar.TabIndex = 9;
            this.PBMostrar.TabStop = false;
            this.PBMostrar.Click += new System.EventHandler(this.PBMostrar_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Registrarse";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 50D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(546, 5);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(148, 47);
            this.bunifuFlatButton1.TabIndex = 8;
            this.bunifuFlatButton1.Text = "Registrarse";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Location = new System.Drawing.Point(256, 185);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(312, 54);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Location = new System.Drawing.Point(256, 81);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(312, 54);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // SALIDA
            // 
            this.SALIDA.BackColor = System.Drawing.Color.Transparent;
            this.SALIDA.Image = ((System.Drawing.Image)(resources.GetObject("SALIDA.Image")));
            this.SALIDA.ImageActive = null;
            this.SALIDA.Location = new System.Drawing.Point(10, 3);
            this.SALIDA.Name = "SALIDA";
            this.SALIDA.Size = new System.Drawing.Size(39, 49);
            this.SALIDA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SALIDA.TabIndex = 1;
            this.SALIDA.TabStop = false;
            this.SALIDA.Zoom = 10;
            this.SALIDA.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 210);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ControlAgCAP
            // 
            this.ControlAgCAP.Enabled = true;
            this.ControlAgCAP.Location = new System.Drawing.Point(612, 101);
            this.ControlAgCAP.Name = "ControlAgCAP";
            this.ControlAgCAP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("ControlAgCAP.OcxState")));
            this.ControlAgCAP.Size = new System.Drawing.Size(32, 32);
            this.ControlAgCAP.TabIndex = 11;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(8)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(688, 311);
            this.Controls.Add(this.ControlAgCAP);
            this.Controls.Add(this.PBMostrar);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.BtnIniciarSesion);
            this.Controls.Add(this.TxtDContraseña);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.TxtDUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SALIDA);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PBOcultar);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBOcultar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBMostrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SALIDA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ControlAgCAP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFlatButton BtnIniciarSesion;
        private System.Windows.Forms.TextBox TxtDContraseña;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox TxtDUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton SALIDA;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.PictureBox PBOcultar;
        private System.Windows.Forms.PictureBox PBMostrar;
        //private AxDoubleAgentCtl.AxDaControl ControlAgCAP;
        private AxDoubleAgentCtl.AxDaControl ControlAgCAP;
    }
}

