using BookLibraryAssignemnt;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GoodBookTitle()
        {
            Book book;
            book = new Book("The Book", "Jim", 100, "1234567890123");
            Assert.AreEqual(book.Title, "The Book");
        }

        [TestMethod]
        public void GoodBookPages()
        {
            Book book;
            book = new Book("The Book", "Jim", 100, "1234567890123");
            Assert.AreEqual(book.Pages, 100);
        }

        [TestMethod]
        public void GoodBookISBN()
        {
            Book book;
            book = new Book("The Book", "Jim", 100, "1234567890123");
            Assert.AreEqual(book.Isbn.Length, 13);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TitleIncorrect()
        {
            Book book = new Book("", "Jim", 100, "1234567890123");
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void PagesLessThan10()
        {
            Book book = new Book("Book", "Jim", 1, "1234567890123");
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void PagesMoreThan1000()
        {
            Book book = new Book("Book", "Jim", 1020, "1234567890123");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void IsbnIncorrect()
        {
            Book book = new Book("Book", "Jim", 100, "2");
        }
    }
}
