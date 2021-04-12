
namespace computerFirm
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.openListOfOrdersBtn = new System.Windows.Forms.Button();
            this.openWorkersBtn = new System.Windows.Forms.Button();
            this.openClientsbtn = new System.Windows.Forms.Button();
            this.openOtdelsBtn = new System.Windows.Forms.Button();
            this.openPositionsBtn = new System.Windows.Forms.Button();
            this.openProductsBtn = new System.Windows.Forms.Button();
            this.openProvidersBtn = new System.Windows.Forms.Button();
            this.openDoneServicesBtn = new System.Windows.Forms.Button();
            this.openDoneOrdersBtn = new System.Windows.Forms.Button();
            this.closeAllBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.редактироватьПользователейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(272, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добро пожаловать!";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.openListOfOrdersBtn);
            this.groupBox1.Controls.Add(this.openWorkersBtn);
            this.groupBox1.Controls.Add(this.openClientsbtn);
            this.groupBox1.Controls.Add(this.openOtdelsBtn);
            this.groupBox1.Controls.Add(this.openPositionsBtn);
            this.groupBox1.Controls.Add(this.openProductsBtn);
            this.groupBox1.Controls.Add(this.openProvidersBtn);
            this.groupBox1.Controls.Add(this.openDoneServicesBtn);
            this.groupBox1.Controls.Add(this.openDoneOrdersBtn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(225, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 390);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Таблицы";
            // 
            // openListOfOrdersBtn
            // 
            this.openListOfOrdersBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openListOfOrdersBtn.Location = new System.Drawing.Point(6, 108);
            this.openListOfOrdersBtn.Name = "openListOfOrdersBtn";
            this.openListOfOrdersBtn.Size = new System.Drawing.Size(302, 34);
            this.openListOfOrdersBtn.TabIndex = 2;
            this.openListOfOrdersBtn.Text = "Список услуг";
            this.openListOfOrdersBtn.UseVisualStyleBackColor = true;
            this.openListOfOrdersBtn.Click += new System.EventHandler(this.openListOfOrdersBtn_Click);
            // 
            // openWorkersBtn
            // 
            this.openWorkersBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openWorkersBtn.Location = new System.Drawing.Point(6, 228);
            this.openWorkersBtn.Name = "openWorkersBtn";
            this.openWorkersBtn.Size = new System.Drawing.Size(302, 34);
            this.openWorkersBtn.TabIndex = 5;
            this.openWorkersBtn.Text = "Работники";
            this.openWorkersBtn.UseVisualStyleBackColor = true;
            this.openWorkersBtn.Click += new System.EventHandler(this.openWorkersBtn_Click);
            // 
            // openClientsbtn
            // 
            this.openClientsbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openClientsbtn.Location = new System.Drawing.Point(6, 308);
            this.openClientsbtn.Name = "openClientsbtn";
            this.openClientsbtn.Size = new System.Drawing.Size(302, 34);
            this.openClientsbtn.TabIndex = 7;
            this.openClientsbtn.Text = "Клиенты";
            this.openClientsbtn.UseVisualStyleBackColor = true;
            this.openClientsbtn.Click += new System.EventHandler(this.openClientsbtn_Click);
            // 
            // openOtdelsBtn
            // 
            this.openOtdelsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openOtdelsBtn.Location = new System.Drawing.Point(6, 348);
            this.openOtdelsBtn.Name = "openOtdelsBtn";
            this.openOtdelsBtn.Size = new System.Drawing.Size(302, 34);
            this.openOtdelsBtn.TabIndex = 8;
            this.openOtdelsBtn.Text = "Отделы";
            this.openOtdelsBtn.UseVisualStyleBackColor = true;
            this.openOtdelsBtn.Click += new System.EventHandler(this.openOtdelsBtn_Click);
            // 
            // openPositionsBtn
            // 
            this.openPositionsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openPositionsBtn.Location = new System.Drawing.Point(6, 188);
            this.openPositionsBtn.Name = "openPositionsBtn";
            this.openPositionsBtn.Size = new System.Drawing.Size(302, 34);
            this.openPositionsBtn.TabIndex = 4;
            this.openPositionsBtn.Text = "Должности";
            this.openPositionsBtn.UseVisualStyleBackColor = true;
            this.openPositionsBtn.Click += new System.EventHandler(this.openPositionsBtn_Click);
            // 
            // openProductsBtn
            // 
            this.openProductsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openProductsBtn.Location = new System.Drawing.Point(6, 268);
            this.openProductsBtn.Name = "openProductsBtn";
            this.openProductsBtn.Size = new System.Drawing.Size(302, 34);
            this.openProductsBtn.TabIndex = 6;
            this.openProductsBtn.Text = "Продукция";
            this.openProductsBtn.UseVisualStyleBackColor = true;
            this.openProductsBtn.Click += new System.EventHandler(this.openProductsBtn_Click);
            // 
            // openProvidersBtn
            // 
            this.openProvidersBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openProvidersBtn.Location = new System.Drawing.Point(6, 148);
            this.openProvidersBtn.Name = "openProvidersBtn";
            this.openProvidersBtn.Size = new System.Drawing.Size(302, 34);
            this.openProvidersBtn.TabIndex = 3;
            this.openProvidersBtn.Text = "Поставщики";
            this.openProvidersBtn.UseVisualStyleBackColor = true;
            this.openProvidersBtn.Click += new System.EventHandler(this.openProvidersBtn_Click);
            // 
            // openDoneServicesBtn
            // 
            this.openDoneServicesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openDoneServicesBtn.Location = new System.Drawing.Point(6, 68);
            this.openDoneServicesBtn.Name = "openDoneServicesBtn";
            this.openDoneServicesBtn.Size = new System.Drawing.Size(302, 34);
            this.openDoneServicesBtn.TabIndex = 1;
            this.openDoneServicesBtn.Text = "Выполненные услуги";
            this.openDoneServicesBtn.UseVisualStyleBackColor = true;
            this.openDoneServicesBtn.Click += new System.EventHandler(this.openDoneServicesBtn_Click);
            // 
            // openDoneOrdersBtn
            // 
            this.openDoneOrdersBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openDoneOrdersBtn.Location = new System.Drawing.Point(6, 28);
            this.openDoneOrdersBtn.Name = "openDoneOrdersBtn";
            this.openDoneOrdersBtn.Size = new System.Drawing.Size(302, 34);
            this.openDoneOrdersBtn.TabIndex = 0;
            this.openDoneOrdersBtn.Text = "Выполненные заказы";
            this.openDoneOrdersBtn.UseVisualStyleBackColor = true;
            this.openDoneOrdersBtn.Click += new System.EventHandler(this.openDoneOrdersBtn_Click);
            // 
            // closeAllBtn
            // 
            this.closeAllBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.closeAllBtn.Location = new System.Drawing.Point(12, 414);
            this.closeAllBtn.Name = "closeAllBtn";
            this.closeAllBtn.Size = new System.Drawing.Size(161, 34);
            this.closeAllBtn.TabIndex = 0;
            this.closeAllBtn.Text = "Закрыть всё";
            this.closeAllBtn.UseVisualStyleBackColor = true;
            this.closeAllBtn.Click += new System.EventHandler(this.closeAllBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.редактироватьПользователейToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(776, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // редактироватьПользователейToolStripMenuItem
            // 
            this.редактироватьПользователейToolStripMenuItem.Name = "редактироватьПользователейToolStripMenuItem";
            this.редактироватьПользователейToolStripMenuItem.Size = new System.Drawing.Size(178, 20);
            this.редактироватьПользователейToolStripMenuItem.Text = "Редактировать пользователей";
            this.редактироватьПользователейToolStripMenuItem.Click += new System.EventHandler(this.редактироватьПользователейToolStripMenuItem_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(603, 414);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(161, 34);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "Выйти";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 460);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.closeAllBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Главная";
            this.Click += new System.EventHandler(this.MainForm_Click);
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button openListOfOrdersBtn;
        private System.Windows.Forms.Button openWorkersBtn;
        private System.Windows.Forms.Button openClientsbtn;
        private System.Windows.Forms.Button openOtdelsBtn;
        private System.Windows.Forms.Button openPositionsBtn;
        private System.Windows.Forms.Button openProductsBtn;
        private System.Windows.Forms.Button openProvidersBtn;
        private System.Windows.Forms.Button openDoneServicesBtn;
        private System.Windows.Forms.Button openDoneOrdersBtn;
        private System.Windows.Forms.Button closeAllBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem редактироватьПользователейToolStripMenuItem;
        private System.Windows.Forms.Button exitBtn;
    }
}