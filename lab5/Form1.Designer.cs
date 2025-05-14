namespace lab5
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtAuthorName = new TextBox();
            txtBookTitle = new TextBox();
            btnAddBook = new Button();
            ListBoxBooks = new ListBox();
            SuspendLayout();
            // 
            // txtAuthorName
            // 
            txtAuthorName.Location = new Point(37, 48);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(100, 23);
            txtAuthorName.TabIndex = 0;
            // 
            // txtBookTitle
            // 
            txtBookTitle.Location = new Point(37, 88);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(100, 23);
            txtBookTitle.TabIndex = 1;
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(82, 141);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(75, 23);
            btnAddBook.TabIndex = 2;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // ListBoxBooks
            // 
            ListBoxBooks.FormattingEnabled = true;
            ListBoxBooks.ItemHeight = 15;
            ListBoxBooks.Location = new Point(322, 116);
            ListBoxBooks.Name = "ListBoxBooks";
            ListBoxBooks.Size = new Size(120, 94);
            ListBoxBooks.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ListBoxBooks);
            Controls.Add(btnAddBook);
            Controls.Add(txtBookTitle);
            Controls.Add(txtAuthorName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAuthorName;
        private TextBox txtBookTitle;
        private Button btnAddBook;
        private ListBox ListBoxBooks;
    }
}
