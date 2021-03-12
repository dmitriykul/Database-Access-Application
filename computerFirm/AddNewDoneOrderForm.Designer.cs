
namespace computerFirm
{
    partial class AddNewDoneOrderForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.clientId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.productId = new System.Windows.Forms.TextBox();
            this.workerId = new System.Windows.Forms.TextBox();
            this.otdelId = new System.Windows.Forms.TextBox();
            this.dateOfOrder = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Клиент (ID)";
            // 
            // clientId
            // 
            this.clientId.Location = new System.Drawing.Point(176, 28);
            this.clientId.Name = "clientId";
            this.clientId.Size = new System.Drawing.Size(100, 20);
            this.clientId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Продукт (ID)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Работник  (ID)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Отдел (ID)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Дата (дд/мм./гггг)";
            // 
            // productId
            // 
            this.productId.Location = new System.Drawing.Point(176, 74);
            this.productId.Name = "productId";
            this.productId.Size = new System.Drawing.Size(100, 20);
            this.productId.TabIndex = 6;
            // 
            // workerId
            // 
            this.workerId.Location = new System.Drawing.Point(176, 128);
            this.workerId.Name = "workerId";
            this.workerId.Size = new System.Drawing.Size(100, 20);
            this.workerId.TabIndex = 7;
            // 
            // otdelId
            // 
            this.otdelId.Location = new System.Drawing.Point(176, 180);
            this.otdelId.Name = "otdelId";
            this.otdelId.Size = new System.Drawing.Size(100, 20);
            this.otdelId.TabIndex = 8;
            // 
            // dateOfOrder
            // 
            this.dateOfOrder.Location = new System.Drawing.Point(176, 239);
            this.dateOfOrder.Name = "dateOfOrder";
            this.dateOfOrder.Size = new System.Drawing.Size(100, 20);
            this.dateOfOrder.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(356, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 231);
            this.button1.TabIndex = 10;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddNewDoneOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 288);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateOfOrder);
            this.Controls.Add(this.otdelId);
            this.Controls.Add(this.workerId);
            this.Controls.Add(this.productId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clientId);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddNewDoneOrderForm";
            this.Text = "AddNewDoneOrderForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddNewDoneOrderForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox clientId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox productId;
        private System.Windows.Forms.TextBox workerId;
        private System.Windows.Forms.TextBox otdelId;
        private System.Windows.Forms.TextBox dateOfOrder;
        private System.Windows.Forms.Button button1;
    }
}