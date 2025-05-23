using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }

    public class Author
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
