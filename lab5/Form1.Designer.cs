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
            txtBookID = new TextBox();
            btnUpdateBook = new Button();
            btnSearch = new Button();
            txtBoxSearch = new TextBox();
            btnDelete = new Button();
            txtBoxDelete = new TextBox();
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
            btnAddBook.Location = new Point(47, 117);
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
            ListBoxBooks.Location = new Point(260, 46);
            ListBoxBooks.Name = "ListBoxBooks";
            ListBoxBooks.Size = new Size(445, 319);
            ListBoxBooks.TabIndex = 3;
            // 
            // txtBookID
            // 
            txtBookID.Location = new Point(37, 187);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(100, 23);
            txtBookID.TabIndex = 4;
            // 
            // btnUpdateBook
            // 
            btnUpdateBook.Location = new Point(47, 231);
            btnUpdateBook.Name = "btnUpdateBook";
            btnUpdateBook.Size = new Size(75, 23);
            btnUpdateBook.TabIndex = 5;
            btnUpdateBook.Text = "Update";
            btnUpdateBook.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(47, 310);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtBoxSearch
            // 
            txtBoxSearch.Location = new Point(37, 269);
            txtBoxSearch.Name = "txtBoxSearch";
            txtBoxSearch.Size = new Size(100, 23);
            txtBoxSearch.TabIndex = 6;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(47, 396);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // txtBoxDelete
            // 
            txtBoxDelete.Location = new Point(37, 352);
            txtBoxDelete.Name = "txtBoxDelete";
            txtBoxDelete.Size = new Size(100, 23);
            txtBoxDelete.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(txtBoxDelete);
            Controls.Add(btnSearch);
            Controls.Add(txtBoxSearch);
            Controls.Add(btnUpdateBook);
            Controls.Add(txtBookID);
            Controls.Add(ListBoxBooks);
            Controls.Add(btnAddBook);
            Controls.Add(txtBookTitle);
            Controls.Add(txtAuthorName);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAuthorName;
        private TextBox txtBookTitle;
        private Button btnAddBook;
        private ListBox ListBoxBooks;
        private TextBox txtBookID;
        private Button btnUpdateBook;
        private Button btnSearch;
        private TextBox txtBoxSearch;
        private Button btnDelete;
        private TextBox txtBoxDelete;
    }
}
