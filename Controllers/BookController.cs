using Models;

namespace Controllers
{
    public class BookController
    {
        public Book CreateBook(string t, string a)
        {
            Book book = new();
            book.Title = t;
            book.Author = a;
            book.ID = Guid.NewGuid();

            return book;
        }
    }
}