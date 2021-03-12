
namespace computerFirm
{
    partial class TestReport
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
            this.DataTable2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ComputerFirmDataSet = new computerFirm.ComputerFirmDataSet();
            this.Выполненные_заказыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Выполненные_заказыTableAdapter = new computerFirm.ComputerFirmDataSetTableAdapters.Выполненные_заказыTableAdapter();
            this.РаботникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.РаботникиTableAdapter = new computerFirm.ComputerFirmDataSetTableAdapters.РаботникиTableAdapter();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTable1TableAdapter = new computerFirm.ComputerFirmDataSetTableAdapters.DataTable1TableAdapter();
            this.DataTable2TableAdapter = new computerFirm.ComputerFirmDataSetTableAdapters.DataTable2TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComputerFirmDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Выполненные_заказыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.РаботникиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTable2BindingSource
            // 
            this.DataTable2BindingSource.DataMember = "DataTable2";
            this.DataTable2BindingSource.DataSource = this.ComputerFirmDataSet;
            // 
            // ComputerFirmDataSet
            // 
            this.ComputerFirmDataSet.DataSetName = "ComputerFirmDataSet";
            this.ComputerFirmDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Выполненные_заказыBindingSource
            // 
            this.Выполненные_заказыBindingSource.DataMember = "Выполненные заказы";
            this.Выполненные_заказыBindingSource.DataSource = this.ComputerFirmDataSet;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DataTable2BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "computerFirm.Report5.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // Выполненные_заказыTableAdapter
            // 
            this.Выполненные_заказыTableAdapter.ClearBeforeFill = true;
            // 
            // РаботникиBindingSource
            // 
            this.РаботникиBindingSource.DataMember = "Работники";
            this.РаботникиBindingSource.DataSource = this.ComputerFirmDataSet;
            // 
            // РаботникиTableAdapter
            // 
            this.РаботникиTableAdapter.ClearBeforeFill = true;
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.ComputerFirmDataSet;
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // DataTable2TableAdapter
            // 
            this.DataTable2TableAdapter.ClearBeforeFill = true;
            // 
            // TestReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "TestReport";
            this.Text = "TestReport";
            this.Load += new System.EventHandler(this.TestReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComputerFirmDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Выполненные_заказыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.РаботникиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Выполненные_заказыBindingSource;
        private ComputerFirmDataSet ComputerFirmDataSet;
        private ComputerFirmDataSetTableAdapters.Выполненные_заказыTableAdapter Выполненные_заказыTableAdapter;
        private System.Windows.Forms.BindingSource РаботникиBindingSource;
        private ComputerFirmDataSetTableAdapters.РаботникиTableAdapter РаботникиTableAdapter;
        private System.Windows.Forms.BindingSource DataTable2BindingSource;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private ComputerFirmDataSetTableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
        private ComputerFirmDataSetTableAdapters.DataTable2TableAdapter DataTable2TableAdapter;
    }
}