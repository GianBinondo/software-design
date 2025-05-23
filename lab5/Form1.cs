using Microsoft.EntityFrameworkCore; // For EF Core (or System.Data.Entity for EF6)
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Author
        {
            public int AuthorID { get; set; }
            public string Name { get; set; }
            public virtual ICollection<Book> Books { get; set; }
        }

        public class Book
        {
            public int BookID { get; set; }
            public string Title { get; set; }
            public int AuthorID { get; set; }
            public virtual Author Author { get; set; }
        }

        public void AddAuthorWithBook(string AuthorName, string bookTitle)
        {
            using (var context = new BookstoreContext())
            {
                var author = new Author { Name = AuthorName };
                var book = new Book { Title = bookTitle, Author = author };

                context.Authors.Add(author);
                context.Books.Add(book);
                context.SaveChanges();
            }
        }

        public List<string> GetBooksWithAuthors()
        {
            using (var context = new BookstoreContext())
            {
                var booksWithAuthors = context.Books
                    .Include(b => b.Author)
                    .Select(b => $"{b.Title} by {b.Author.Name}")
                    .ToList();

                return booksWithAuthors; // Return the results, not call recursively
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            var books = GetBooksWithAuthors();
            ListBoxBooks.DataSource = books;
        }

        public void UpdateBookAndAuthor(int bookId, string newTitle, string newAuthorName)
        {
            using (var context = new BookstoreContext())
            {
                var book = context.Books.Include(b => b.Author).FirstOrDefault(b => b.BookID == bookId);
                if (book != null)
                {
                    book.Title = newTitle;
                    book.Author.Name = newAuthorName;
                    context.SaveChanges(); // Save changes to the database
                }
            }
        }

        // Button click event to update book and author information
        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            int bookId = int.Parse(txtBookID.Text);
            UpdateBookAndAuthor(bookId, txtBookTitle.Text, txtAuthorName.Text);
            MessageBox.Show("Book and Author updated successfully.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Function to delete a book by BookID
        public void DeleteBook(int bookId)
        {
            using (var context = new BookstoreContext())
            {
                var book = context.Books.FirstOrDefault(b => b.BookID == bookId);
                if (book != null)
                {
                    context.Books.Remove(book);
                    context.SaveChanges();
                }
            }
        }

        // Button click event for deleting a book
        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBookID.Text, out int bookId))
            {
                DeleteBook(bookId);
                MessageBox.Show("Book deleted successfully.");
                // Refresh the book list
                var books = GetBooksWithAuthors();
                ListBoxBooks.DataSource = books;
            }
            else
            {
                MessageBox.Show("Please enter a valid Book ID.");
            }
        }

        // Function to search books by author name
        public List<string> SearchBooksByAuthor(string authorName)
        {
            using (var context = new BookstoreContext())
            {
                return context.Books
                    .Include(b => b.Author)
                    .Where(b => b.Author.Name.Contains(authorName))
                    .Select(b => $"{b.Title} by {b.Author.Name}")
                    .ToList();
            }
        }

        // Button click event for searching books by author
        private void btnSearchAuthor_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtAuthorName.Text))
            {
                var books = SearchBooksByAuthor(txtAuthorName.Text);
                ListBoxBooks.DataSource = books;
            }
            else
            {
                MessageBox.Show("Please enter an author name to search.");
            }
        }
    }
}
