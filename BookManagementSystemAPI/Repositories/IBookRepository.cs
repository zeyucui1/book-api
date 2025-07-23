using BookManagementSystemAPI.Models;

namespace BookManagementSystemAPI.Repositories
{
    public interface IBookRepository
    {
        Task<Book> CreateBook(Book book);
        List<Book> GetAllBooks();
        Book GetBookById(int id);
        Book GetBookByName(string name);
    }
}
