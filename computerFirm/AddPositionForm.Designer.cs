
namespace computerFirm
{
    partial class AddPositionForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.positionName = new System.Windows.Forms.TextBox();
            this.positionSalary = new System.Windows.Forms.TextBox();
            this.addPositionBtn = new System.Windows.Forms.Button();
            this.closeAddPositionFormBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Наименование должности";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Зарплата";
            // 
            // positionName
            // 
            this.positionName.Location = new System.Drawing.Point(199, 18);
            this.positionName.Name = "positionName";
            this.positionName.Size = new System.Drawing.Size(100, 20);
            this.positionName.TabIndex = 3;
            // 
            // positionSalary
            // 
            this.positionSalary.Location = new System.Drawing.Point(199, 51);
            this.positionSalary.Name = "positionSalary";
            this.positionSalary.Size = new System.Drawing.Size(100, 20);
            this.positionSalary.TabIndex = 4;
            // 
            // addPositionBtn
            // 
            this.addPositionBtn.Location = new System.Drawing.Point(327, 18);
            this.addPositionBtn.Name = "addPositionBtn";
            this.addPositionBtn.Size = new System.Drawing.Size(230, 53);
            this.addPositionBtn.TabIndex = 5;
            this.addPositionBtn.Text = "Добавить должность";
            this.addPositionBtn.UseVisualStyleBackColor = true;
            this.addPositionBtn.Click += new System.EventHandler(this.addPositionBtn_Click);
            // 
            // closeAddPositionFormBtn
            // 
            this.closeAddPositionFormBtn.Location = new System.Drawing.Point(133, 99);
            this.closeAddPositionFormBtn.Name = "closeAddPositionFormBtn";
            this.closeAddPositionFormBtn.Size = new System.Drawing.Size(287, 48);
            this.closeAddPositionFormBtn.TabIndex = 6;
            this.closeAddPositionFormBtn.Text = "Закрыть";
            this.closeAddPositionFormBtn.UseVisualStyleBackColor = true;
            this.closeAddPositionFormBtn.Click += new System.EventHandler(this.closeAddPositionFormBtn_Click);
            // 
            // AddPositionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 165);
            this.Controls.Add(this.closeAddPositionFormBtn);
            this.Controls.Add(this.addPositionBtn);
            this.Controls.Add(this.positionSalary);
            this.Controls.Add(this.positionName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddPositionForm";
            this.Text = "AddPositionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox positionName;
        private System.Windows.Forms.TextBox positionSalary;
        private System.Windows.Forms.Button addPositionBtn;
        private System.Windows.Forms.Button closeAddPositionFormBtn;
    }
}