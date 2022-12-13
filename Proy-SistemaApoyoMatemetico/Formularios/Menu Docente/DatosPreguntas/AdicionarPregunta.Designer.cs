namespace Proy_SistemaApoyoMatemetico
{
    partial class AdicionarPregunta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdicionarPregunta));
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.PBFoto = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.BtAgregarPregunta = new Bunifu.Framework.UI.BunifuFlatButton();
            this.TxtOpCorrecto = new System.Windows.Forms.TextBox();
            this.TxtOpD = new System.Windows.Forms.TextBox();
            this.TxtOpC = new System.Windows.Forms.TextBox();
            this.TxtOpB = new System.Windows.Forms.TextBox();
            this.TxtOpA = new System.Windows.Forms.TextBox();
            this.TxtPregunta = new System.Windows.Forms.TextBox();
            this.CBDatoExamen = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.LblIDDoc = new System.Windows.Forms.Label();
            this.TxtDato = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.oFDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.datosExamenOficial = new Proy_SistemaApoyoMatemetico.DatosExamenOficial();
            this.examenesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.examenesTableAdapter = new Proy_SistemaApoyoMatemetico.DatosExamenOficialTableAdapters.ExamenesTableAdapter();
            this.bunifuGradientPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBFoto)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datosExamenOficial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examenesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.Controls.Add(this.groupBox1);
            this.bunifuGradientPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(8)))), ((int)(((byte)(38)))));
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(0, 39);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(599, 364);
            this.bunifuGradientPanel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.BtnAgregar);
            this.groupBox1.Controls.Add(this.PBFoto);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.BtAgregarPregunta);
            this.groupBox1.Controls.Add(this.TxtOpCorrecto);
            this.groupBox1.Controls.Add(this.TxtOpD);
            this.groupBox1.Controls.Add(this.TxtOpC);
            this.groupBox1.Controls.Add(this.TxtOpB);
            this.groupBox1.Controls.Add(this.TxtOpA);
            this.groupBox1.Controls.Add(this.TxtPregunta);
            this.groupBox1.Controls.Add(this.CBDatoExamen);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.LblIDDoc);
            this.groupBox1.Controls.Add(this.TxtDato);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(7, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(580, 352);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(490, 90);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(75, 23);
            this.BtnAgregar.TabIndex = 10;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // PBFoto
            // 
            this.PBFoto.BackColor = System.Drawing.Color.White;
            this.PBFoto.Location = new System.Drawing.Point(381, 114);
            this.PBFoto.Name = "PBFoto";
            this.PBFoto.Size = new System.Drawing.Size(174, 172);
            this.PBFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBFoto.TabIndex = 9;
            this.PBFoto.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(494, 91);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(58, 19);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Agregar";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // BtAgregarPregunta
            // 
            this.BtAgregarPregunta.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(8)))), ((int)(((byte)(38)))));
            this.BtAgregarPregunta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(8)))), ((int)(((byte)(38)))));
            this.BtAgregarPregunta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtAgregarPregunta.BorderRadius = 0;
            this.BtAgregarPregunta.ButtonText = "Agregar Pregunta";
            this.BtAgregarPregunta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtAgregarPregunta.DisabledColor = System.Drawing.Color.Gray;
            this.BtAgregarPregunta.Iconcolor = System.Drawing.Color.Transparent;
            this.BtAgregarPregunta.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtAgregarPregunta.Iconimage")));
            this.BtAgregarPregunta.Iconimage_right = null;
            this.BtAgregarPregunta.Iconimage_right_Selected = null;
            this.BtAgregarPregunta.Iconimage_Selected = null;
            this.BtAgregarPregunta.IconMarginLeft = 0;
            this.BtAgregarPregunta.IconMarginRight = 0;
            this.BtAgregarPregunta.IconRightVisible = true;
            this.BtAgregarPregunta.IconRightZoom = 0D;
            this.BtAgregarPregunta.IconVisible = true;
            this.BtAgregarPregunta.IconZoom = 90D;
            this.BtAgregarPregunta.IsTab = false;
            this.BtAgregarPregunta.Location = new System.Drawing.Point(212, 305);
            this.BtAgregarPregunta.Name = "BtAgregarPregunta";
            this.BtAgregarPregunta.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(8)))), ((int)(((byte)(38)))));
            this.BtAgregarPregunta.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(8)))), ((int)(((byte)(38)))));
            this.BtAgregarPregunta.OnHoverTextColor = System.Drawing.Color.White;
            this.BtAgregarPregunta.selected = false;
            this.BtAgregarPregunta.Size = new System.Drawing.Size(173, 34);
            this.BtAgregarPregunta.TabIndex = 7;
            this.BtAgregarPregunta.Text = "Agregar Pregunta";
            this.BtAgregarPregunta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtAgregarPregunta.Textcolor = System.Drawing.Color.White;
            this.BtAgregarPregunta.TextFont = new System.Drawing.Font("Times New Roman", 12F);
            this.BtAgregarPregunta.Click += new System.EventHandler(this.BtAgregarPregunta_Click);
            // 
            // TxtOpCorrecto
            // 
            this.TxtOpCorrecto.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.TxtOpCorrecto.Location = new System.Drawing.Point(82, 273);
            this.TxtOpCorrecto.Name = "TxtOpCorrecto";
            this.TxtOpCorrecto.Size = new System.Drawing.Size(290, 26);
            this.TxtOpCorrecto.TabIndex = 6;
            // 
            // TxtOpD
            // 
            this.TxtOpD.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.TxtOpD.Location = new System.Drawing.Point(82, 224);
            this.TxtOpD.Name = "TxtOpD";
            this.TxtOpD.Size = new System.Drawing.Size(290, 26);
            this.TxtOpD.TabIndex = 6;
            // 
            // TxtOpC
            // 
            this.TxtOpC.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.TxtOpC.Location = new System.Drawing.Point(82, 185);
            this.TxtOpC.Name = "TxtOpC";
            this.TxtOpC.Size = new System.Drawing.Size(290, 26);
            this.TxtOpC.TabIndex = 5;
            // 
            // TxtOpB
            // 
            this.TxtOpB.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.TxtOpB.Location = new System.Drawing.Point(82, 143);
            this.TxtOpB.Name = "TxtOpB";
            this.TxtOpB.Size = new System.Drawing.Size(290, 26);
            this.TxtOpB.TabIndex = 4;
            this.TxtOpB.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // TxtOpA
            // 
            this.TxtOpA.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.TxtOpA.Location = new System.Drawing.Point(82, 99);
            this.TxtOpA.Name = "TxtOpA";
            this.TxtOpA.Size = new System.Drawing.Size(290, 26);
            this.TxtOpA.TabIndex = 3;
            // 
            // TxtPregunta
            // 
            this.TxtPregunta.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.TxtPregunta.Location = new System.Drawing.Point(82, 58);
            this.TxtPregunta.Name = "TxtPregunta";
            this.TxtPregunta.Size = new System.Drawing.Size(473, 26);
            this.TxtPregunta.TabIndex = 2;
            // 
            // CBDatoExamen
            // 
            this.CBDatoExamen.DataSource = this.examenesBindingSource;
            this.CBDatoExamen.DisplayMember = "Nombre";
            this.CBDatoExamen.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.CBDatoExamen.FormattingEnabled = true;
            this.CBDatoExamen.Location = new System.Drawing.Point(82, 21);
            this.CBDatoExamen.Name = "CBDatoExamen";
            this.CBDatoExamen.Size = new System.Drawing.Size(473, 27);
            this.CBDatoExamen.TabIndex = 1;
            this.CBDatoExamen.ValueMember = "IDExa";
            this.CBDatoExamen.SelectedIndexChanged += new System.EventHandler(this.CBDatoExamen_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 38);
            this.label8.TabIndex = 0;
            this.label8.Text = "Opcion \r\nCorrecto";
            // 
            // LblIDDoc
            // 
            this.LblIDDoc.AutoSize = true;
            this.LblIDDoc.Location = new System.Drawing.Point(561, 16);
            this.LblIDDoc.Name = "LblIDDoc";
            this.LblIDDoc.Size = new System.Drawing.Size(13, 13);
            this.LblIDDoc.TabIndex = 0;
            this.LblIDDoc.Text = "0";
            // 
            // TxtDato
            // 
            this.TxtDato.AutoSize = true;
            this.TxtDato.Location = new System.Drawing.Point(561, 29);
            this.TxtDato.Name = "TxtDato";
            this.TxtDato.Size = new System.Drawing.Size(13, 13);
            this.TxtDato.TabIndex = 0;
            this.TxtDato.Text = "0";
            this.TxtDato.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(378, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "Agregar Imagen";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Opcion D";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Opcion C";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Opcion B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Opcion A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Pregunta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Examen";
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(8)))), ((int)(((byte)(38)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(599, 39);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar Pregunta";
            // 
            // oFDialog1
            // 
            this.oFDialog1.FileName = "openFileDialog1";
            // 
            // datosExamenOficial
            // 
            this.datosExamenOficial.DataSetName = "DatosExamenOficial";
            this.datosExamenOficial.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // examenesBindingSource
            // 
            this.examenesBindingSource.DataMember = "Examenes";
            this.examenesBindingSource.DataSource = this.datosExamenOficial;
            // 
            // examenesTableAdapter
            // 
            this.examenesTableAdapter.ClearBeforeFill = true;
            // 
            // AdicionarPregunta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 403);
            this.Controls.Add(this.bunifuGradientPanel2);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Name = "AdicionarPregunta";
            this.Text = "AdicionarPregunta";
            this.Load += new System.EventHandler(this.AdicionarPregunta_Load);
            this.bunifuGradientPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBFoto)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datosExamenOficial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examenesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtOpD;
        private System.Windows.Forms.TextBox TxtOpC;
        private System.Windows.Forms.TextBox TxtOpB;
        private System.Windows.Forms.TextBox TxtOpA;
        private System.Windows.Forms.TextBox TxtPregunta;
        private System.Windows.Forms.ComboBox CBDatoExamen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuFlatButton BtAgregarPregunta;
        private System.Windows.Forms.PictureBox PBFoto;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox TxtOpCorrecto;
        private System.Windows.Forms.Label TxtDato;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.OpenFileDialog oFDialog1;
        public System.Windows.Forms.Label LblIDDoc;
        private System.Windows.Forms.Button BtnAgregar;
        private DatosExamenOficial datosExamenOficial;
        private System.Windows.Forms.BindingSource examenesBindingSource;
        private DatosExamenOficialTableAdapters.ExamenesTableAdapter examenesTableAdapter;
    }
}