using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bh_server_app.Tests
{
    public class BookServicesTests
    {
        private Mock<DbSet<Book>> mockDbSet;
        private Mock<BookDbContext> mockContext;
        private Mock<IMapper> mockMapper;
        private BookService bookService;

        public BookServicesTests()
        {
            mockDbSet = new Mock<DbSet<Book>>();
            mockContext = new Mock<BookDbContext>();
            mockMapper = new Mock<IMapper>();

            // mockcontext setup
            

            bookService = new BookService(mockContext.Object, mockMapper.Object);
        }
    }
}