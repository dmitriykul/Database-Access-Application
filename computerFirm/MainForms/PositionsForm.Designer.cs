
namespace computerFirm
{
    partial class PositionsForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.должностиBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.должностиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addPositionBtn = new System.Windows.Forms.Button();
            this.deletePositionBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.positionsComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.должностиBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.должностиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(265, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Таблица Должности";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(786, 323);
            this.dataGridView1.TabIndex = 20;
            // 
            // должностиBindingSource1
            // 
            this.должностиBindingSource1.DataMember = "Должности";
            // 
            // должностиBindingSource
            // 
            this.должностиBindingSource.DataMember = "Должности";
            // 
            // addPositionBtn
            // 
            this.addPositionBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addPositionBtn.Location = new System.Drawing.Point(597, 394);
            this.addPositionBtn.Name = "addPositionBtn";
            this.addPositionBtn.Size = new System.Drawing.Size(201, 35);
            this.addPositionBtn.TabIndex = 24;
            this.addPositionBtn.Text = "Добавить должность";
            this.addPositionBtn.UseVisualStyleBackColor = true;
            this.addPositionBtn.Click += new System.EventHandler(this.addPositionBtn_Click);
            // 
            // deletePositionBtn
            // 
            this.deletePositionBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deletePositionBtn.Location = new System.Drawing.Point(175, 394);
            this.deletePositionBtn.Name = "deletePositionBtn";
            this.deletePositionBtn.Size = new System.Drawing.Size(146, 35);
            this.deletePositionBtn.TabIndex = 23;
            this.deletePositionBtn.Text = "Удалить должность";
            this.deletePositionBtn.UseVisualStyleBackColor = true;
            this.deletePositionBtn.Click += new System.EventHandler(this.deletePositionBtn_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Должность";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(367, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 35);
            this.button1.TabIndex = 25;
            this.button1.Text = "Изменить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // positionsComboBox
            // 
            this.positionsComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.positionsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.positionsComboBox.FormattingEnabled = true;
            this.positionsComboBox.Location = new System.Drawing.Point(12, 408);
            this.positionsComboBox.Name = "positionsComboBox";
            this.positionsComboBox.Size = new System.Drawing.Size(137, 21);
            this.positionsComboBox.TabIndex = 26;
            // 
            // PositionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 441);
            this.Controls.Add(this.positionsComboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addPositionBtn);
            this.Controls.Add(this.deletePositionBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(800, 480);
            this.Name = "PositionsForm";
            this.Text = "Должности";
            this.Activated += new System.EventHandler(this.PositionsForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PositionsForm_FormClosing);
            this.Load += new System.EventHandler(this.PositionsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.должностиBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.должностиBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addPositionBtn;
        private System.Windows.Forms.Button deletePositionBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource должностиBindingSource;
        private System.Windows.Forms.BindingSource должностиBindingSource1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox positionsComboBox;
    }
}