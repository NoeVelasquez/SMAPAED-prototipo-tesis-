namespace Proy_SistemaApoyoMatemetico
{
    partial class EditarPreguntaADM
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarPreguntaADM));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.TablaPreguntasEditar = new System.Windows.Forms.DataGridView();
            this.BtnEliminar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnActualizar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtIDP = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
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
            this.examenesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datosExamenOficial = new Proy_SistemaApoyoMatemetico.DatosExamenOficial();
            this.label8 = new System.Windows.Forms.Label();
            this.LblIDDoc = new System.Windows.Forms.Label();
            this.DatoCombobox = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.examenesTableAdapter = new Proy_SistemaApoyoMatemetico.DatosExamenOficialTableAdapters.ExamenesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TablaPreguntasEditar)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtIDP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examenesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosExamenOficial)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // TablaPreguntasEditar
            // 
            this.TablaPreguntasEditar.AllowUserToAddRows = false;
            this.TablaPreguntasEditar.AllowUserToDeleteRows = false;
            this.TablaPreguntasEditar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TablaPreguntasEditar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.TablaPreguntasEditar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TablaPreguntasEditar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TablaPreguntasEditar.ColumnHeadersHeight = 30;
            this.TablaPreguntasEditar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TablaPreguntasEditar.DefaultCellStyle = dataGridViewCellStyle2;
            this.TablaPreguntasEditar.EnableHeadersVisualStyles = false;
            this.TablaPreguntasEditar.GridColor = System.Drawing.SystemColors.Control;
            this.TablaPreguntasEditar.Location = new System.Drawing.Point(12, 12);
            this.TablaPreguntasEditar.Name = "TablaPreguntasEditar";
            this.TablaPreguntasEditar.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.PaleGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TablaPreguntasEditar.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.TablaPreguntasEditar.RowHeadersVisible = false;
            this.TablaPreguntasEditar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TablaPreguntasEditar.Size = new System.Drawing.Size(497, 365);
            this.TablaPreguntasEditar.TabIndex = 1;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnEliminar.BackColor = System.Drawing.Color.DimGray;
            this.BtnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEliminar.BorderRadius = 0;
            this.BtnEliminar.ButtonText = "ELIMINAR";
            this.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminar.DisabledColor = System.Drawing.Color.Gray;
            this.BtnEliminar.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnEliminar.Iconimage = null;
            this.BtnEliminar.Iconimage_right = null;
            this.BtnEliminar.Iconimage_right_Selected = null;
            this.BtnEliminar.Iconimage_Selected = null;
            this.BtnEliminar.IconMarginLeft = 0;
            this.BtnEliminar.IconMarginRight = 0;
            this.BtnEliminar.IconRightVisible = true;
            this.BtnEliminar.IconRightZoom = 0D;
            this.BtnEliminar.IconVisible = true;
            this.BtnEliminar.IconZoom = 90D;
            this.BtnEliminar.IsTab = false;
            this.BtnEliminar.Location = new System.Drawing.Point(302, 384);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Normalcolor = System.Drawing.Color.DimGray;
            this.BtnEliminar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnEliminar.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnEliminar.selected = false;
            this.BtnEliminar.Size = new System.Drawing.Size(143, 34);
            this.BtnEliminar.TabIndex = 20;
            this.BtnEliminar.Text = "ELIMINAR";
            this.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEliminar.Textcolor = System.Drawing.Color.White;
            this.BtnEliminar.TextFont = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
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
            this.BtnActualizar.Location = new System.Drawing.Point(38, 384);
            this.BtnActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Normalcolor = System.Drawing.Color.DimGray;
            this.BtnActualizar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnActualizar.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnActualizar.selected = false;
            this.BtnActualizar.Size = new System.Drawing.Size(143, 34);
            this.BtnActualizar.TabIndex = 19;
            this.BtnActualizar.Text = "EDITAR";
            this.BtnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnActualizar.Textcolor = System.Drawing.Color.White;
            this.BtnActualizar.TextFont = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.TxtIDP);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.BtnAgregar);
            this.groupBox2.Controls.Add(this.PBFoto);
            this.groupBox2.Controls.Add(this.linkLabel1);
            this.groupBox2.Controls.Add(this.BtAgregarPregunta);
            this.groupBox2.Controls.Add(this.TxtOpCorrecto);
            this.groupBox2.Controls.Add(this.TxtOpD);
            this.groupBox2.Controls.Add(this.TxtOpC);
            this.groupBox2.Controls.Add(this.TxtOpB);
            this.groupBox2.Controls.Add(this.TxtOpA);
            this.groupBox2.Controls.Add(this.TxtPregunta);
            this.groupBox2.Controls.Add(this.CBDatoExamen);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.LblIDDoc);
            this.groupBox2.Controls.Add(this.DatoCombobox);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(515, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(447, 418);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // TxtIDP
            // 
            this.TxtIDP.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.TxtIDP.ForeColor = System.Drawing.Color.Black;
            this.TxtIDP.Location = new System.Drawing.Point(175, 16);
            this.TxtIDP.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.TxtIDP.Name = "TxtIDP";
            this.TxtIDP.ReadOnly = true;
            this.TxtIDP.Size = new System.Drawing.Size(63, 32);
            this.TxtIDP.TabIndex = 30;
            this.TxtIDP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(6, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(163, 21);
            this.label10.TabIndex = 29;
            this.label10.Text = "Numero de Pregunta";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(365, 136);
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
            this.PBFoto.Location = new System.Drawing.Point(256, 160);
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
            this.linkLabel1.Location = new System.Drawing.Point(355, 180);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(58, 19);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Agregar";
            // 
            // BtAgregarPregunta
            // 
            this.BtAgregarPregunta.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(8)))), ((int)(((byte)(38)))));
            this.BtAgregarPregunta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(8)))), ((int)(((byte)(38)))));
            this.BtAgregarPregunta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtAgregarPregunta.BorderRadius = 0;
            this.BtAgregarPregunta.ButtonText = "Editar Pregunta";
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
            this.BtAgregarPregunta.Location = new System.Drawing.Point(127, 361);
            this.BtAgregarPregunta.Name = "BtAgregarPregunta";
            this.BtAgregarPregunta.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(8)))), ((int)(((byte)(38)))));
            this.BtAgregarPregunta.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(8)))), ((int)(((byte)(38)))));
            this.BtAgregarPregunta.OnHoverTextColor = System.Drawing.Color.White;
            this.BtAgregarPregunta.selected = false;
            this.BtAgregarPregunta.Size = new System.Drawing.Size(194, 42);
            this.BtAgregarPregunta.TabIndex = 7;
            this.BtAgregarPregunta.Text = "Editar Pregunta";
            this.BtAgregarPregunta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtAgregarPregunta.Textcolor = System.Drawing.Color.White;
            this.BtAgregarPregunta.TextFont = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtAgregarPregunta.Click += new System.EventHandler(this.BtAgregarPregunta_Click);
            // 
            // TxtOpCorrecto
            // 
            this.TxtOpCorrecto.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.TxtOpCorrecto.Location = new System.Drawing.Point(96, 311);
            this.TxtOpCorrecto.Name = "TxtOpCorrecto";
            this.TxtOpCorrecto.Size = new System.Drawing.Size(142, 26);
            this.TxtOpCorrecto.TabIndex = 6;
            // 
            // TxtOpD
            // 
            this.TxtOpD.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.TxtOpD.Location = new System.Drawing.Point(96, 264);
            this.TxtOpD.Name = "TxtOpD";
            this.TxtOpD.Size = new System.Drawing.Size(142, 26);
            this.TxtOpD.TabIndex = 6;
            // 
            // TxtOpC
            // 
            this.TxtOpC.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.TxtOpC.Location = new System.Drawing.Point(96, 222);
            this.TxtOpC.Name = "TxtOpC";
            this.TxtOpC.Size = new System.Drawing.Size(142, 26);
            this.TxtOpC.TabIndex = 5;
            // 
            // TxtOpB
            // 
            this.TxtOpB.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.TxtOpB.Location = new System.Drawing.Point(96, 178);
            this.TxtOpB.Name = "TxtOpB";
            this.TxtOpB.Size = new System.Drawing.Size(142, 26);
            this.TxtOpB.TabIndex = 4;
            // 
            // TxtOpA
            // 
            this.TxtOpA.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.TxtOpA.Location = new System.Drawing.Point(96, 136);
            this.TxtOpA.Name = "TxtOpA";
            this.TxtOpA.Size = new System.Drawing.Size(142, 26);
            this.TxtOpA.TabIndex = 3;
            // 
            // TxtPregunta
            // 
            this.TxtPregunta.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.TxtPregunta.ForeColor = System.Drawing.Color.Black;
            this.TxtPregunta.Location = new System.Drawing.Point(91, 93);
            this.TxtPregunta.Name = "TxtPregunta";
            this.TxtPregunta.Size = new System.Drawing.Size(350, 26);
            this.TxtPregunta.TabIndex = 2;
            this.TxtPregunta.Text = "0";
            // 
            // CBDatoExamen
            // 
            this.CBDatoExamen.DataSource = this.examenesBindingSource;
            this.CBDatoExamen.DisplayMember = "Nombre";
            this.CBDatoExamen.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.CBDatoExamen.ForeColor = System.Drawing.Color.Black;
            this.CBDatoExamen.FormattingEnabled = true;
            this.CBDatoExamen.Location = new System.Drawing.Point(91, 56);
            this.CBDatoExamen.Name = "CBDatoExamen";
            this.CBDatoExamen.Size = new System.Drawing.Size(350, 27);
            this.CBDatoExamen.TabIndex = 1;
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(6, 311);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 42);
            this.label8.TabIndex = 0;
            this.label8.Text = "Opcion \r\nCorrecto";
            // 
            // LblIDDoc
            // 
            this.LblIDDoc.AutoSize = true;
            this.LblIDDoc.ForeColor = System.Drawing.Color.White;
            this.LblIDDoc.Location = new System.Drawing.Point(244, 25);
            this.LblIDDoc.Name = "LblIDDoc";
            this.LblIDDoc.Size = new System.Drawing.Size(13, 13);
            this.LblIDDoc.TabIndex = 0;
            this.LblIDDoc.Text = "0";
            // 
            // DatoCombobox
            // 
            this.DatoCombobox.AutoSize = true;
            this.DatoCombobox.ForeColor = System.Drawing.Color.White;
            this.DatoCombobox.Location = new System.Drawing.Point(263, 25);
            this.DatoCombobox.Name = "DatoCombobox";
            this.DatoCombobox.Size = new System.Drawing.Size(13, 13);
            this.DatoCombobox.TabIndex = 0;
            this.DatoCombobox.Text = "0";
            this.DatoCombobox.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(253, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "Agregar Imagen";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(6, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "Opcion D";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(6, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Opcion C";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Opcion B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Opcion A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Pregunta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Examen";
            // 
            // examenesTableAdapter
            // 
            this.examenesTableAdapter.ClearBeforeFill = true;
            // 
            // EditarPreguntaADM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(974, 430);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.TablaPreguntasEditar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditarPreguntaADM";
            this.Text = "EditarPreguntaADM";
            this.Load += new System.EventHandler(this.EditarPreguntaADM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TablaPreguntasEditar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtIDP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examenesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosExamenOficial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.DataGridView TablaPreguntasEditar;
        private Bunifu.Framework.UI.BunifuFlatButton BtnEliminar;
        private Bunifu.Framework.UI.BunifuFlatButton BtnActualizar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.PictureBox PBFoto;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private Bunifu.Framework.UI.BunifuFlatButton BtAgregarPregunta;
        private System.Windows.Forms.TextBox TxtOpCorrecto;
        private System.Windows.Forms.TextBox TxtOpD;
        private System.Windows.Forms.TextBox TxtOpC;
        private System.Windows.Forms.TextBox TxtOpB;
        private System.Windows.Forms.TextBox TxtOpA;
        private System.Windows.Forms.TextBox TxtPregunta;
        private System.Windows.Forms.ComboBox CBDatoExamen;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label LblIDDoc;
        private System.Windows.Forms.Label DatoCombobox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.NumericUpDown TxtIDP;
        private System.Windows.Forms.Label label10;
        private DatosExamenOficial datosExamenOficial;
        private System.Windows.Forms.BindingSource examenesBindingSource;
        private DatosExamenOficialTableAdapters.ExamenesTableAdapter examenesTableAdapter;
    }
}