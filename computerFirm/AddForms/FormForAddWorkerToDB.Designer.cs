
namespace computerFirm
{
    partial class FormForAddWorkerToDB
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.workerName = new System.Windows.Forms.TextBox();
            this.workerSecondName = new System.Windows.Forms.TextBox();
            this.workerThirdName = new System.Windows.Forms.TextBox();
            this.workerPhoneNum = new System.Windows.Forms.TextBox();
            this.addWorkerToDbBtn = new System.Windows.Forms.Button();
            this.closeAddFormBtn = new System.Windows.Forms.Button();
            this.postComboBox = new System.Windows.Forms.ComboBox();
            this.computerFirmDataSet = new computerFirm.ComputerFirmDataSet();
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postTableAdapter = new computerFirm.ComputerFirmDataSetTableAdapters.PostTableAdapter();
            this.departmentComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.computerFirmDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Отчество (при наличии)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Должность";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Отдел";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(208, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Номер телефона (89999999999)";
            // 
            // workerName
            // 
            this.workerName.Location = new System.Drawing.Point(232, 8);
            this.workerName.Name = "workerName";
            this.workerName.Size = new System.Drawing.Size(141, 20);
            this.workerName.TabIndex = 6;
            // 
            // workerSecondName
            // 
            this.workerSecondName.Location = new System.Drawing.Point(232, 39);
            this.workerSecondName.Name = "workerSecondName";
            this.workerSecondName.Size = new System.Drawing.Size(141, 20);
            this.workerSecondName.TabIndex = 7;
            // 
            // workerThirdName
            // 
            this.workerThirdName.Location = new System.Drawing.Point(232, 70);
            this.workerThirdName.Name = "workerThirdName";
            this.workerThirdName.Size = new System.Drawing.Size(141, 20);
            this.workerThirdName.TabIndex = 8;
            // 
            // workerPhoneNum
            // 
            this.workerPhoneNum.Location = new System.Drawing.Point(232, 152);
            this.workerPhoneNum.Name = "workerPhoneNum";
            this.workerPhoneNum.Size = new System.Drawing.Size(141, 20);
            this.workerPhoneNum.TabIndex = 11;
            // 
            // addWorkerToDbBtn
            // 
            this.addWorkerToDbBtn.Location = new System.Drawing.Point(410, 8);
            this.addWorkerToDbBtn.Name = "addWorkerToDbBtn";
            this.addWorkerToDbBtn.Size = new System.Drawing.Size(219, 109);
            this.addWorkerToDbBtn.TabIndex = 12;
            this.addWorkerToDbBtn.Text = "Добавить";
            this.addWorkerToDbBtn.UseVisualStyleBackColor = true;
            this.addWorkerToDbBtn.Click += new System.EventHandler(this.addWorkerToDbBtn_Click);
            // 
            // closeAddFormBtn
            // 
            this.closeAddFormBtn.Location = new System.Drawing.Point(410, 141);
            this.closeAddFormBtn.Name = "closeAddFormBtn";
            this.closeAddFormBtn.Size = new System.Drawing.Size(219, 37);
            this.closeAddFormBtn.TabIndex = 13;
            this.closeAddFormBtn.Text = "Закрыть";
            this.closeAddFormBtn.UseVisualStyleBackColor = true;
            this.closeAddFormBtn.Click += new System.EventHandler(this.closeAddFormBtn_Click);
            // 
            // postComboBox
            // 
            this.postComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.postComboBox.FormattingEnabled = true;
            this.postComboBox.Location = new System.Drawing.Point(232, 99);
            this.postComboBox.Name = "postComboBox";
            this.postComboBox.Size = new System.Drawing.Size(141, 21);
            this.postComboBox.TabIndex = 14;
            // 
            // computerFirmDataSet
            // 
            this.computerFirmDataSet.DataSetName = "ComputerFirmDataSet";
            this.computerFirmDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // postBindingSource
            // 
            this.postBindingSource.DataMember = "Post";
            this.postBindingSource.DataSource = this.computerFirmDataSet;
            // 
            // postTableAdapter
            // 
            this.postTableAdapter.ClearBeforeFill = true;
            // 
            // departmentComboBox
            // 
            this.departmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departmentComboBox.FormattingEnabled = true;
            this.departmentComboBox.Location = new System.Drawing.Point(232, 126);
            this.departmentComboBox.Name = "departmentComboBox";
            this.departmentComboBox.Size = new System.Drawing.Size(141, 21);
            this.departmentComboBox.TabIndex = 15;
            // 
            // FormForAddWorkerToDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 192);
            this.Controls.Add(this.departmentComboBox);
            this.Controls.Add(this.postComboBox);
            this.Controls.Add(this.closeAddFormBtn);
            this.Controls.Add(this.addWorkerToDbBtn);
            this.Controls.Add(this.workerPhoneNum);
            this.Controls.Add(this.workerThirdName);
            this.Controls.Add(this.workerSecondName);
            this.Controls.Add(this.workerName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormForAddWorkerToDB";
            this.Text = "Добавить работника";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormForAddWorkerToDB_FormClosing);
            this.Load += new System.EventHandler(this.FormForAddWorkerToDB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.computerFirmDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox workerName;
        private System.Windows.Forms.TextBox workerSecondName;
        private System.Windows.Forms.TextBox workerThirdName;
        private System.Windows.Forms.TextBox workerPhoneNum;
        private System.Windows.Forms.Button addWorkerToDbBtn;
        private System.Windows.Forms.Button closeAddFormBtn;
        private System.Windows.Forms.ComboBox postComboBox;
        private ComputerFirmDataSet computerFirmDataSet;
        private System.Windows.Forms.BindingSource postBindingSource;
        private ComputerFirmDataSetTableAdapters.PostTableAdapter postTableAdapter;
        private System.Windows.Forms.ComboBox departmentComboBox;
    }
}