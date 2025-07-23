using BookManagementSystemAPI.Data;
using BookManagementSystemAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BookManagementSystemAPI.Repositories
{
    public class UNSWBookRepository : IBookRepository
    {
        private readonly BookDbContext _dbContext;
        public UNSWBookRepository(BookDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Book> CreateBook(Book book)
        {
            try
            {
                _dbContext.Books.Add(book);
                _dbContext.SaveChanges();

                //question? newBook.Id is still null or not here ?
                return book;
            }
            catch (DbUpdateException dbex)
            {
                Console.WriteLine($"DB save error : {dbex.Message}");
                throw;
            }

            catch (System.Exception ex)
            {
                Console.WriteLine($"Unknown error : {ex.Message}");
                throw;
            }
        }

        public List<Book> GetAllBooks()
        {
            return _dbContext.Books.ToList();
        }

        public Book GetBookById(int id)
        {
            throw new NotImplementedException();
        }

        public Book GetBookByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
