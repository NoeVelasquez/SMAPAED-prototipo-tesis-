namespace Proy_SistemaApoyoMatemetico
{
    partial class EjeLogica
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.queEsElLenguajeFormalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negacionDeEnunciadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeProposicionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conjuncionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disyuncionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.condicionalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bicondicionalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dobleNegacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.queEsElLenguajeFormalToolStripMenuItem,
            this.negacionDeEnunciadosToolStripMenuItem,
            this.tipoDeProposicionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1075, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // queEsElLenguajeFormalToolStripMenuItem
            // 
            this.queEsElLenguajeFormalToolStripMenuItem.Name = "queEsElLenguajeFormalToolStripMenuItem";
            this.queEsElLenguajeFormalToolStripMenuItem.Size = new System.Drawing.Size(155, 20);
            this.queEsElLenguajeFormalToolStripMenuItem.Text = "Que es el lenguaje Formal";
            this.queEsElLenguajeFormalToolStripMenuItem.Click += new System.EventHandler(this.queEsElLenguajeFormalToolStripMenuItem_Click);
            // 
            // negacionDeEnunciadosToolStripMenuItem
            // 
            this.negacionDeEnunciadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dobleNegacionToolStripMenuItem});
            this.negacionDeEnunciadosToolStripMenuItem.Name = "negacionDeEnunciadosToolStripMenuItem";
            this.negacionDeEnunciadosToolStripMenuItem.Size = new System.Drawing.Size(150, 20);
            this.negacionDeEnunciadosToolStripMenuItem.Text = "Negacion de Enunciados";
            this.negacionDeEnunciadosToolStripMenuItem.Click += new System.EventHandler(this.negacionDeEnunciadosToolStripMenuItem_Click);
            // 
            // tipoDeProposicionesToolStripMenuItem
            // 
            this.tipoDeProposicionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conjuncionToolStripMenuItem,
            this.disyuncionToolStripMenuItem,
            this.condicionalToolStripMenuItem,
            this.bicondicionalToolStripMenuItem});
            this.tipoDeProposicionesToolStripMenuItem.Name = "tipoDeProposicionesToolStripMenuItem";
            this.tipoDeProposicionesToolStripMenuItem.Size = new System.Drawing.Size(135, 20);
            this.tipoDeProposicionesToolStripMenuItem.Text = "Tipo de Proposiciones";
            // 
            // conjuncionToolStripMenuItem
            // 
            this.conjuncionToolStripMenuItem.Name = "conjuncionToolStripMenuItem";
            this.conjuncionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.conjuncionToolStripMenuItem.Text = "Conjuncion";
            // 
            // disyuncionToolStripMenuItem
            // 
            this.disyuncionToolStripMenuItem.Name = "disyuncionToolStripMenuItem";
            this.disyuncionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.disyuncionToolStripMenuItem.Text = "Disyuncion";
            // 
            // condicionalToolStripMenuItem
            // 
            this.condicionalToolStripMenuItem.Name = "condicionalToolStripMenuItem";
            this.condicionalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.condicionalToolStripMenuItem.Text = "Condicional";
            // 
            // bicondicionalToolStripMenuItem
            // 
            this.bicondicionalToolStripMenuItem.Name = "bicondicionalToolStripMenuItem";
            this.bicondicionalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bicondicionalToolStripMenuItem.Text = "Bicondicional";
            // 
            // dobleNegacionToolStripMenuItem
            // 
            this.dobleNegacionToolStripMenuItem.Name = "dobleNegacionToolStripMenuItem";
            this.dobleNegacionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dobleNegacionToolStripMenuItem.Text = "Doble Negacion";
            // 
            // Panel1
            // 
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel1.Location = new System.Drawing.Point(0, 24);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1075, 505);
            this.Panel1.TabIndex = 1;
            // 
            // EjeLogica1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 529);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EjeLogica1";
            this.Text = "EjeLogica1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem queEsElLenguajeFormalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negacionDeEnunciadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dobleNegacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDeProposicionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conjuncionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disyuncionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem condicionalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bicondicionalToolStripMenuItem;
        private System.Windows.Forms.Panel Panel1;
    }
}