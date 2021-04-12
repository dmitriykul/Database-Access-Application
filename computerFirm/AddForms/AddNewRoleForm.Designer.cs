
namespace computerFirm.AddForms
{
    partial class AddNewRoleForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.changeInfCheckBox = new System.Windows.Forms.CheckBox();
            this.deleteInfCheckBox = new System.Windows.Forms.CheckBox();
            this.addInfCheckBox = new System.Windows.Forms.CheckBox();
            this.roleNameTextBox = new System.Windows.Forms.TextBox();
            this.addNewRoleBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(19, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название роли";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(19, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(348, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Возможность изменять информацию";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(19, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(333, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Возможность удалять информацию";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(19, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(357, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Возможность добавлять информацию";
            // 
            // changeInfCheckBox
            // 
            this.changeInfCheckBox.AutoSize = true;
            this.changeInfCheckBox.Location = new System.Drawing.Point(414, 64);
            this.changeInfCheckBox.Name = "changeInfCheckBox";
            this.changeInfCheckBox.Size = new System.Drawing.Size(15, 14);
            this.changeInfCheckBox.TabIndex = 4;
            this.changeInfCheckBox.UseVisualStyleBackColor = true;
            // 
            // deleteInfCheckBox
            // 
            this.deleteInfCheckBox.AutoSize = true;
            this.deleteInfCheckBox.Location = new System.Drawing.Point(414, 105);
            this.deleteInfCheckBox.Name = "deleteInfCheckBox";
            this.deleteInfCheckBox.Size = new System.Drawing.Size(15, 14);
            this.deleteInfCheckBox.TabIndex = 5;
            this.deleteInfCheckBox.UseVisualStyleBackColor = true;
            // 
            // addInfCheckBox
            // 
            this.addInfCheckBox.AutoSize = true;
            this.addInfCheckBox.Location = new System.Drawing.Point(414, 144);
            this.addInfCheckBox.Name = "addInfCheckBox";
            this.addInfCheckBox.Size = new System.Drawing.Size(15, 14);
            this.addInfCheckBox.TabIndex = 6;
            this.addInfCheckBox.UseVisualStyleBackColor = true;
            // 
            // roleNameTextBox
            // 
            this.roleNameTextBox.Location = new System.Drawing.Point(180, 20);
            this.roleNameTextBox.Name = "roleNameTextBox";
            this.roleNameTextBox.Size = new System.Drawing.Size(249, 20);
            this.roleNameTextBox.TabIndex = 7;
            // 
            // addNewRoleBtn
            // 
            this.addNewRoleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addNewRoleBtn.Location = new System.Drawing.Point(23, 178);
            this.addNewRoleBtn.Name = "addNewRoleBtn";
            this.addNewRoleBtn.Size = new System.Drawing.Size(437, 98);
            this.addNewRoleBtn.TabIndex = 8;
            this.addNewRoleBtn.Text = "Добавить роль";
            this.addNewRoleBtn.UseVisualStyleBackColor = true;
            this.addNewRoleBtn.Click += new System.EventHandler(this.addNewRoleBtn_Click);
            // 
            // AddNewRoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 288);
            this.Controls.Add(this.addNewRoleBtn);
            this.Controls.Add(this.roleNameTextBox);
            this.Controls.Add(this.addInfCheckBox);
            this.Controls.Add(this.deleteInfCheckBox);
            this.Controls.Add(this.changeInfCheckBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimumSize = new System.Drawing.Size(492, 327);
            this.Name = "AddNewRoleForm";
            this.Text = "Добавить роль";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddNewRoleForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox changeInfCheckBox;
        private System.Windows.Forms.CheckBox deleteInfCheckBox;
        private System.Windows.Forms.CheckBox addInfCheckBox;
        private System.Windows.Forms.TextBox roleNameTextBox;
        private System.Windows.Forms.Button addNewRoleBtn;
    }
}