using System;
namespace Laba12
{
    class Container
    {
        private List<Book> books;
        public Container(List<Book> books)
        {
            this.books = books;
        }
        public List<Book> SortName()
        {
            return books.OrderBy(book => book.Name).ToList();
        }
        public List<Book> SortAuthor()
        {
            return books.OrderBy(book => book.Author).ToList();
        }
        public List<Book> SortPublisher()
        {
            return books.OrderBy(book => book.Publisher).ToList();
        }

    }
}

