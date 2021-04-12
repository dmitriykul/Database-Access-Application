
namespace computerFirm
{
    partial class SearchInDoneOrdersForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.clientIdForSearch = new System.Windows.Forms.TextBox();
            this.workerIdForSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchByClientId = new System.Windows.Forms.CheckBox();
            this.searchByWorkerId = new System.Windows.Forms.CheckBox();
            this.searchInDoneOrders = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(170, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(415, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "Поиск по таблице Выполненные заказы";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(175, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(613, 397);
            this.dataGridView1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Клиент (Фамилия)";
            // 
            // clientIdForSearch
            // 
            this.clientIdForSearch.Location = new System.Drawing.Point(12, 177);
            this.clientIdForSearch.Name = "clientIdForSearch";
            this.clientIdForSearch.Size = new System.Drawing.Size(100, 20);
            this.clientIdForSearch.TabIndex = 22;
            // 
            // workerIdForSearch
            // 
            this.workerIdForSearch.Location = new System.Drawing.Point(12, 271);
            this.workerIdForSearch.Name = "workerIdForSearch";
            this.workerIdForSearch.Size = new System.Drawing.Size(100, 20);
            this.workerIdForSearch.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Работник (Фамилия)";
            // 
            // searchByClientId
            // 
            this.searchByClientId.AutoSize = true;
            this.searchByClientId.Location = new System.Drawing.Point(135, 179);
            this.searchByClientId.Name = "searchByClientId";
            this.searchByClientId.Size = new System.Drawing.Size(15, 14);
            this.searchByClientId.TabIndex = 25;
            this.searchByClientId.UseVisualStyleBackColor = true;
            // 
            // searchByWorkerId
            // 
            this.searchByWorkerId.AutoSize = true;
            this.searchByWorkerId.Location = new System.Drawing.Point(135, 271);
            this.searchByWorkerId.Name = "searchByWorkerId";
            this.searchByWorkerId.Size = new System.Drawing.Size(15, 14);
            this.searchByWorkerId.TabIndex = 26;
            this.searchByWorkerId.UseVisualStyleBackColor = true;
            // 
            // searchInDoneOrders
            // 
            this.searchInDoneOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchInDoneOrders.Location = new System.Drawing.Point(12, 407);
            this.searchInDoneOrders.Name = "searchInDoneOrders";
            this.searchInDoneOrders.Size = new System.Drawing.Size(157, 27);
            this.searchInDoneOrders.TabIndex = 27;
            this.searchInDoneOrders.Text = "Найти";
            this.searchInDoneOrders.UseVisualStyleBackColor = true;
            this.searchInDoneOrders.Click += new System.EventHandler(this.searchInDoneOrders_Click);
            // 
            // SearchInDoneOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchInDoneOrders);
            this.Controls.Add(this.searchByWorkerId);
            this.Controls.Add(this.searchByClientId);
            this.Controls.Add(this.workerIdForSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clientIdForSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SearchInDoneOrdersForm";
            this.Text = "Поиск выполненные заказы";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox clientIdForSearch;
        private System.Windows.Forms.TextBox workerIdForSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox searchByClientId;
        private System.Windows.Forms.CheckBox searchByWorkerId;
        private System.Windows.Forms.Button searchInDoneOrders;
    }
}