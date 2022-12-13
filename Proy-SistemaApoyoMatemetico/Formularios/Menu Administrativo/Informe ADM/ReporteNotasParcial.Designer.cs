namespace Proy_SistemaApoyoMatemetico
{
    partial class ReporteNotasParcial
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
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this._DataSet_ListaNotaParcial_ = new Proy_SistemaApoyoMatemetico.Formularios.Menu_Administrativo.Informe_ADM._DataSet_ListaNotaParcial_();
            this.dataSetListaNotaParcialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.listar_Notas_ParcialTableAdapter = new Proy_SistemaApoyoMatemetico.Formularios.Menu_Administrativo.Informe_ADM._DataSet_ListaNotaParcial_TableAdapters.Listar_Notas_ParcialTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this._DataSet_ListaNotaParcial_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetListaNotaParcialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.bindingSource1;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Proy_SistemaApoyoMatemetico.ListaNotasParcial.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(954, 461);
            this.reportViewer2.TabIndex = 0;
            // 
            // _DataSet_ListaNotaParcial_
            // 
            this._DataSet_ListaNotaParcial_.DataSetName = "DataSet(ListaNotaParcial)";
            this._DataSet_ListaNotaParcial_.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetListaNotaParcialBindingSource
            // 
            this.dataSetListaNotaParcialBindingSource.DataSource = this._DataSet_ListaNotaParcial_;
            this.dataSetListaNotaParcialBindingSource.Position = 0;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Listar_Notas_Parcial";
            this.bindingSource1.DataSource = this.dataSetListaNotaParcialBindingSource;
            // 
            // listar_Notas_ParcialTableAdapter
            // 
            this.listar_Notas_ParcialTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteNotasParcial
            // 
            this.ClientSize = new System.Drawing.Size(954, 461);
            this.Controls.Add(this.reportViewer2);
            this.Name = "ReporteNotasParcial";
            this.Load += new System.EventHandler(this.ReporteNotasParcial_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this._DataSet_ListaNotaParcial_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetListaNotaParcialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        //private mostrarNotaParcial mostrarNotaParcial;
        private System.Windows.Forms.BindingSource listarNotasParcialBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private Formularios.Menu_Administrativo.Informe_ADM._DataSet_ListaNotaParcial_ _DataSet_ListaNotaParcial_;
        private System.Windows.Forms.BindingSource dataSetListaNotaParcialBindingSource;
        private System.Windows.Forms.BindingSource bindingSource1;
        private Formularios.Menu_Administrativo.Informe_ADM._DataSet_ListaNotaParcial_TableAdapters.Listar_Notas_ParcialTableAdapter listar_Notas_ParcialTableAdapter;
        //private mostrarNotaParcialTableAdapters.Listar_Notas_ParcialTableAdapter listar_Notas_ParcialTableAdapter;
    }
}