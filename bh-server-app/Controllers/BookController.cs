using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using bh_server_app.DTOs;
using bh_server_app.Models;
using bh_server_app.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace bh_server_app.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;
        private readonly IMapper _mapper;

        public BookController(IBookService bookService, IMapper mapper)
        {
            _bookService = bookService;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBook(int id)
        {
            var book = await _bookService.GetBookById(id);
            if (book == null)
                return NotFound();

            return Ok(book);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBooks()
        {
            var books = await _bookService.GetAllBooks();
            return Ok(books);
        }

        [HttpPost]
        public async Task<Book> CreateBook(BookDTO bookDTO)
        {
            return await _bookService.CreateBook(bookDTO);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBook(BookDTO bookDTO)
        {
            var updatedBook = await _bookService.UpdateBook(bookDTO);
            if (updatedBook == null)
                return NotFound();

            return Ok(updatedBook);
        }

        [HttpPut("Active/{bookId}")]
        public async Task<BookDTO> ChangeActive(int bookId)
        {
            return await _bookService.ChangeActive(bookId);
        }

        [HttpDelete("{id}")]
        public async void DeleteBook(int id)
        {
            await _bookService.DeleteBook(id);
        }
    }
}