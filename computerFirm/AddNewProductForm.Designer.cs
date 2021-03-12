
namespace computerFirm
{
    partial class AddNewProductForm
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
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.isThere = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.productProviderTextBox = new System.Windows.Forms.TextBox();
            this.productCostTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Location = new System.Drawing.Point(144, 34);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(306, 20);
            this.productNameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Наименование";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(438, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "Добавить продукт";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // isThere
            // 
            this.isThere.AutoSize = true;
            this.isThere.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.isThere.Location = new System.Drawing.Point(16, 187);
            this.isThere.Name = "isThere";
            this.isThere.Size = new System.Drawing.Size(176, 24);
            this.isThere.TabIndex = 3;
            this.isThere.Text = "Наличие на складе";
            this.isThere.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Поставщик (ID)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Стоимость";
            // 
            // productProviderTextBox
            // 
            this.productProviderTextBox.Location = new System.Drawing.Point(144, 86);
            this.productProviderTextBox.Name = "productProviderTextBox";
            this.productProviderTextBox.Size = new System.Drawing.Size(306, 20);
            this.productProviderTextBox.TabIndex = 6;
            // 
            // productCostTextBox
            // 
            this.productCostTextBox.Location = new System.Drawing.Point(144, 133);
            this.productCostTextBox.Name = "productCostTextBox";
            this.productCostTextBox.Size = new System.Drawing.Size(306, 20);
            this.productCostTextBox.TabIndex = 7;
            // 
            // AddNewProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 285);
            this.Controls.Add(this.productCostTextBox);
            this.Controls.Add(this.productProviderTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.isThere);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productNameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddNewProductForm";
            this.Text = "AddNewProductForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddNewProductForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox isThere;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox productProviderTextBox;
        private System.Windows.Forms.TextBox productCostTextBox;
    }
}