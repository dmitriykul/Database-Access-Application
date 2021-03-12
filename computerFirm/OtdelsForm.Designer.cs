
namespace computerFirm
{
    partial class OtdelsForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.отделыBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.computerFirmDataSet = new computerFirm.ComputerFirmDataSet();
            this.отделыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.отделыTableAdapter = new computerFirm.ComputerFirmDataSetTableAdapters.ОтделыTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.otdelIdTextbox = new System.Windows.Forms.TextBox();
            this.deleteOtdelBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.otdelNameTextbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.отделыBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerFirmDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.отделыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(274, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Таблица Отделы";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 389);
            this.dataGridView1.TabIndex = 19;
            // 
            // отделыBindingSource1
            // 
            this.отделыBindingSource1.DataMember = "Отделы";
            this.отделыBindingSource1.DataSource = this.computerFirmDataSet;
            // 
            // computerFirmDataSet
            // 
            this.computerFirmDataSet.DataSetName = "ComputerFirmDataSet";
            this.computerFirmDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // отделыBindingSource
            // 
            this.отделыBindingSource.DataMember = "Отделы";
            this.отделыBindingSource.DataSource = this.computerFirmDataSet;
            // 
            // отделыTableAdapter
            // 
            this.отделыTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(615, 453);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 37);
            this.button1.TabIndex = 20;
            this.button1.Text = "Добавить отдел";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 443);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "ID Отдела";
            // 
            // otdelIdTextbox
            // 
            this.otdelIdTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.otdelIdTextbox.Location = new System.Drawing.Point(16, 470);
            this.otdelIdTextbox.Name = "otdelIdTextbox";
            this.otdelIdTextbox.Size = new System.Drawing.Size(100, 20);
            this.otdelIdTextbox.TabIndex = 22;
            // 
            // deleteOtdelBtn
            // 
            this.deleteOtdelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteOtdelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteOtdelBtn.Location = new System.Drawing.Point(143, 453);
            this.deleteOtdelBtn.Name = "deleteOtdelBtn";
            this.deleteOtdelBtn.Size = new System.Drawing.Size(173, 37);
            this.deleteOtdelBtn.TabIndex = 23;
            this.deleteOtdelBtn.Text = "Удалить";
            this.deleteOtdelBtn.UseVisualStyleBackColor = true;
            this.deleteOtdelBtn.Click += new System.EventHandler(this.deleteOtdelBtn_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(408, 441);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Наименование отдела";
            // 
            // otdelNameTextbox
            // 
            this.otdelNameTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.otdelNameTextbox.Location = new System.Drawing.Point(412, 470);
            this.otdelNameTextbox.Name = "otdelNameTextbox";
            this.otdelNameTextbox.Size = new System.Drawing.Size(179, 20);
            this.otdelNameTextbox.TabIndex = 25;
            // 
            // OtdelsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 502);
            this.Controls.Add(this.otdelNameTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.deleteOtdelBtn);
            this.Controls.Add(this.otdelIdTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(816, 506);
            this.Name = "OtdelsForm";
            this.Text = "OtdelsForm";
            this.Activated += new System.EventHandler(this.OtdelsForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OtdelsForm_FormClosing);
            this.Load += new System.EventHandler(this.OtdelsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.отделыBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerFirmDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.отделыBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ComputerFirmDataSet computerFirmDataSet;
        private System.Windows.Forms.BindingSource отделыBindingSource;
        private ComputerFirmDataSetTableAdapters.ОтделыTableAdapter отделыTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox otdelIdTextbox;
        private System.Windows.Forms.Button deleteOtdelBtn;
        private System.Windows.Forms.BindingSource отделыBindingSource1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox otdelNameTextbox;
    }
}