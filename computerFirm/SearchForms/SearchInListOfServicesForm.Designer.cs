
namespace computerFirm
{
    partial class SearchInListOfServicesForm
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
            this.serviceOtdelTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.serviceNameTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchInDoneServices = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(227, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(329, 25);
            this.label6.TabIndex = 21;
            this.label6.Text = "Поиск по таблице Список услуг";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(173, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(613, 397);
            this.dataGridView1.TabIndex = 22;
            // 
            // searchByWorkerId
            // 
            this.searchByWorkerId.AutoSize = true;
            this.searchByWorkerId.Location = new System.Drawing.Point(128, 141);
            this.searchByWorkerId.Name = "searchByWorkerId";
            this.searchByWorkerId.Size = new System.Drawing.Size(15, 14);
            this.searchByWorkerId.TabIndex = 38;
            this.searchByWorkerId.UseVisualStyleBackColor = true;
            // 
            // searchByClientId
            // 
            this.searchByClientId.AutoSize = true;
            this.searchByClientId.Location = new System.Drawing.Point(128, 74);
            this.searchByClientId.Name = "searchByClientId";
            this.searchByClientId.Size = new System.Drawing.Size(15, 14);
            this.searchByClientId.TabIndex = 37;
            this.searchByClientId.UseVisualStyleBackColor = true;
            // 
            // serviceOtdelTextBox
            // 
            this.serviceOtdelTextBox.Location = new System.Drawing.Point(12, 138);
            this.serviceOtdelTextBox.Name = "serviceOtdelTextBox";
            this.serviceOtdelTextBox.Size = new System.Drawing.Size(100, 20);
            this.serviceOtdelTextBox.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Отдел";
            // 
            // serviceNameTextbox
            // 
            this.serviceNameTextbox.Location = new System.Drawing.Point(12, 71);
            this.serviceNameTextbox.Name = "serviceNameTextbox";
            this.serviceNameTextbox.Size = new System.Drawing.Size(100, 20);
            this.serviceNameTextbox.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Вид услуги";
            // 
            // searchInDoneServices
            // 
            this.searchInDoneServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchInDoneServices.Location = new System.Drawing.Point(12, 393);
            this.searchInDoneServices.Name = "searchInDoneServices";
            this.searchInDoneServices.Size = new System.Drawing.Size(155, 45);
            this.searchInDoneServices.TabIndex = 39;
            this.searchInDoneServices.Text = "Найти";
            this.searchInDoneServices.UseVisualStyleBackColor = true;
            this.searchInDoneServices.Click += new System.EventHandler(this.searchInDoneServices_Click);
            // 
            // SearchInListOfServicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 450);
            this.Controls.Add(this.searchInDoneServices);
            this.Controls.Add(this.searchByWorkerId);
            this.Controls.Add(this.searchByClientId);
            this.Controls.Add(this.serviceOtdelTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.serviceNameTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Name = "SearchInListOfServicesForm";
            this.Text = "Поиск список услуг";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox searchByWorkerId;
        private System.Windows.Forms.CheckBox searchByClientId;
        private System.Windows.Forms.TextBox serviceOtdelTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox serviceNameTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchInDoneServices;
    }
}