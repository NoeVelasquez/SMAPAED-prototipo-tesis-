namespace Proy_SistemaApoyoMatemetico
{
    partial class TeoriaElipse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeoriaElipse));
            this.bunifuGradientPanel4 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ImagenEjeY = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ImagenEjeX = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuGradientPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenEjeY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenEjeX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel4
            // 
            this.bunifuGradientPanel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel4.BackgroundImage")));
            this.bunifuGradientPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel4.Controls.Add(this.label1);
            this.bunifuGradientPanel4.Controls.Add(this.label2);
            this.bunifuGradientPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel4.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(8)))), ((int)(((byte)(38)))));
            this.bunifuGradientPanel4.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel4.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(8)))), ((int)(((byte)(38)))));
            this.bunifuGradientPanel4.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(8)))), ((int)(((byte)(38)))));
            this.bunifuGradientPanel4.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel4.Name = "bunifuGradientPanel4";
            this.bunifuGradientPanel4.Quality = 10;
            this.bunifuGradientPanel4.Size = new System.Drawing.Size(1075, 46);
            this.bunifuGradientPanel4.TabIndex = 5;
            this.bunifuGradientPanel4.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuGradientPanel4_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "¿QUE ES LA ELIPSE?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(306, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(723, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Una elipse es el lugar geométrico de todos los puntos (ε)que se mueven en un plan" +
    "o de tal manera que \r\nla suma de sus distancias a dos puntos fi jos llamados foc" +
    "os es siempre constante.\r\n";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Cambria", 11F);
            this.label10.Location = new System.Drawing.Point(552, 439);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(314, 51);
            this.label10.TabIndex = 10;
            this.label10.Text = "dist(F_1,P)+dist(F_2,P)=2a\r\n√(x−h)^2+(y−k−c)^2+√(x−h)^2+(y−k+c)^2=2a \r\nObservemos" +
    " la gráfica de la elipse para este caso.";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // ImagenEjeY
            // 
            this.ImagenEjeY.BackColor = System.Drawing.Color.White;
            this.ImagenEjeY.Image = global::Proy_SistemaApoyoMatemetico.Properties.Resources.F2_4;
            this.ImagenEjeY.Location = new System.Drawing.Point(907, 322);
            this.ImagenEjeY.Name = "ImagenEjeY";
            this.ImagenEjeY.Size = new System.Drawing.Size(132, 184);
            this.ImagenEjeY.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImagenEjeY.TabIndex = 9;
            this.ImagenEjeY.TabStop = false;
            this.ImagenEjeY.Click += new System.EventHandler(this.ImagenEjeY_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(539, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(471, 26);
            this.label8.TabIndex = 8;
            this.label8.Text = "Ecuación de la elipse con eje focal en el eje Y";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Cambria", 11F);
            this.label9.Location = new System.Drawing.Point(542, 333);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(351, 85);
            this.label9.TabIndex = 7;
            this.label9.Text = resources.GetString("label9.Text");
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // ImagenEjeX
            // 
            this.ImagenEjeX.BackColor = System.Drawing.Color.White;
            this.ImagenEjeX.Image = global::Proy_SistemaApoyoMatemetico.Properties.Resources.F2_12;
            this.ImagenEjeX.Location = new System.Drawing.Point(707, 162);
            this.ImagenEjeX.Name = "ImagenEjeX";
            this.ImagenEjeX.Size = new System.Drawing.Size(196, 121);
            this.ImagenEjeX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImagenEjeX.TabIndex = 6;
            this.ImagenEjeX.TabStop = false;
            this.ImagenEjeX.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(540, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(460, 24);
            this.label7.TabIndex = 5;
            this.label7.Text = "Ecuación de la elipse con eje focal paralelo al eje X";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Cambria", 11F);
            this.label6.Location = new System.Drawing.Point(556, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(463, 85);
            this.label6.TabIndex = 0;
            this.label6.Text = resources.GetString("label6.Text");
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::Proy_SistemaApoyoMatemetico.Properties.Resources.F11;
            this.pictureBox1.Location = new System.Drawing.Point(121, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(505, 76);
            this.label4.TabIndex = 2;
            this.label4.Text = resources.GetString("label4.Text");
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(514, 38);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sean F_1,F_2 ∈ R^2 donde F_1 y F_2  representan los focos de la elipse y \r\nP  un " +
    "punto de la elipse,luego dist(P,F_1)+dist(P,F_2)=r\r\n";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::Proy_SistemaApoyoMatemetico.Properties.Resources.F21;
            this.pictureBox2.Location = new System.Drawing.Point(156, 366);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(220, 151);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // TeoriaElipse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1075, 529);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ImagenEjeX);
            this.Controls.Add(this.ImagenEjeY);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bunifuGradientPanel4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TeoriaElipse";
            this.Text = "TeoriaElipse";
            this.bunifuGradientPanel4.ResumeLayout(false);
            this.bunifuGradientPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenEjeY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenEjeX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox ImagenEjeX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox ImagenEjeY;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}