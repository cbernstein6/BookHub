using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bh_server_app.Models;
using Microsoft.EntityFrameworkCore;

namespace bh_server_app
{
    public class BookDbContext : DbContext
    {
        public BookDbContext(DbContextOptions<BookDbContext> options) : base(options) 
        {}
        public DbSet<Book> Books => Set<Book>();
        public DbSet<User> Users { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Discussion> Discussions { get; set; }


    }
}