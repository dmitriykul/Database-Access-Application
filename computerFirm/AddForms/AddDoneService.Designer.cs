
namespace computerFirm
{
    partial class AddDoneService
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
            this.addDoneServices = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.serviceCost = new System.Windows.Forms.TextBox();
            this.serviceNameComboBox = new System.Windows.Forms.ComboBox();
            this.clientComboBox = new System.Windows.Forms.ComboBox();
            this.departComboBox = new System.Windows.Forms.ComboBox();
            this.workerComboBox = new System.Windows.Forms.ComboBox();
            this.dateService = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вид услуги";
            // 
            // addDoneServices
            // 
            this.addDoneServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addDoneServices.Location = new System.Drawing.Point(341, 20);
            this.addDoneServices.Name = "addDoneServices";
            this.addDoneServices.Size = new System.Drawing.Size(131, 199);
            this.addDoneServices.TabIndex = 2;
            this.addDoneServices.Text = "Добавить выполненную услугу";
            this.addDoneServices.UseVisualStyleBackColor = true;
            this.addDoneServices.Click += new System.EventHandler(this.addDoneServices_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Стоимость";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Клиент";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Отдел";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Дата (ДД//ММ/ГГГГ)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Работник";
            // 
            // serviceCost
            // 
            this.serviceCost.Location = new System.Drawing.Point(178, 58);
            this.serviceCost.Name = "serviceCost";
            this.serviceCost.Size = new System.Drawing.Size(157, 20);
            this.serviceCost.TabIndex = 8;
            // 
            // serviceNameComboBox
            // 
            this.serviceNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serviceNameComboBox.FormattingEnabled = true;
            this.serviceNameComboBox.Location = new System.Drawing.Point(178, 22);
            this.serviceNameComboBox.Name = "serviceNameComboBox";
            this.serviceNameComboBox.Size = new System.Drawing.Size(157, 21);
            this.serviceNameComboBox.TabIndex = 13;
            // 
            // clientComboBox
            // 
            this.clientComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clientComboBox.FormattingEnabled = true;
            this.clientComboBox.Location = new System.Drawing.Point(178, 94);
            this.clientComboBox.Name = "clientComboBox";
            this.clientComboBox.Size = new System.Drawing.Size(157, 21);
            this.clientComboBox.TabIndex = 14;
            // 
            // departComboBox
            // 
            this.departComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departComboBox.FormattingEnabled = true;
            this.departComboBox.Location = new System.Drawing.Point(178, 127);
            this.departComboBox.Name = "departComboBox";
            this.departComboBox.Size = new System.Drawing.Size(157, 21);
            this.departComboBox.TabIndex = 15;
            this.departComboBox.DisplayMemberChanged += new System.EventHandler(this.departComboBox_DisplayMemberChanged);
            this.departComboBox.SelectedValueChanged += new System.EventHandler(this.departComboBox_SelectedValueChanged);
            // 
            // workerComboBox
            // 
            this.workerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.workerComboBox.FormattingEnabled = true;
            this.workerComboBox.Location = new System.Drawing.Point(178, 201);
            this.workerComboBox.Name = "workerComboBox";
            this.workerComboBox.Size = new System.Drawing.Size(157, 21);
            this.workerComboBox.TabIndex = 16;
            // 
            // dateService
            // 
            this.dateService.Location = new System.Drawing.Point(178, 163);
            this.dateService.Name = "dateService";
            this.dateService.Size = new System.Drawing.Size(157, 20);
            this.dateService.TabIndex = 17;
            // 
            // AddDoneService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 248);
            this.Controls.Add(this.dateService);
            this.Controls.Add(this.workerComboBox);
            this.Controls.Add(this.departComboBox);
            this.Controls.Add(this.clientComboBox);
            this.Controls.Add(this.serviceNameComboBox);
            this.Controls.Add(this.serviceCost);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addDoneServices);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddDoneService";
            this.Text = "Добавить выполненную услугу";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddDoneService_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addDoneServices;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox serviceCost;
        private System.Windows.Forms.ComboBox serviceNameComboBox;
        private System.Windows.Forms.ComboBox clientComboBox;
        private System.Windows.Forms.ComboBox departComboBox;
        private System.Windows.Forms.ComboBox workerComboBox;
        private System.Windows.Forms.DateTimePicker dateService;
    }
}