
namespace computerFirm
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.работникиBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.работникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.computerFirmDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.workerid = new System.Windows.Forms.TextBox();
            this.deleteWorkerBtn = new System.Windows.Forms.Button();
            this.addWorkerBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поставщикиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.продукцияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.списокУслугBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.updateTableStringBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.работникиBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.работникиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerFirmDataSetBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.продукцияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокУслугBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(794, 366);
            this.dataGridView1.TabIndex = 0;
            // 
            // работникиBindingSource1
            // 
            this.работникиBindingSource1.DataMember = "Работники";
            // 
            // работникиBindingSource
            // 
            this.работникиBindingSource.DataMember = "Работники";
            this.работникиBindingSource.DataSource = this.computerFirmDataSetBindingSource;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(24, 456);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Код сотрудника";
            // 
            // workerid
            // 
            this.workerid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.workerid.Location = new System.Drawing.Point(21, 475);
            this.workerid.Name = "workerid";
            this.workerid.Size = new System.Drawing.Size(121, 20);
            this.workerid.TabIndex = 8;
            // 
            // deleteWorkerBtn
            // 
            this.deleteWorkerBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteWorkerBtn.Location = new System.Drawing.Point(154, 462);
            this.deleteWorkerBtn.Name = "deleteWorkerBtn";
            this.deleteWorkerBtn.Size = new System.Drawing.Size(123, 35);
            this.deleteWorkerBtn.TabIndex = 14;
            this.deleteWorkerBtn.Text = "Удалить сотрудника";
            this.deleteWorkerBtn.UseVisualStyleBackColor = true;
            this.deleteWorkerBtn.Click += new System.EventHandler(this.deleteWorkerBtn_Click);
            // 
            // addWorkerBtn
            // 
            this.addWorkerBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addWorkerBtn.Location = new System.Drawing.Point(556, 462);
            this.addWorkerBtn.Name = "addWorkerBtn";
            this.addWorkerBtn.Size = new System.Drawing.Size(250, 35);
            this.addWorkerBtn.TabIndex = 15;
            this.addWorkerBtn.Text = "Добавить сотрудника";
            this.addWorkerBtn.UseVisualStyleBackColor = true;
            this.addWorkerBtn.Click += new System.EventHandler(this.addWorkerBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поискToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(818, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.поискToolStripMenuItem.Text = "Поиск";
            this.поискToolStripMenuItem.Click += new System.EventHandler(this.поискToolStripMenuItem_Click);
            // 
            // поставщикиBindingSource
            // 
            this.поставщикиBindingSource.DataMember = "Поставщики";
            this.поставщикиBindingSource.DataSource = this.computerFirmDataSetBindingSource;
            // 
            // продукцияBindingSource
            // 
            this.продукцияBindingSource.DataMember = "Продукция";
            this.продукцияBindingSource.DataSource = this.computerFirmDataSetBindingSource;
            // 
            // списокУслугBindingSource
            // 
            this.списокУслугBindingSource.DataMember = "Список услуг";
            this.списокУслугBindingSource.DataSource = this.computerFirmDataSetBindingSource;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(265, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Таблица Работники";
            // 
            // updateTableStringBtn
            // 
            this.updateTableStringBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.updateTableStringBtn.Location = new System.Drawing.Point(319, 462);
            this.updateTableStringBtn.Name = "updateTableStringBtn";
            this.updateTableStringBtn.Size = new System.Drawing.Size(185, 35);
            this.updateTableStringBtn.TabIndex = 18;
            this.updateTableStringBtn.Text = "Обновить выделенную строку";
            this.updateTableStringBtn.UseVisualStyleBackColor = true;
            this.updateTableStringBtn.Click += new System.EventHandler(this.updateTableStringBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 520);
            this.Controls.Add(this.updateTableStringBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addWorkerBtn);
            this.Controls.Add(this.deleteWorkerBtn);
            this.Controls.Add(this.workerid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(800, 480);
            this.Name = "Form1";
            this.Text = "Работники";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.работникиBindingSource1)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.работникиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerFirmDataSetBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            //((System.ComponentModel.ISupportInitialize)(this.поставщикиBindingSource)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.продукцияBindingSource)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.списокУслугBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource computerFirmDataSetBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox workerid;
        private System.Windows.Forms.Button deleteWorkerBtn;
        private System.Windows.Forms.Button addWorkerBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.BindingSource поставщикиBindingSource;
        private System.Windows.Forms.BindingSource продукцияBindingSource;
        private System.Windows.Forms.BindingSource списокУслугBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource работникиBindingSource;
        private System.Windows.Forms.BindingSource работникиBindingSource1;
        private System.Windows.Forms.Button updateTableStringBtn;
    }
}

