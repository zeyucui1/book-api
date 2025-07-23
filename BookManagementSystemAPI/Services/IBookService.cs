using BookManagementSystemAPI.Dto;
using BookManagementSystemAPI.Models;

namespace BookManagementSystemAPI.Services
{
    public interface IBookService
    {
        Task<Book> CreateBook(BookCreateRequest bookCreateRequest);
        Book GetBookById(int id);
        Book GetBookByName(string name);
        List<Book> GetBooks();
    }
}
