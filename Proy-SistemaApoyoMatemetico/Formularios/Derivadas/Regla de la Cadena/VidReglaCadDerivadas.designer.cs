namespace Proy_SistemaApoyoMatemetico
{
    partial class VidReglaCadDerivadas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VidReglaCadDerivadas));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.ControlAgTED = new AxDoubleAgentCtl.AxDaControl();
            ((System.ComponentModel.ISupportInitialize)(this.ControlAgTED)).BeginInit();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 12);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(915, 552);
            this.webBrowser1.TabIndex = 8;
            // 
            // ControlAgTED
            // 
            this.ControlAgTED.Enabled = true;
            this.ControlAgTED.Location = new System.Drawing.Point(933, 12);
            this.ControlAgTED.Name = "ControlAgTED";
            this.ControlAgTED.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("ControlAgTED.OcxState")));
            this.ControlAgTED.Size = new System.Drawing.Size(32, 32);
            this.ControlAgTED.TabIndex = 7;
            // 
            // VidReglaCadDerivadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(977, 588);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.ControlAgTED);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VidReglaCadDerivadas";
            this.Text = "VidReglaCadDerivadas";
            this.Load += new System.EventHandler(this.VidReglaCadDerivadas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ControlAgTED)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private AxDoubleAgentCtl.AxDaControl ControlAgTED;
    }
}