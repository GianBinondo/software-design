using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using static System.Reflection.Metadata.BlobBuilder;

namespace lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Asynchronous method to fetch books from the database
        public async Task<List<string>> GetBooksAsync()
        {
            using (var context = new BookstoreContext())
            {
                // Query the database asynchronously to get all books and their authors
                var books = await context.Books.Include(b => b.Author)
                    .Select(b => $"{b.Title} by {b.Author.Name}")
                    .ToListAsync();

                return books;
            }
        }


        private void btnFetchBooks_Click(object sender, EventArgs e)
        {
            // Fetch the books asynchronously
            var books = await GetBooksAsync();

            // Display the books in the ListBox
            listBoxBooks.DataSource = books;
        }

        // Asynchronous method to save a new book and author to the database
        public async Task SaveBookAsync(string bookTitle, string authorName)
        {
            using (var context = new BookstoreContext())
            {
                // Create new author and book objects
                var author = new Author { Name = authorName };
                var book = new Book { Title = bookTitle, Author = author };

                // Add the new author and book to the context
                context.Authors.Add(Author);
                context.Books.Add(book);

                // Save changes asynchronously
                await context.SaveChangesAsync();
            }
        }


        private void btnAddBook_Click(object sender, EventArgs e)
        {
            // Get input values from the TextBoxes
            var authorName = txtAuthorName.Text;
            var bookTitle = txtBookTitle.Text;

            // Save the new book and author asynchronously
            await SaveBookAsync(BookTitle, authorName);

            MessageBox.Show("Book and Author saved successfully!");
        }

        // Task 3

        // 1. Asynchronous Update Operation
        public async Task UpdateBookAsync(int bookId, string newTitle, string newAuthorName)
        {
            using (var context = new BookstoreContext())
            {
                var book = await context.Books
                    .Include(b => b.Author)
                    .FirstOrDefaultAsync(b => b.BookId == bookId);

                if (book != null)
                {
                    book.Title = newTitle;
                    book.Author.Name = newAuthorName;
                    await context.SaveChangesAsync();
                }
            }
        }

        // 2. Asynchronous Delete Operation
        public async Task DeleteBookAsync(int bookId)
        {
            using (var context = new BookstoreContext())
            {
                var book = await context.Books.FindAsync(bookId);
                if (book != null)
                {
                    context.Books.Remove(book);
                    await context.SaveChangesAsync();
                }
            }
        }

        // 3. Fetch data with progress reporting
        public async Task<List<string>> GetBooksWithProgressAsync(IProgress<int> progress)
        {
            using (var context = new BookstoreContext())
            {
                var totalBooks = await context.Books.CountAsync();
                var books = new List<string>();
                var batchSize = 10; // Process in batches for progress reporting

                for (int i = 0; i < totalBooks; i += batchSize)
                {
                    var batch = await context.Books
                        .Include(b => b.Author)
                        .OrderBy(b => b.Title)
                        .Skip(i)
                        .Take(batchSize)
                        .ToListAsync();

                    books.AddRange(batch.Select(b => $"{b.Title} by {b.Author.Name}"));

                    // Report progress
                    int percentComplete = (int)((i + batchSize) * 100.0 / totalBooks);
                    progress.Report(Math.Min(percentComplete, 100));
                }

                return books;
            }
        }

        // 4. Asynchronous Search
        public async Task<List<string>> SearchBooksAsync(string searchTerm)
        {
            using (var context = new BookstoreContext())
            {
                return await context.Books
                    .Include(b => b.Author)
                    .Where(b => b.Title.Contains(searchTerm))
                    .Select(b => $"{b.Title} by {b.Author.Name}")
                    .ToListAsync();
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBookId.Text, out int bookId))
            {
                await UpdateBookAsync(bookId, txtNewTitle.Text, txtNewAuthor.Text);
                MessageBox.Show("Book updated successfully!");
                await RefreshBookList();
            }
            else
            {
                MessageBox.Show("Please enter a valid Book ID");
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBookId.Text, out int bookId))
            {
                await DeleteBookAsync(bookId);
                MessageBox.Show("Book deleted successfully!");
                await RefreshBookList();
            }
            else
            {
                MessageBox.Show("Please enter a valid Book ID");
            }
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBookId.Text, out int bookId))
            {
                await DeleteBookAsync(bookId);
                MessageBox.Show("Book deleted successfully!");
                await RefreshBookList();
            }
            else
            {
                MessageBox.Show("Please enter a valid Book ID");
            }
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            await RefreshBookList();
        }

        private async Task RefreshBookList()
        {
            var progress = new Progress<int>(percent =>
            {
                progressBar.Value = percent;
                lblStatus.Text = $"Loading... {percent}%";
            });

            var books = await GetBooksWithProgressAsync(progress);
            listBoxBooks.DataSource = books;
            lblStatus.Text = "Ready";
        }
    }
}
