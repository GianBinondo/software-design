using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject

{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPolymorphism_GetInfo_Method()
        {
            Book[] books = new Book[]
            {
                new Book { Title = "Generic Book", Author = "John Smith" },
                new Magazine { Title = "Tech Weekly", Author = "Jane Doe", IssueNumber = 12 },
                new EBook { Title = "Learn C#", Author = "Mark Jones", FileSizeMB = 5 }
            };

            Assert.AreEqual("Generic Book by John Smith", books[0].GetInfo());
            Assert.AreEqual("Tech Weekly-Issue12", books[1].GetInfo());
            Assert.AreEqual("Learn C# by Mark Jones [PDF, 5MB] (EBook)", books[2].GetInfo());
        }
    }
}