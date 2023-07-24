namespace EF_HW_2
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_UpdateBook = new System.Windows.Forms.Button();
            this.btn_DeleteBook = new System.Windows.Forms.Button();
            this.btn_AddBook = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdb_SearchByPressName = new System.Windows.Forms.RadioButton();
            this.rdb_SearchByCategory = new System.Windows.Forms.RadioButton();
            this.rdb_SearchByTitle = new System.Windows.Forms.RadioButton();
            this.rdb_SearchByAuthor = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(217, 80);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1127, 340);
            this.listBox1.TabIndex = 14;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(217, 44);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(255, 27);
            this.textBox1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(217, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Введите значение для поиска";
            // 
            // btn_UpdateBook
            // 
            this.btn_UpdateBook.BackColor = System.Drawing.Color.Yellow;
            this.btn_UpdateBook.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_UpdateBook.Location = new System.Drawing.Point(17, 367);
            this.btn_UpdateBook.Margin = new System.Windows.Forms.Padding(4);
            this.btn_UpdateBook.Name = "btn_UpdateBook";
            this.btn_UpdateBook.Size = new System.Drawing.Size(192, 55);
            this.btn_UpdateBook.TabIndex = 11;
            this.btn_UpdateBook.Text = "Изменить";
            this.btn_UpdateBook.UseVisualStyleBackColor = false;
            this.btn_UpdateBook.Click += new System.EventHandler(this.btn_UpdateBook_Click);
            // 
            // btn_DeleteBook
            // 
            this.btn_DeleteBook.BackColor = System.Drawing.Color.IndianRed;
            this.btn_DeleteBook.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_DeleteBook.Location = new System.Drawing.Point(17, 273);
            this.btn_DeleteBook.Margin = new System.Windows.Forms.Padding(4);
            this.btn_DeleteBook.Name = "btn_DeleteBook";
            this.btn_DeleteBook.Size = new System.Drawing.Size(192, 59);
            this.btn_DeleteBook.TabIndex = 10;
            this.btn_DeleteBook.Text = "Удалить";
            this.btn_DeleteBook.UseVisualStyleBackColor = false;
            this.btn_DeleteBook.Click += new System.EventHandler(this.btn_DeleteBook_Click);
            // 
            // btn_AddBook
            // 
            this.btn_AddBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_AddBook.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_AddBook.Location = new System.Drawing.Point(17, 183);
            this.btn_AddBook.Margin = new System.Windows.Forms.Padding(4);
            this.btn_AddBook.Name = "btn_AddBook";
            this.btn_AddBook.Size = new System.Drawing.Size(192, 59);
            this.btn_AddBook.TabIndex = 9;
            this.btn_AddBook.Text = "Добавить";
            this.btn_AddBook.UseVisualStyleBackColor = false;
            this.btn_AddBook.Click += new System.EventHandler(this.btn_AddBook_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.rdb_SearchByPressName);
            this.groupBox1.Controls.Add(this.rdb_SearchByCategory);
            this.groupBox1.Controls.Add(this.rdb_SearchByTitle);
            this.groupBox1.Controls.Add(this.rdb_SearchByAuthor);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(17, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(192, 160);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск";
            // 
            // rdb_SearchByPressName
            // 
            this.rdb_SearchByPressName.AutoSize = true;
            this.rdb_SearchByPressName.Location = new System.Drawing.Point(8, 121);
            this.rdb_SearchByPressName.Margin = new System.Windows.Forms.Padding(4);
            this.rdb_SearchByPressName.Name = "rdb_SearchByPressName";
            this.rdb_SearchByPressName.Size = new System.Drawing.Size(171, 27);
            this.rdb_SearchByPressName.TabIndex = 3;
            this.rdb_SearchByPressName.Text = "По издательству";
            this.rdb_SearchByPressName.UseVisualStyleBackColor = true;
            this.rdb_SearchByPressName.CheckedChanged += new System.EventHandler(this.rdb_CheckedChanged);
            // 
            // rdb_SearchByCategory
            // 
            this.rdb_SearchByCategory.AutoSize = true;
            this.rdb_SearchByCategory.Location = new System.Drawing.Point(8, 92);
            this.rdb_SearchByCategory.Margin = new System.Windows.Forms.Padding(4);
            this.rdb_SearchByCategory.Name = "rdb_SearchByCategory";
            this.rdb_SearchByCategory.Size = new System.Drawing.Size(147, 27);
            this.rdb_SearchByCategory.TabIndex = 2;
            this.rdb_SearchByCategory.Text = "По категории";
            this.rdb_SearchByCategory.UseVisualStyleBackColor = true;
            this.rdb_SearchByCategory.CheckedChanged += new System.EventHandler(this.rdb_CheckedChanged);
            // 
            // rdb_SearchByTitle
            // 
            this.rdb_SearchByTitle.AutoSize = true;
            this.rdb_SearchByTitle.Location = new System.Drawing.Point(8, 64);
            this.rdb_SearchByTitle.Margin = new System.Windows.Forms.Padding(4);
            this.rdb_SearchByTitle.Name = "rdb_SearchByTitle";
            this.rdb_SearchByTitle.Size = new System.Drawing.Size(144, 27);
            this.rdb_SearchByTitle.TabIndex = 1;
            this.rdb_SearchByTitle.Text = "По названию";
            this.rdb_SearchByTitle.UseVisualStyleBackColor = true;
            this.rdb_SearchByTitle.CheckedChanged += new System.EventHandler(this.rdb_CheckedChanged);
            // 
            // rdb_SearchByAuthor
            // 
            this.rdb_SearchByAuthor.AutoSize = true;
            this.rdb_SearchByAuthor.Location = new System.Drawing.Point(8, 36);
            this.rdb_SearchByAuthor.Margin = new System.Windows.Forms.Padding(4);
            this.rdb_SearchByAuthor.Name = "rdb_SearchByAuthor";
            this.rdb_SearchByAuthor.Size = new System.Drawing.Size(118, 27);
            this.rdb_SearchByAuthor.TabIndex = 0;
            this.rdb_SearchByAuthor.Text = "По автору";
            this.rdb_SearchByAuthor.UseVisualStyleBackColor = true;
            this.rdb_SearchByAuthor.CheckedChanged += new System.EventHandler(this.rdb_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 439);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_UpdateBook);
            this.Controls.Add(this.btn_DeleteBook);
            this.Controls.Add(this.btn_AddBook);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Библиотека";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_UpdateBook;
        private System.Windows.Forms.Button btn_DeleteBook;
        private System.Windows.Forms.Button btn_AddBook;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdb_SearchByPressName;
        private System.Windows.Forms.RadioButton rdb_SearchByCategory;
        private System.Windows.Forms.RadioButton rdb_SearchByTitle;
        private System.Windows.Forms.RadioButton rdb_SearchByAuthor;
    }
}

