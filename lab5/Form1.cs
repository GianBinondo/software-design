using System.Data.Entity;
using System.Xml.Linq;

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
                // Create a new author
                var author = new Author { Name = AuthorName };
                // Create a new book and associate it with the author
                var book = new Book { Title = bookTitle, Author = author };

                context.Authors.Add(author);  // Add the author to the context
                context.Books.Add(book);  // Add the book to the context
                context.SaveChanges();  // Save all changes to the database
            }
        }

        public List<string> GetBooksWithAuthors()
        {
            using (var context = new BookstoreContext())
            {
                // Use Entity Framework's Include method to load authors with books
                var bookswidthAuthors = context.Books
                    .Include(b => b.Author)
                    .Select(b => $"{b.Title} by {b.Author.Name}")
                    .ToList();

                return GetBooksWithAuthors();
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            var books = GetBooksWithAuthors();
            ListBoxBooks.DataSource = books; 
        }
    }
}
