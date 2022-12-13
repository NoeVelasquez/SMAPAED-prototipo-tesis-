namespace Proy_SistemaApoyoMatemetico
{
    partial class DominioVideo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DominioVideo));
            this.ControlAgTED = new AxDoubleAgentCtl.AxDaControl();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.ControlAgTED)).BeginInit();
            this.SuspendLayout();
            // 
            // ControlAgTED
            // 
            this.ControlAgTED.Enabled = true;
            this.ControlAgTED.Location = new System.Drawing.Point(1055, -1);
            this.ControlAgTED.Name = "ControlAgTED";
            this.ControlAgTED.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("ControlAgTED.OcxState")));
            this.ControlAgTED.Size = new System.Drawing.Size(32, 32);
            this.ControlAgTED.TabIndex = 1;
            this.ControlAgTED.ActivateInput += new AxDoubleAgentCtl._DaCtlEvents2_ActivateInputEventHandler(this.ControlAgTED_ActivateInput);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 12);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1037, 574);
            this.webBrowser1.TabIndex = 2;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // DominioVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1089, 598);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.ControlAgTED);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DominioVideo";
            this.Text = "IntroFunTeo";
            this.Load += new System.EventHandler(this.IntroFunTeo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ControlAgTED)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private AxDoubleAgentCtl.AxDaControl ControlAgTED;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}