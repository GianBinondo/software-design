using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{

    public class Book
    {
        private string _title;
        private string _author;

        public string Title
        {
            get => _title;
            set => _title = string.IsNullOrWhiteSpace(value)
                ? throw new ArgumentException("Title cannot be empty")
                : value;
        }

        public string Author
        {
            get => _author;
            set => _author = string.IsNullOrWhiteSpace(value)
                ? throw new ArgumentException("Author cannot be empty")
                : value;
        }

        public virtual string GetInfo() => $"{Title} by {Author}";
    }

    public class Magazine : Book
    {
        private int _issueNumber;

        public int IssueNumber
        {
            get => _issueNumber;
            set => _issueNumber = value <= 0
                ? throw new ArgumentException("Issue number must be positive")
                : value;
        }

        public override string GetInfo() => $"{Title}-Issue{IssueNumber}";
    }

    public class EBook : Book
    {
        private int _fileSizeMB;

        public int FileSizeMB
        {
            get => _fileSizeMB;
            set => _fileSizeMB = value <= 0
                ? throw new ArgumentException("File size must be positive")
                : value;
        }

        public override string GetInfo() => $"{Title} by {Author} [PDF, {FileSizeMB}MB] (EBook)";
    }

    public class Textbook : Book
    {
        private string _subject;

        public string Subject
        {
            get => _subject;
            set => _subject = string.IsNullOrWhiteSpace(value)
                ? throw new ArgumentException("Subject cannot be empty")
                : value;
        }

        public override string GetInfo() => $"{Title} by {Author} (Subject: {Subject})";
    }
}
