using BookManagementSystemAPI.Data;
using BookManagementSystemAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BookManagementSystemAPI.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly BookDbContext _dbContext;
        public BookRepository(BookDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        public async Task<Book> CreateBook(Book book)
        {
            try
            {
                await _dbContext.Books.AddAsync(book);
                await _dbContext.SaveChangesAsync();

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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="System.Exception"></exception>
        public Book GetBookById(int id)
        {
            Book? book = _dbContext.Books.FirstOrDefault(b => b.Id == id);

            if (book == null)
            {
                throw new System.Exception("Book not found");
            }
            return book;
        }

        public Book GetBookByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
