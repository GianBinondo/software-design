using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestProject;

namespace BookManagementSystem.Tests
{
    [TestClass]
    public class BookTests
    {
        [TestMethod]
        public void TestPolymorphicBehavior()
        {
            Book[] books = {
                new Book { Title = "Generic Book", Author = "John Smith" },
                new Magazine { Title = "Tech Weekly", Author = "Jane Doe", IssueNumber = 12 },
                new EBook { Title = "Learn C#", Author = "Mark Jones", FileSizeMB = 5 },
                new Textbook { Title = "Advanced Math", Author = "Dr. Brown", Subject = "Mathematics" }
            };

            Assert.AreEqual("Generic Book by John Smith", books[0].GetInfo());
            Assert.AreEqual("Tech Weekly-Issue12", books[1].GetInfo());
            Assert.AreEqual("Learn C# by Mark Jones [PDF, 5MB] (EBook)", books[2].GetInfo());
            Assert.AreEqual("Advanced Math by Dr. Brown (Subject: Mathematics)", books[3].GetInfo());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Book_EmptyTitle_ThrowsException()
        {
            var book = new Book { Title = "", Author = "Valid Author" };
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Magazine_NegativeIssue_ThrowsException()
        {
            var magazine = new Magazine { Title = "Valid", Author = "Valid", IssueNumber = -1 };
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EBook_ZeroFileSize_ThrowsException()
        {
            var ebook = new EBook { Title = "Valid", Author = "Valid", FileSizeMB = 0 };
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Textbook_EmptySubject_ThrowsException()
        {
            var textbook = new Textbook { Title = "Valid", Author = "Valid", Subject = "" };
        }

        [TestMethod]
        public void Textbook_ValidSubject_Success()
        {
            var textbook = new Textbook { Title = "Valid", Author = "Valid", Subject = "Science" };
            Assert.AreEqual("Science", textbook.Subject);
        }
    }
}