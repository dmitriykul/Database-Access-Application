
namespace computerFirm
{
    partial class SearchForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.secondNameForSearch = new System.Windows.Forms.TextBox();
            this.searchBySecondNameBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.postForSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.otdelForSearch = new System.Windows.Forms.TextBox();
            this.phoneNumForSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nameForSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.searchBySecondName = new System.Windows.Forms.CheckBox();
            this.searchByName = new System.Windows.Forms.CheckBox();
            this.searchByPost = new System.Windows.Forms.CheckBox();
            this.searchByOtdel = new System.Windows.Forms.CheckBox();
            this.searchByPhoneNum = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Фамилия";
            // 
            // secondNameForSearch
            // 
            this.secondNameForSearch.Location = new System.Drawing.Point(15, 70);
            this.secondNameForSearch.Name = "secondNameForSearch";
            this.secondNameForSearch.Size = new System.Drawing.Size(126, 20);
            this.secondNameForSearch.TabIndex = 2;
            this.secondNameForSearch.Text = "Иванов";
            // 
            // searchBySecondNameBtn
            // 
            this.searchBySecondNameBtn.Location = new System.Drawing.Point(15, 415);
            this.searchBySecondNameBtn.Name = "searchBySecondNameBtn";
            this.searchBySecondNameBtn.Size = new System.Drawing.Size(126, 23);
            this.searchBySecondNameBtn.TabIndex = 3;
            this.searchBySecondNameBtn.Text = "Найти";
            this.searchBySecondNameBtn.UseVisualStyleBackColor = true;
            this.searchBySecondNameBtn.Click += new System.EventHandler(this.searchBySecondNameBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(175, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(613, 397);
            this.dataGridView1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Должность";
            // 
            // postForSearch
            // 
            this.postForSearch.Location = new System.Drawing.Point(15, 201);
            this.postForSearch.Name = "postForSearch";
            this.postForSearch.Size = new System.Drawing.Size(126, 20);
            this.postForSearch.TabIndex = 6;
            this.postForSearch.Text = "Директор";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Отдел";
            // 
            // otdelForSearch
            // 
            this.otdelForSearch.Location = new System.Drawing.Point(15, 254);
            this.otdelForSearch.Name = "otdelForSearch";
            this.otdelForSearch.Size = new System.Drawing.Size(126, 20);
            this.otdelForSearch.TabIndex = 8;
            this.otdelForSearch.Text = "Головной";
            // 
            // phoneNumForSearch
            // 
            this.phoneNumForSearch.Location = new System.Drawing.Point(15, 309);
            this.phoneNumForSearch.Name = "phoneNumForSearch";
            this.phoneNumForSearch.Size = new System.Drawing.Size(126, 20);
            this.phoneNumForSearch.TabIndex = 10;
            this.phoneNumForSearch.Text = "999 9999999";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Номер телефона";
            // 
            // nameForSearch
            // 
            this.nameForSearch.Location = new System.Drawing.Point(15, 135);
            this.nameForSearch.Name = "nameForSearch";
            this.nameForSearch.Size = new System.Drawing.Size(126, 20);
            this.nameForSearch.TabIndex = 12;
            this.nameForSearch.Text = "Иван";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Имя";
            // 
            // searchBySecondName
            // 
            this.searchBySecondName.AutoSize = true;
            this.searchBySecondName.Location = new System.Drawing.Point(154, 73);
            this.searchBySecondName.Name = "searchBySecondName";
            this.searchBySecondName.Size = new System.Drawing.Size(15, 14);
            this.searchBySecondName.TabIndex = 13;
            this.searchBySecondName.UseVisualStyleBackColor = true;
            // 
            // searchByName
            // 
            this.searchByName.AutoSize = true;
            this.searchByName.Location = new System.Drawing.Point(154, 138);
            this.searchByName.Name = "searchByName";
            this.searchByName.Size = new System.Drawing.Size(15, 14);
            this.searchByName.TabIndex = 14;
            this.searchByName.UseVisualStyleBackColor = true;
            // 
            // searchByPost
            // 
            this.searchByPost.AutoSize = true;
            this.searchByPost.Location = new System.Drawing.Point(154, 204);
            this.searchByPost.Name = "searchByPost";
            this.searchByPost.Size = new System.Drawing.Size(15, 14);
            this.searchByPost.TabIndex = 15;
            this.searchByPost.UseVisualStyleBackColor = true;
            // 
            // searchByOtdel
            // 
            this.searchByOtdel.AutoSize = true;
            this.searchByOtdel.Location = new System.Drawing.Point(154, 257);
            this.searchByOtdel.Name = "searchByOtdel";
            this.searchByOtdel.Size = new System.Drawing.Size(15, 14);
            this.searchByOtdel.TabIndex = 16;
            this.searchByOtdel.UseVisualStyleBackColor = true;
            // 
            // searchByPhoneNum
            // 
            this.searchByPhoneNum.AutoSize = true;
            this.searchByPhoneNum.Location = new System.Drawing.Point(154, 312);
            this.searchByPhoneNum.Name = "searchByPhoneNum";
            this.searchByPhoneNum.Size = new System.Drawing.Size(15, 14);
            this.searchByPhoneNum.TabIndex = 17;
            this.searchByPhoneNum.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(243, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(304, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "Поиск по таблице Работники";
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.searchByPhoneNum);
            this.Controls.Add(this.searchByOtdel);
            this.Controls.Add(this.searchByPost);
            this.Controls.Add(this.searchByName);
            this.Controls.Add(this.searchBySecondName);
            this.Controls.Add(this.nameForSearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.phoneNumForSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.otdelForSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.postForSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.searchBySecondNameBtn);
            this.Controls.Add(this.secondNameForSearch);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SearchForm";
            this.Text = "Поиск работников";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox secondNameForSearch;
        private System.Windows.Forms.Button searchBySecondNameBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox postForSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox otdelForSearch;
        private System.Windows.Forms.TextBox phoneNumForSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameForSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox searchBySecondName;
        private System.Windows.Forms.CheckBox searchByName;
        private System.Windows.Forms.CheckBox searchByPost;
        private System.Windows.Forms.CheckBox searchByOtdel;
        private System.Windows.Forms.CheckBox searchByPhoneNum;
        private System.Windows.Forms.Label label6;
    }
}