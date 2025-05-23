using static System.Reflection.Metadata.BlobBuilder;

namespace lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Set the number of records per page
        private const int pageSize = 10;
        private int currentPage = 1;

        // Asynchronous method to fetch a specific page of books
        public async Task<List<string>> GetBooksByPageAsync(int pageNumber)
        {
            using (var context = new BookstoreContext())
            {
                var books = await context.Books
                                         .Include(b => b.Author)
                                         .OrderBy(b => b.BookID)
                                         .Skip((pageNumber - 1) * pageSize)
                                         .Take(pageSize)
                                         .Select(b => $"{b.Title} by {b.Author.Name}")
                                         .ToListAsync();
                return books;
            }
        }

        private async void btnNextPage_Click(object sender, EventArgs e)
        {
            currentPage++;
            var books = await GetBooksByPageAsync(currentPage);
            listBoxBooks.DataSource = books;
            lblPageNumber.Text = $"Page {currentPage}";
        }

        private async void btnPrevPage_Click(object sender, EventArgs e)
        {
            currentPage--;
            var books = await GetBooksByPageAsync(currentPage);
            listBoxBooks.DataSource = books;
            lblPageNumber.Text = $"Page {currentPage}";
        }

        //Task2

        public async Task SaveBookwithHandlingAsync(string bookTitle, string authorName)
        {

            try
            {
                using (var context = new BookstoreContext())
                {
                    var author = new Author { Name = authorName };
                    var book = new Book { Title = bookTitle, Author = author };

                    context.Authors.Add(author);
                    context.Books.Add(book);

                    // Save changes asynchronously
                    await context.SaveChangesAsync();

                    MessageBox.Show("Book and Author saved successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

        }

        private async void btnAddBook_Click(object sender, EventArgs e)
        {
            var authorName = txtAuthorName.Text;
            var bookTitle = txtBookTitle.Text;

            await SaveBookwithHandlingAsync(bookTitle, authorName);
        }

        //Task 3

        public async Task ExportBooksAsync(string filePath)
        {
            var books = await GetBooksByPageAsync(currentPage);

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var book in books)
                {
                    await writer.WriteLineAsync(book);
                }
            }
        }

        private async void btnExportBooks_Click(object sender, EventArgs e)
        {

            var saveFileDialog = new SaveFileDialog()
            {
                Filter = "Text Files (-.txt)](-.txt",
                Title = "Save Book List"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                await ExportBooksAsync(filePath);
                MessageBox.Show("Books exported successfully!");
            }
        }

        //Task 4


        private async void btnSearch_Click(object sender, EventArgs e)
        {

            try
            {
                var searchTerm = txtSearch.Text;
                if (string.IsNullOrEmpty(searchTerm)) return;

                using (var context = new BookstoreContext())
                {
                    var results = await context.Books
                        .Include(b => b.Author)
                        .Where(b => b.Title.Contains(searchTerm))
                        .Select(b => $"{b.Title} by {b.Author.Name}")
                        .ToListAsync();

                    listBoxBooks.DataSource = results;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search error: " + ex.Message);
            }
        }

        private async void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                using (var dialog = new OpenFileDialog())
                {
                    dialog.Filter = "Text Files|*.txt";

                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        var lines = await File.ReadAllLinesAsync(dialog.FileName);

                        using (var context = new BookstoreContext())
                        {
                            foreach (var line in lines)
                            {
                                if (string.IsNullOrWhiteSpace(line)) continue;

                                var parts = line.Split(new[] { " by " }, StringSplitOptions.None);
                                if (parts.Length == 2)
                                {
                                    var author = new Author { Name = parts[1].Trim() };
                                    var book = new Book
                                    {
                                        Title = parts[0].Trim(),
                                        Author = author
                                    };
                                    context.Books.Add(book);
                                }
                            }
                            await context.SaveChangesAsync();
                        }
                        MessageBox.Show("Import completed!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Import error: {ex.Message}");
            }
        }
    }
}
