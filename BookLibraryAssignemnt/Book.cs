using System;

namespace BookLibraryAssignemnt
{
    public class Book
    {
        private string _name;
        /// <summary>
        /// The title of the book
        /// </summary>
        public string Title
        {
            get { return _name; }
        }

        private string _author;
        /// <summary>
        /// The author of the book
        /// </summary>
        public string Author
        {
            get { return _author; }
        }

        private int _pages;
        /// <summary>
        /// The number of pages in the book
        /// </summary>
        public int Pages
        {
            get { return _pages; }
        }

        private string _isbn;
        /// <summary>
        /// The isbn of the book
        /// </summary>
        public string Isbn
        {
            get { return _isbn; }
        }

        public Book(string title,string author,int pages,string isbn)
        {
            if (title.Length < 2)
                throw new ArgumentOutOfRangeException("Minimum 2 characters required");
            if (pages < 10 || pages > 1000)
                throw new ArgumentOutOfRangeException("it should habe between 10 and 1000 pages");
            if (isbn.Length != 13)
                throw new ArgumentOutOfRangeException("Isbn shoudl have 13 characters");
            _name = title;
            _author = author;
            _pages = pages;
            _isbn = isbn;
        }




    }
}
