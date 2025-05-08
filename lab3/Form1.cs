using System.Net;
using static lab3.Form1;

namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Book
        {
            public string? Title { get; set; }
            public string? Author { get; set; }

            public virtual string GetInfo()
            {
                return $"{Title} by {Author}";
            }
        }

        public class Magazine : Book
        {
            public int IssueNumber { get; set; }

            public override string GetInfo()
            {
                return $"{Title}-Issue{IssueNumber}";
            }
        }

        public class EBook : Book
        {
            public string? Format { get; set; }
            public double FileSizeMB { get; set; }

            public override string GetInfo()
            {
                return $"{Title} by {Author} [{Format}, {FileSizeMB}MB] (EBook)";
            }
        }

        public class TextBook : Book
        {
            public int GradeLevel { get; set; }
            public string? Subject { get; set; }

            public override string GetInfo()
            {
                return $"{Title} by {Author} [{Subject} textbook for grade {GradeLevel}]";
            }

        }

        public class AudioBook : Book
        {
            public string? Narrator { get; set; }
            public TimeSpan Duration { get; set; }

            public override string GetInfo()
            {
                return $"{Title} by {Author} [Narrated by {Narrator}, {Duration.TotalHours:0.0} hours]";
            }
        }

        private void ProcessBooks(Book[] books)
        {
            listBoxBooks.Items.Clear();
            foreach (var book in books)
            {
                listBoxBooks.Items.Add(book.GetInfo());
            }
        }

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            Book[] library = new Book[]
            {
                new Book { Title = " C# Programming", Author = "John Smith"},
                new Book { Title = "Deep Rock Galactic", Author = "Karl" },
                new Magazine { Title = "Tech Weekly", Author = "John Doe", IssueNumber = 12 },
                new EBook { Title = "Invincible", Author = "Robert kirkman", Format = "PDF", FileSizeMB = 3000 },
                new Magazine { Title = "Yeah Science! ", Author = "Walter White", IssueNumber = 102 },
                new EBook { Title = "Flint and Steel", Author = "Steve", Format = "EPUB", FileSizeMB = 8.2 },
                new Magazine {Title = "The art of war", Author ="Sun Tzu", IssueNumber = 13},
                new TextBook { Title = "Advanced Mathematics", Author = "Dr. Sheldon Cooper", Subject = "Math", GradeLevel = 12 },
                new AudioBook { Title = "Dying Light", Author = "Kyle Crane", Narrator = "Rick Sanchez", Duration = TimeSpan.FromHours(50) },
                new TextBook { Title = "Rizz Fundamentals", Author = "Dr. Dolph Rizzler", Subject = "Biology", GradeLevel = 11 },
                new AudioBook { Title = "The Hood", Author = "Barack Obama", Narrator = "Barack Obama", Duration = TimeSpan.FromHours(19) },
                new Book { Title = " Toffe The Dog", Author = " Brownie"}
            };
            ProcessBooks(library); // Process them polymorphically
        }

        private void listBoxBooks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
