using BooksApi.Models;

namespace BooksApi.Services
{
    // For CRUD on books
    public class BookService
    {
        private List<Book> _books;

        public BookService()
        {
            _books = new List<Book>();
        }

        // To Add Book
        public void AddBook(Book book)
        {
            _books.Add(book);
        }

        // To Get All Books
        public List<Book> GetAll()
        {
            return _books;
        }

        // To Get Single Book
        public Book? GetBookById(int id)
        {
            return _books.Find(x => x.Id == id);
        }

        // To Update Book
        public bool UpdateBook(int id, Book updatedBook)
        {
            var index = _books.FindIndex(b => b.Id == id);
            if (index == -1)
                return false;

            _books[index] = updatedBook;
            return true;
        }

        // To Delete Book
        public bool DeleteBook(int id)
        {
            var book = _books.Find(b => b.Id == id);
            if (book == null)
                return false;

            _books.Remove(book);
            return true;
        }

    }
}
