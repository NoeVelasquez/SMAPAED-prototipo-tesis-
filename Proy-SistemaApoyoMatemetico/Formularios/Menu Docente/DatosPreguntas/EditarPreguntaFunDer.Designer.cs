namespace Proy_SistemaApoyoMatemetico
{
    partial class EditarPreguntaFunDer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarPreguntaFunDer));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label9 = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.TxtIDP = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.LblIDDoc = new System.Windows.Forms.Label();
            this.BtnAgregarPregunta = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PBFoto = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.CBDatoExamen = new System.Windows.Forms.ComboBox();
            this.examenesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datosExamenOficial = new Proy_SistemaApoyoMatemetico.DatosExamenOficial();
            this.label6 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DatoCombobox = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtOpCorrecto = new System.Windows.Forms.TextBox();
            this.TxtOpD = new System.Windows.Forms.TextBox();
            this.TxtOpC = new System.Windows.Forms.TextBox();
            this.TxtOpB = new System.Windows.Forms.TextBox();
            this.TxtOpA = new System.Windows.Forms.TextBox();
            this.TxtPregunta = new System.Windows.Forms.TextBox();
            this.odfFoto = new System.Windows.Forms.OpenFileDialog();
            this.examenesTableAdapter = new Proy_SistemaApoyoMatemetico.DatosExamenOficialTableAdapters.ExamenesTableAdapter();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.BtnActualizar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.TablaPreguntasEditar = new System.Windows.Forms.DataGridView();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtIDP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examenesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosExamenOficial)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.bunifuGradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaPreguntasEditar)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(185, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(442, 22);
            this.label9.TabIndex = 0;
            this.label9.Text = "EDITAR PREGUNTA FUNCIONES Y DERIVADAS";
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.label9);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(8)))), ((int)(((byte)(38)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(974, 39);
            this.bunifuGradientPanel1.TabIndex = 2;
            // 
            // TxtIDP
            // 
            this.TxtIDP.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.TxtIDP.ForeColor = System.Drawing.Color.Black;
            this.TxtIDP.Location = new System.Drawing.Point(179, 9);
            this.TxtIDP.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.TxtIDP.Name = "TxtIDP";
            this.TxtIDP.ReadOnly = true;
            this.TxtIDP.Size = new System.Drawing.Size(63, 32);
            this.TxtIDP.TabIndex = 28;
            this.TxtIDP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(10, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(163, 21);
            this.label10.TabIndex = 27;
            this.label10.Text = "Numero de Pregunta";
            // 
            // LblIDDoc
            // 
            this.LblIDDoc.AutoSize = true;
            this.LblIDDoc.ForeColor = System.Drawing.Color.Cornsilk;
            this.LblIDDoc.Location = new System.Drawing.Point(356, 13);
            this.LblIDDoc.Name = "LblIDDoc";
            this.LblIDDoc.Size = new System.Drawing.Size(13, 13);
            this.LblIDDoc.TabIndex = 7;
            this.LblIDDoc.Text = "0";
            this.LblIDDoc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BtnAgregarPregunta
            // 
            this.BtnAgregarPregunta.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnAgregarPregunta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnAgregarPregunta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAgregarPregunta.BorderRadius = 0;
            this.BtnAgregarPregunta.ButtonText = "Editar Pregunta";
            this.BtnAgregarPregunta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAgregarPregunta.DisabledColor = System.Drawing.Color.Gray;
            this.BtnAgregarPregunta.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnAgregarPregunta.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnAgregarPregunta.Iconimage")));
            this.BtnAgregarPregunta.Iconimage_right = null;
            this.BtnAgregarPregunta.Iconimage_right_Selected = null;
            this.BtnAgregarPregunta.Iconimage_Selected = null;
            this.BtnAgregarPregunta.IconMarginLeft = 0;
            this.BtnAgregarPregunta.IconMarginRight = 0;
            this.BtnAgregarPregunta.IconRightVisible = true;
            this.BtnAgregarPregunta.IconRightZoom = 0D;
            this.BtnAgregarPregunta.IconVisible = true;
            this.BtnAgregarPregunta.IconZoom = 90D;
            this.BtnAgregarPregunta.IsTab = false;
            this.BtnAgregarPregunta.Location = new System.Drawing.Point(98, 331);
            this.BtnAgregarPregunta.Name = "BtnAgregarPregunta";
            this.BtnAgregarPregunta.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnAgregarPregunta.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnAgregarPregunta.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnAgregarPregunta.selected = false;
            this.BtnAgregarPregunta.Size = new System.Drawing.Size(168, 48);
            this.BtnAgregarPregunta.TabIndex = 2;
            this.BtnAgregarPregunta.Text = "Editar Pregunta";
            this.BtnAgregarPregunta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAgregarPregunta.Textcolor = System.Drawing.Color.White;
            this.BtnAgregarPregunta.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarPregunta.Click += new System.EventHandler(this.BtnAgregarPregunta_Click);
            // 
            // PBFoto
            // 
            this.PBFoto.Location = new System.Drawing.Point(296, 154);
            this.PBFoto.Name = "PBFoto";
            this.PBFoto.Size = new System.Drawing.Size(173, 162);
            this.PBFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBFoto.TabIndex = 6;
            this.PBFoto.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.linkLabel1.Location = new System.Drawing.Point(373, 126);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(96, 21);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Seleccionar";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // CBDatoExamen
            // 
            this.CBDatoExamen.DataSource = this.examenesBindingSource;
            this.CBDatoExamen.DisplayMember = "Nombre";
            this.CBDatoExamen.FormattingEnabled = true;
            this.CBDatoExamen.Location = new System.Drawing.Point(88, 50);
            this.CBDatoExamen.Name = "CBDatoExamen";
            this.CBDatoExamen.Size = new System.Drawing.Size(383, 21);
            this.CBDatoExamen.TabIndex = 4;
            this.CBDatoExamen.ValueMember = "IDExa";
            this.CBDatoExamen.SelectedIndexChanged += new System.EventHandler(this.CBDatoExamen_SelectedIndexChanged);
            // 
            // examenesBindingSource
            // 
            this.examenesBindingSource.DataMember = "Examenes";
            this.examenesBindingSource.DataSource = this.datosExamenOficial;
            // 
            // datosExamenOficial
            // 
            this.datosExamenOficial.DataSetName = "DatosExamenOficial";
            this.datosExamenOficial.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(10, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 42);
            this.label6.TabIndex = 2;
            this.label6.Text = "Opcion\r\nCorrecta";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.TxtIDP);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.LblIDDoc);
            this.groupBox1.Controls.Add(this.BtnAgregarPregunta);
            this.groupBox1.Controls.Add(this.PBFoto);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.CBDatoExamen);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.DatoCombobox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtOpCorrecto);
            this.groupBox1.Controls.Add(this.TxtOpD);
            this.groupBox1.Controls.Add(this.TxtOpC);
            this.groupBox1.Controls.Add(this.TxtOpB);
            this.groupBox1.Controls.Add(this.TxtOpA);
            this.groupBox1.Controls.Add(this.TxtPregunta);
            this.groupBox1.Location = new System.Drawing.Point(487, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 385);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(10, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Opcion D";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(10, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Opcion C";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(10, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Opcion B";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(10, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 21);
            this.label7.TabIndex = 2;
            this.label7.Text = "Examen";
            // 
            // DatoCombobox
            // 
            this.DatoCombobox.AutoSize = true;
            this.DatoCombobox.ForeColor = System.Drawing.Color.Cornsilk;
            this.DatoCombobox.Location = new System.Drawing.Point(356, 28);
            this.DatoCombobox.Name = "DatoCombobox";
            this.DatoCombobox.Size = new System.Drawing.Size(13, 13);
            this.DatoCombobox.TabIndex = 2;
            this.DatoCombobox.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Opcion A";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(292, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 21);
            this.label8.TabIndex = 1;
            this.label8.Text = "Imagen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pregunta";
            // 
            // TxtOpCorrecto
            // 
            this.TxtOpCorrecto.Location = new System.Drawing.Point(97, 296);
            this.TxtOpCorrecto.Name = "TxtOpCorrecto";
            this.TxtOpCorrecto.Size = new System.Drawing.Size(169, 20);
            this.TxtOpCorrecto.TabIndex = 0;
            // 
            // TxtOpD
            // 
            this.TxtOpD.Location = new System.Drawing.Point(97, 251);
            this.TxtOpD.Name = "TxtOpD";
            this.TxtOpD.Size = new System.Drawing.Size(169, 20);
            this.TxtOpD.TabIndex = 0;
            // 
            // TxtOpC
            // 
            this.TxtOpC.Location = new System.Drawing.Point(97, 210);
            this.TxtOpC.Multiline = true;
            this.TxtOpC.Name = "TxtOpC";
            this.TxtOpC.Size = new System.Drawing.Size(169, 20);
            this.TxtOpC.TabIndex = 0;
            // 
            // TxtOpB
            // 
            this.TxtOpB.Location = new System.Drawing.Point(97, 170);
            this.TxtOpB.Multiline = true;
            this.TxtOpB.Name = "TxtOpB";
            this.TxtOpB.Size = new System.Drawing.Size(169, 20);
            this.TxtOpB.TabIndex = 0;
            // 
            // TxtOpA
            // 
            this.TxtOpA.Location = new System.Drawing.Point(97, 126);
            this.TxtOpA.Multiline = true;
            this.TxtOpA.Name = "TxtOpA";
            this.TxtOpA.Size = new System.Drawing.Size(169, 20);
            this.TxtOpA.TabIndex = 0;
            // 
            // TxtPregunta
            // 
            this.TxtPregunta.Location = new System.Drawing.Point(88, 86);
            this.TxtPregunta.Multiline = true;
            this.TxtPregunta.Name = "TxtPregunta";
            this.TxtPregunta.Size = new System.Drawing.Size(383, 20);
            this.TxtPregunta.TabIndex = 0;
            // 
            // odfFoto
            // 
            this.odfFoto.FileName = "odfFoto";
            // 
            // examenesTableAdapter
            // 
            this.examenesTableAdapter.ClearBeforeFill = true;
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.Controls.Add(this.BtnActualizar);
            this.bunifuGradientPanel2.Controls.Add(this.TablaPreguntasEditar);
            this.bunifuGradientPanel2.Controls.Add(this.groupBox1);
            this.bunifuGradientPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(8)))), ((int)(((byte)(38)))));
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(8)))), ((int)(((byte)(38)))));
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(8)))), ((int)(((byte)(38)))));
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(8)))), ((int)(((byte)(38)))));
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(0, 39);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(974, 391);
            this.bunifuGradientPanel2.TabIndex = 3;
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnActualizar.BackColor = System.Drawing.Color.DimGray;
            this.BtnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnActualizar.BorderRadius = 0;
            this.BtnActualizar.ButtonText = "EDITAR";
            this.BtnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnActualizar.DisabledColor = System.Drawing.Color.Gray;
            this.BtnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.BtnActualizar.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnActualizar.Iconimage = null;
            this.BtnActualizar.Iconimage_right = null;
            this.BtnActualizar.Iconimage_right_Selected = null;
            this.BtnActualizar.Iconimage_Selected = null;
            this.BtnActualizar.IconMarginLeft = 0;
            this.BtnActualizar.IconMarginRight = 0;
            this.BtnActualizar.IconRightVisible = true;
            this.BtnActualizar.IconRightZoom = 0D;
            this.BtnActualizar.IconVisible = true;
            this.BtnActualizar.IconZoom = 90D;
            this.BtnActualizar.IsTab = false;
            this.BtnActualizar.Location = new System.Drawing.Point(189, 345);
            this.BtnActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Normalcolor = System.Drawing.Color.DimGray;
            this.BtnActualizar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnActualizar.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnActualizar.selected = false;
            this.BtnActualizar.Size = new System.Drawing.Size(143, 34);
            this.BtnActualizar.TabIndex = 20;
            this.BtnActualizar.Text = "EDITAR";
            this.BtnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnActualizar.Textcolor = System.Drawing.Color.White;
            this.BtnActualizar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // TablaPreguntasEditar
            // 
            this.TablaPreguntasEditar.AllowUserToAddRows = false;
            this.TablaPreguntasEditar.AllowUserToDeleteRows = false;
            this.TablaPreguntasEditar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(73)))), ((int)(((byte)(117)))));
            this.TablaPreguntasEditar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TablaPreguntasEditar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.TablaPreguntasEditar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TablaPreguntasEditar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TablaPreguntasEditar.ColumnHeadersHeight = 28;
            this.TablaPreguntasEditar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumOrchid;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TablaPreguntasEditar.DefaultCellStyle = dataGridViewCellStyle2;
            this.TablaPreguntasEditar.EnableHeadersVisualStyles = false;
            this.TablaPreguntasEditar.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.TablaPreguntasEditar.Location = new System.Drawing.Point(12, 7);
            this.TablaPreguntasEditar.Name = "TablaPreguntasEditar";
            this.TablaPreguntasEditar.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(73)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TablaPreguntasEditar.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.TablaPreguntasEditar.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(73)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.TablaPreguntasEditar.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.TablaPreguntasEditar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TablaPreguntasEditar.Size = new System.Drawing.Size(469, 331);
            this.TablaPreguntasEditar.TabIndex = 2;
            // 
            // EditarPreguntaFunDer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 430);
            this.Controls.Add(this.bunifuGradientPanel2);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditarPreguntaFunDer";
            this.Text = "EditarPreguntaFunDer";
            this.Load += new System.EventHandler(this.EditarPreguntaFunDer_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtIDP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examenesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosExamenOficial)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.bunifuGradientPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TablaPreguntasEditar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        public System.Windows.Forms.NumericUpDown TxtIDP;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label LblIDDoc;
        private Bunifu.Framework.UI.BunifuFlatButton BtnAgregarPregunta;
        private System.Windows.Forms.PictureBox PBFoto;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ComboBox CBDatoExamen;
        private System.Windows.Forms.BindingSource examenesBindingSource;
        private DatosExamenOficial datosExamenOficial;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private Bunifu.Framework.UI.BunifuFlatButton BtnActualizar;
        private System.Windows.Forms.DataGridView TablaPreguntasEditar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label DatoCombobox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtOpCorrecto;
        private System.Windows.Forms.TextBox TxtOpD;
        private System.Windows.Forms.TextBox TxtOpC;
        private System.Windows.Forms.TextBox TxtOpB;
        private System.Windows.Forms.TextBox TxtOpA;
        private System.Windows.Forms.TextBox TxtPregunta;
        private System.Windows.Forms.OpenFileDialog odfFoto;
        private DatosExamenOficialTableAdapters.ExamenesTableAdapter examenesTableAdapter;
    }
}