﻿
namespace computerFirm
{
    partial class DoneServicesForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.выполненныеУслугиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.computerFirmDataSet = new computerFirm.ComputerFirmDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.выполненные_услугиTableAdapter = new computerFirm.ComputerFirmDataSetTableAdapters.Выполненные_услугиTableAdapter();
            this.makeReportServiceBtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.выполненныеУслугиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerFirmDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(229, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Таблица Выполненные услуги";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поискToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.поискToolStripMenuItem.Text = "Поиск";
            this.поискToolStripMenuItem.Click += new System.EventHandler(this.поискToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(760, 313);
            this.dataGridView1.TabIndex = 21;
            // 
            // выполненныеУслугиBindingSource
            // 
            this.выполненныеУслугиBindingSource.DataMember = "Выполненные услуги";
            this.выполненныеУслугиBindingSource.DataSource = this.computerFirmDataSet;
            // 
            // computerFirmDataSet
            // 
            this.computerFirmDataSet.DataSetName = "ComputerFirmDataSet";
            this.computerFirmDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(588, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 33);
            this.button1.TabIndex = 22;
            this.button1.Text = "Добавить услугу";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // выполненные_услугиTableAdapter
            // 
            this.выполненные_услугиTableAdapter.ClearBeforeFill = true;
            // 
            // makeReportServiceBtn
            // 
            this.makeReportServiceBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.makeReportServiceBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.makeReportServiceBtn.Location = new System.Drawing.Point(12, 383);
            this.makeReportServiceBtn.Name = "makeReportServiceBtn";
            this.makeReportServiceBtn.Size = new System.Drawing.Size(184, 33);
            this.makeReportServiceBtn.TabIndex = 23;
            this.makeReportServiceBtn.Text = "Составить отчет";
            this.makeReportServiceBtn.UseVisualStyleBackColor = true;
            this.makeReportServiceBtn.Click += new System.EventHandler(this.makeReportServiceBtn_Click);
            // 
            // DoneServicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 426);
            this.Controls.Add(this.makeReportServiceBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "DoneServicesForm";
            this.Text = "DoneServicesForm";
            this.Activated += new System.EventHandler(this.DoneServicesForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DoneServicesForm_FormClosing);
            this.Load += new System.EventHandler(this.DoneServicesForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.выполненныеУслугиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerFirmDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private ComputerFirmDataSet computerFirmDataSet;
        private System.Windows.Forms.BindingSource выполненныеУслугиBindingSource;
        private ComputerFirmDataSetTableAdapters.Выполненные_услугиTableAdapter выполненные_услугиTableAdapter;
        private System.Windows.Forms.Button makeReportServiceBtn;
    }
}