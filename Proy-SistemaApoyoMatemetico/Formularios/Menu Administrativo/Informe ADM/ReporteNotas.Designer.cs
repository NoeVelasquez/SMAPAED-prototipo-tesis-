namespace Proy_SistemaApoyoMatemetico
{
    partial class ReporteNotas
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mostrardatosnotasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mostrardatosnotas = new Proy_SistemaApoyoMatemetico.Formularios.Menu_Administrativo.Informe_ADM.mostrardatosnotas();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.listar_NotasTableAdapter = new Proy_SistemaApoyoMatemetico.Formularios.Menu_Administrativo.Informe_ADM.mostrardatosnotasTableAdapters.Listar_NotasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrardatosnotasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrardatosnotas)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Listar_Notas";
            this.bindingSource1.DataSource = this.mostrardatosnotasBindingSource;
            // 
            // mostrardatosnotasBindingSource
            // 
            this.mostrardatosnotasBindingSource.DataSource = this.mostrardatosnotas;
            this.mostrardatosnotasBindingSource.Position = 0;
            // 
            // mostrardatosnotas
            // 
            this.mostrardatosnotas.DataSetName = "mostrardatosnotas";
            this.mostrardatosnotas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DatosNotas";
            reportDataSource1.Value = this.bindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Proy_SistemaApoyoMatemetico.ListaNotas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(967, 450);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load_1);
            // 
            // listar_NotasTableAdapter
            // 
            this.listar_NotasTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteNotas";
            this.Text = "ReporteNotas";
            this.Load += new System.EventHandler(this.ReporteNotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrardatosnotasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrardatosnotas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
       // private mostrardatosnotas mostrardatosnotas;
        private System.Windows.Forms.BindingSource listarNotasBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource mostrardatosnotasBindingSource;
        private Formularios.Menu_Administrativo.Informe_ADM.mostrardatosnotas mostrardatosnotas;
        private Formularios.Menu_Administrativo.Informe_ADM.mostrardatosnotasTableAdapters.Listar_NotasTableAdapter listar_NotasTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource1;
        //private mostrardatosnotasTableAdapters.Listar_NotasTableAdapter listar_NotasTableAdapter;
    }
}