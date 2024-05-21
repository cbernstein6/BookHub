using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bh_server_app.DTOs;
using bh_server_app.Models;

namespace bh_server_app.Services.Interface
{
    public interface IBookService
    {
        Task<BookDTO> GetBookById(int id);
        Task<IEnumerable<BookDTO>> GetAllBooks();
        Task<Book> CreateBook(BookDTO bookDTO);
        Task<BookDTO> UpdateBook(BookDTO bookDTO);
        Task<BookDTO> ChangeActive(int bookId);
        Task DeleteBook(int id);
    }
}