using BookManagementSystemAPI.Data;
using BookManagementSystemAPI.Dto;
using BookManagementSystemAPI.Models;
using BookManagementSystemAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookManagementSystemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;
        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        /// <summary>
        /// Get book by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult GetBookById(int id)
        { 
            Book book = _bookService.GetBookById(id);
            return Ok(book);
        }

        [HttpGet()]
        public IActionResult GetBooks()
        {
            List<Book> books = _bookService.GetBooks();
            return Ok(books);
        }

        //[HttpGet("{name}")]
        //public IActionResult GetBookByName(string name)
        //{
        //    List<Book> matchedBooks = _dbContext.Books.Where(x => x.Name == name).ToList();
        //    return Ok(matchedBooks);
        //}

        [HttpPost]
        //Model binding
        //json format to pass the model from client side to backend api
        //  { 
        //      "Name":"nice book",
        //      "description":"test"
        //
        //   }
        public async Task<IActionResult> CreateBook([FromBody] BookCreateRequest book)
        {
            Book newBook = await _bookService.CreateBook(book);
            return StatusCode(201, newBook);
        }

        //[HttpGet]
        //[Route("GetBookByDescription")]
        //public IActionResult GetBookByDescription([FromQuery] string description)
        //{
        //    List<Book> matchedBooks = _dbContext.Books.Where(x => x.Description == description).ToList();
        //    return Ok(matchedBooks);
        //}
    }
}
