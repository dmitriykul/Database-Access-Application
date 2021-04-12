
namespace computerFirm
{
    partial class SearchProvidersForm
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
            this.searchInDoneServices = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.providerNameTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(203, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(320, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = "Поиск по таблице Поставщики";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(197, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(591, 397);
            this.dataGridView1.TabIndex = 23;
            // 
            // searchInDoneServices
            // 
            this.searchInDoneServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchInDoneServices.Location = new System.Drawing.Point(14, 389);
            this.searchInDoneServices.Name = "searchInDoneServices";
            this.searchInDoneServices.Size = new System.Drawing.Size(175, 45);
            this.searchInDoneServices.TabIndex = 40;
            this.searchInDoneServices.Text = "Найти";
            this.searchInDoneServices.UseVisualStyleBackColor = true;
            this.searchInDoneServices.Click += new System.EventHandler(this.searchInDoneServices_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 20);
            this.label1.TabIndex = 41;
            this.label1.Text = "Наименование фирмы";
            // 
            // providerNameTextBox
            // 
            this.providerNameTextBox.Location = new System.Drawing.Point(12, 92);
            this.providerNameTextBox.Multiline = true;
            this.providerNameTextBox.Name = "providerNameTextBox";
            this.providerNameTextBox.Size = new System.Drawing.Size(177, 128);
            this.providerNameTextBox.TabIndex = 42;
            // 
            // SearchProvidersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.providerNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchInDoneServices);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Name = "SearchProvidersForm";
            this.Text = "Поиск поставщики";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button searchInDoneServices;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox providerNameTextBox;
    }
}