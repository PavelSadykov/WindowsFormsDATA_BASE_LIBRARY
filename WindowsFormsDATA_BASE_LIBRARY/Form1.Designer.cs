namespace WindowsFormsDATA_BASE_LIBRARY
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
            this.SearchButton = new System.Windows.Forms.Button();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.resultDataGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.ShowPopularBooksButton = new System.Windows.Forms.Button();
            this.ShowNotPopularBooksButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(509, 12);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(132, 62);
            this.SearchButton.TabIndex = 0;
            this.SearchButton.Text = "ПОИСК";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // authorTextBox
            // 
            this.authorTextBox.Location = new System.Drawing.Point(224, 12);
            this.authorTextBox.Multiline = true;
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(260, 26);
            this.authorTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Укажите автора книги :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Укажите название книги:";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(224, 48);
            this.titleTextBox.Multiline = true;
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(260, 26);
            this.titleTextBox.TabIndex = 4;
            // 
            // resultDataGridView
            // 
            this.resultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultDataGridView.Location = new System.Drawing.Point(404, 144);
            this.resultDataGridView.Name = "resultDataGridView";
            this.resultDataGridView.Size = new System.Drawing.Size(237, 275);
            this.resultDataGridView.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(401, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Результаты поиска:";
            // 
            // ShowPopularBooksButton
            // 
            this.ShowPopularBooksButton.Location = new System.Drawing.Point(56, 90);
            this.ShowPopularBooksButton.Name = "ShowPopularBooksButton";
            this.ShowPopularBooksButton.Size = new System.Drawing.Size(100, 39);
            this.ShowPopularBooksButton.TabIndex = 11;
            this.ShowPopularBooksButton.Text = "Популярные книги";
            this.ShowPopularBooksButton.UseVisualStyleBackColor = true;
            this.ShowPopularBooksButton.Click += new System.EventHandler(this.ShowPopularBooksButton_Click);
            // 
            // ShowNotPopularBooksButton
            // 
            this.ShowNotPopularBooksButton.Location = new System.Drawing.Point(162, 90);
            this.ShowNotPopularBooksButton.Name = "ShowNotPopularBooksButton";
            this.ShowNotPopularBooksButton.Size = new System.Drawing.Size(103, 39);
            this.ShowNotPopularBooksButton.TabIndex = 12;
            this.ShowNotPopularBooksButton.Text = "Не популярные книги";
            this.ShowNotPopularBooksButton.UseVisualStyleBackColor = true;
            this.ShowNotPopularBooksButton.ContextMenuStripChanged += new System.EventHandler(this.ShowNotPopularBooksButton_ContextMenuStripChanged);
            this.ShowNotPopularBooksButton.Click += new System.EventHandler(this.ShowNotPopularBooksButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(56, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(209, 275);
            this.dataGridView1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ShowNotPopularBooksButton);
            this.Controls.Add(this.ShowPopularBooksButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.resultDataGridView);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.authorTextBox);
            this.Controls.Add(this.SearchButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.DataGridView resultDataGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ShowPopularBooksButton;
        private System.Windows.Forms.Button ShowNotPopularBooksButton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

