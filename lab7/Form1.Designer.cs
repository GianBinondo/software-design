namespace lab7
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
            lblPageNumber = new Label();
            btnNextPage = new Button();
            btnPrevPage = new Button();
            listBoxBooks = new ListBox();
            btnAddBook = new Button();
            btnExportBooks = new Button();
            txtSearch = new TextBox();
            btnImport = new Button();
            btnSearch = new Button();
            SuspendLayout();
            // 
            // lblPageNumber
            // 
            lblPageNumber.AutoSize = true;
            lblPageNumber.Location = new Point(380, 364);
            lblPageNumber.Name = "lblPageNumber";
            lblPageNumber.Size = new Size(38, 15);
            lblPageNumber.TabIndex = 0;
            lblPageNumber.Text = "label1";
            // 
            // btnNextPage
            // 
            btnNextPage.Location = new Point(445, 387);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(124, 36);
            btnNextPage.TabIndex = 1;
            btnNextPage.Text = "Next";
            btnNextPage.UseVisualStyleBackColor = true;
            // 
            // btnPrevPage
            // 
            btnPrevPage.Location = new Point(227, 387);
            btnPrevPage.Name = "btnPrevPage";
            btnPrevPage.Size = new Size(124, 36);
            btnPrevPage.TabIndex = 2;
            btnPrevPage.Text = "Prev";
            btnPrevPage.UseVisualStyleBackColor = true;
            // 
            // listBoxBooks
            // 
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.ItemHeight = 15;
            listBoxBooks.Location = new Point(241, 12);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(342, 259);
            listBoxBooks.TabIndex = 3;
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(276, 314);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(75, 23);
            btnAddBook.TabIndex = 4;
            btnAddBook.Text = "AddBook";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // btnExportBooks
            // 
            btnExportBooks.Location = new Point(436, 314);
            btnExportBooks.Name = "btnExportBooks";
            btnExportBooks.Size = new Size(79, 23);
            btnExportBooks.TabIndex = 5;
            btnExportBooks.Text = "ExportBooks";
            btnExportBooks.UseVisualStyleBackColor = true;
            btnExportBooks.Click += btnExportBooks_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(55, 38);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(100, 23);
            txtSearch.TabIndex = 6;
            // 
            // btnImport
            // 
            btnImport.Location = new Point(121, 83);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(75, 23);
            btnImport.TabIndex = 7;
            btnImport.Text = "Import";
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += btnImport_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(21, 83);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 8;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSearch);
            Controls.Add(btnImport);
            Controls.Add(txtSearch);
            Controls.Add(btnExportBooks);
            Controls.Add(btnAddBook);
            Controls.Add(listBoxBooks);
            Controls.Add(btnPrevPage);
            Controls.Add(btnNextPage);
            Controls.Add(lblPageNumber);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPageNumber;
        private Button btnNextPage;
        private Button btnPrevPage;
        private ListBox listBoxBooks;
        private Button btnAddBook;
        private Button btnExportBooks;
        private TextBox txtSearch;
        private Button btnImport;
        private Button btnSearch;
    }
}
