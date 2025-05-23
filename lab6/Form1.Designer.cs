namespace lab6
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
            btnFetchBooks = new Button();
            listBoxBooks = new ListBox();
            txtAuthorName = new TextBox();
            txtBookTitle = new TextBox();
            btnAddBook = new Button();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            txtSearch = new TextBox();
            txtNewAuthor = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtNewTitle = new TextBox();
            txtBookId = new TextBox();
            btnSearch = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            progressBar = new ProgressBar();
            lblStatus = new Label();
            SuspendLayout();
            // 
            // btnFetchBooks
            // 
            btnFetchBooks.Location = new Point(121, 279);
            btnFetchBooks.Name = "btnFetchBooks";
            btnFetchBooks.Size = new Size(118, 23);
            btnFetchBooks.TabIndex = 0;
            btnFetchBooks.Text = "Fetch Books";
            btnFetchBooks.UseVisualStyleBackColor = true;
            btnFetchBooks.Click += btnFetchBooks_Click;
            // 
            // listBoxBooks
            // 
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.ItemHeight = 15;
            listBoxBooks.Location = new Point(34, 12);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(331, 244);
            listBoxBooks.TabIndex = 1;
            // 
            // txtAuthorName
            // 
            txtAuthorName.Location = new Point(415, 51);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(100, 23);
            txtAuthorName.TabIndex = 2;
            // 
            // txtBookTitle
            // 
            txtBookTitle.Location = new Point(415, 103);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(100, 23);
            txtBookTitle.TabIndex = 3;
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(430, 142);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(75, 23);
            btnAddBook.TabIndex = 4;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(444, 20);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 5;
            label1.Text = "Author";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(444, 85);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 6;
            label2.Text = "Title";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(639, 142);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 9;
            label4.Text = "NewAuthor";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(625, 303);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(100, 23);
            txtSearch.TabIndex = 8;
            // 
            // txtNewAuthor
            // 
            txtNewAuthor.Location = new Point(625, 169);
            txtNewAuthor.Name = "txtNewAuthor";
            txtNewAuthor.Size = new Size(100, 23);
            txtNewAuthor.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(654, 85);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 14;
            label5.Text = "NewTitle";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(654, 20);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 13;
            label6.Text = "BookID";
            // 
            // txtNewTitle
            // 
            txtNewTitle.Location = new Point(625, 103);
            txtNewTitle.Name = "txtNewTitle";
            txtNewTitle.Size = new Size(100, 23);
            txtNewTitle.TabIndex = 12;
            // 
            // txtBookId
            // 
            txtBookId.Location = new Point(625, 51);
            txtBookId.Name = "txtBookId";
            txtBookId.Size = new Size(100, 23);
            txtBookId.TabIndex = 11;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(639, 332);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 22);
            btnSearch.TabIndex = 15;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(639, 198);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 22);
            btnUpdate.TabIndex = 16;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(639, 226);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 22);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(639, 252);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 22);
            btnRefresh.TabIndex = 18;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(237, 383);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(278, 23);
            progressBar.TabIndex = 19;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(375, 355);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 15);
            lblStatus.TabIndex = 20;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblStatus);
            Controls.Add(progressBar);
            Controls.Add(btnRefresh);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSearch);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(txtNewTitle);
            Controls.Add(txtBookId);
            Controls.Add(label4);
            Controls.Add(txtSearch);
            Controls.Add(txtNewAuthor);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAddBook);
            Controls.Add(txtBookTitle);
            Controls.Add(txtAuthorName);
            Controls.Add(listBoxBooks);
            Controls.Add(btnFetchBooks);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFetchBooks;
        private ListBox listBoxBooks;
        private TextBox txtAuthorName;
        private TextBox txtBookTitle;
        private Button btnAddBook;
        private Label label1;
        private Label label2;
        private Label label4;
        private TextBox txtSearch;
        private TextBox txtNewAuthor;
        private Label label5;
        private Label label6;
        private TextBox txtNewTitle;
        private TextBox txtBookId;
        private Button btnSearch;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnRefresh;
        private ProgressBar progressBar;
        private Label lblStatus;
    }
}
