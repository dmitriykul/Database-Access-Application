
namespace computerFirm
{
    partial class SearchInDoneServicesForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.searchByWorkerId = new System.Windows.Forms.CheckBox();
            this.searchByClientId = new System.Windows.Forms.CheckBox();
            this.workerIdForSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.clientIdForSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.serviceNameIdSearch = new System.Windows.Forms.TextBox();
            this.searchByNameServiceId = new System.Windows.Forms.CheckBox();
            this.searchInDoneServices = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(230, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(408, 25);
            this.label6.TabIndex = 20;
            this.label6.Text = "Поиск по таблице Выполненные услуги";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(274, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(613, 397);
            this.dataGridView1.TabIndex = 21;
            // 
            // searchByWorkerId
            // 
            this.searchByWorkerId.AutoSize = true;
            this.searchByWorkerId.Location = new System.Drawing.Point(128, 145);
            this.searchByWorkerId.Name = "searchByWorkerId";
            this.searchByWorkerId.Size = new System.Drawing.Size(15, 14);
            this.searchByWorkerId.TabIndex = 32;
            this.searchByWorkerId.UseVisualStyleBackColor = true;
            // 
            // searchByClientId
            // 
            this.searchByClientId.AutoSize = true;
            this.searchByClientId.Location = new System.Drawing.Point(128, 78);
            this.searchByClientId.Name = "searchByClientId";
            this.searchByClientId.Size = new System.Drawing.Size(15, 14);
            this.searchByClientId.TabIndex = 31;
            this.searchByClientId.UseVisualStyleBackColor = true;
            // 
            // workerIdForSearch
            // 
            this.workerIdForSearch.Location = new System.Drawing.Point(12, 142);
            this.workerIdForSearch.Name = "workerIdForSearch";
            this.workerIdForSearch.Size = new System.Drawing.Size(100, 20);
            this.workerIdForSearch.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Работник Фамилия";
            // 
            // clientIdForSearch
            // 
            this.clientIdForSearch.Location = new System.Drawing.Point(12, 75);
            this.clientIdForSearch.Name = "clientIdForSearch";
            this.clientIdForSearch.Size = new System.Drawing.Size(100, 20);
            this.clientIdForSearch.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Клиент (Фамилия)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "Вид услуги";
            // 
            // serviceNameIdSearch
            // 
            this.serviceNameIdSearch.Location = new System.Drawing.Point(12, 215);
            this.serviceNameIdSearch.Name = "serviceNameIdSearch";
            this.serviceNameIdSearch.Size = new System.Drawing.Size(100, 20);
            this.serviceNameIdSearch.TabIndex = 34;
            // 
            // searchByNameServiceId
            // 
            this.searchByNameServiceId.AutoSize = true;
            this.searchByNameServiceId.Location = new System.Drawing.Point(128, 218);
            this.searchByNameServiceId.Name = "searchByNameServiceId";
            this.searchByNameServiceId.Size = new System.Drawing.Size(15, 14);
            this.searchByNameServiceId.TabIndex = 35;
            this.searchByNameServiceId.UseVisualStyleBackColor = true;
            // 
            // searchInDoneServices
            // 
            this.searchInDoneServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchInDoneServices.Location = new System.Drawing.Point(16, 393);
            this.searchInDoneServices.Name = "searchInDoneServices";
            this.searchInDoneServices.Size = new System.Drawing.Size(252, 45);
            this.searchInDoneServices.TabIndex = 36;
            this.searchInDoneServices.Text = "Найти";
            this.searchInDoneServices.UseVisualStyleBackColor = true;
            this.searchInDoneServices.Click += new System.EventHandler(this.searchInDoneServices_Click);
            // 
            // SearchInDoneServicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 450);
            this.Controls.Add(this.searchInDoneServices);
            this.Controls.Add(this.searchByNameServiceId);
            this.Controls.Add(this.serviceNameIdSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.searchByWorkerId);
            this.Controls.Add(this.searchByClientId);
            this.Controls.Add(this.workerIdForSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clientIdForSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SearchInDoneServicesForm";
            this.Text = "Поиск выполненные услуги";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox searchByWorkerId;
        private System.Windows.Forms.CheckBox searchByClientId;
        private System.Windows.Forms.TextBox workerIdForSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox clientIdForSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox serviceNameIdSearch;
        private System.Windows.Forms.CheckBox searchByNameServiceId;
        private System.Windows.Forms.Button searchInDoneServices;
    }
}