using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FormationEF;

namespace FormationUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAuthor()
        {
            Author a = new Author();
            a.Id = 1;
            a.Name = "toto";
            Assert.
                AreEqual(1, a.Id);
        }
        [TestMethod]
        public void TestBook()
        {
            Book a = new Book {Id=1, Title="Samir",NbrPage=200 };
            Assert.AreEqual(1, a.Id);
        }
        [TestMethod]
        public void TestPublisher()
        {
            Book a = new Book { Id = 1, Title = ".NET", NbrPage = 400, Publisher = new Publisher {Id=2,Name="Publisher3" } };
            Assert.AreEqual(2, a.Publisher.Id);
        }
        [TestMethod]
        public void TestAuthor2()
        {
            Book book = new Book { Id = 5, Title = ".NET"};
            book.Authors.Add(new Author { Id=2, Name = "Samir" });
            Assert.AreEqual(1, book.Authors.Count);
        }
    }
}
