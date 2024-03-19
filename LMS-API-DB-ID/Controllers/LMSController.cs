using Microsoft.AspNetCore.Mvc;
using LMS_API_DB_ID.Repositories;
using LMS_API_DB_ID.Models;

namespace LMS_API_DB_ID.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LMSController : ControllerBase
    {
        private readonly IAddBookRepositorie _addBookRepositorie;
        private readonly IAddBookRepositorie _addBookRepositorie2;

        public LMSController(IAddBookRepositorie addBookRepositorie, IAddBookRepositorie addBookRepositorie2)
        {
            _addBookRepositorie = addBookRepositorie;
            _addBookRepositorie2 = addBookRepositorie2;
        }

        [HttpPost("")]
        public IActionResult AddBook([FromBody] LMSModel book)
        {
            _addBookRepositorie.AddBook(book); // Add book using first instance
            var books = _addBookRepositorie2.GetAllBooks(); // Get all books using secind instance
            return Ok(books);
        }

        [HttpGet("")]
        public IActionResult GetAllBooks()
        {
            var books = _addBookRepositorie.GetAllBooks();
            return Ok(books);
        }
    }
}
