using AutoMapper;
using bh_server_app.DTOs;
using bh_server_app.Models;
using bh_server_app.Services.Interface;
using Microsoft.EntityFrameworkCore;

namespace bh_server_app.Services.Services
{
    public class BookService : IBookService
    {
        private readonly BookDbContext _context;
        private readonly IMapper _mapper;

        public BookService(BookDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<BookDTO> GetBookById(int id)
        {
            Console.WriteLine(_context.Books.Find(id));
            Book b = _context.Books.Find(id);
            BookDTO dto = _mapper.Map<BookDTO>(b);

            return await Task.FromResult(dto);
        }

        public async Task<IEnumerable<BookDTO>> GetAllBooks()
        {
            var books = await _context.Books.Where(b => b.IsActive).ToListAsync();
            return _mapper.Map<IEnumerable<BookDTO>>(books);
        }

        public async Task<IEnumerable<BookDTO>> GetBooksBySeries(string title)
        {
            IEnumerable<Book> books = _context.Books.Where(x => x.Series == title).ToList();
            return _mapper.Map<IEnumerable<BookDTO>>(books);
        }

        public async Task<Book> CreateBook(BookDTO bookDTO)
        {   Console.WriteLine("Working");
            var book = _mapper.Map<Book>(bookDTO);
            _context.Books.Add(book);
            Console.WriteLine("Working2");
            await _context.SaveChangesAsync();
            return book;
        }

        public async Task<BookDTO> UpdateBook(BookDTO bookDTO)
        {
            var book = await _context.Books.FindAsync(bookDTO.Id);
            if (book == null)
                return null;

            _mapper.Map(bookDTO, book);
            await _context.SaveChangesAsync();
            return _mapper.Map<BookDTO>(book);
        }
        public async Task<BookDTO> ChangeActive(int bookId)
        {
            
            Book book = await _context.Books.FindAsync(bookId);
            
            book.IsActive =!book.IsActive;
            await _context.SaveChangesAsync();
            
            return _mapper.Map<BookDTO>(book);
        }

        public void DeleteBook(int id)
        {
            var book = _context.Books.Find(id);
            if (book != null)
            {
                _context.Books.Remove(book);
                _context.SaveChanges();
            }
        }
    }
}