using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Bookstore.Models;

namespace Bookstore.Models
{
    public class BookstoreContext : DbContext
    {
        public BookstoreContext (DbContextOptions<BookstoreContext> options)
            : base(options)
        {
        }

        public DbSet<Bookstore.Models.Book> Book { get; set; } = default!;

        public DbSet<Bookstore.Models.BookGenre> BookGenre { get; set; }

        public DbSet<Bookstore.Models.Author>? Author { get; set; }

        public DbSet<Bookstore.Models.Genre>? Genre { get; set; }

        public DbSet<Bookstore.Models.Review>? Review { get; set; }

        public DbSet<Bookstore.Models.UserBook>? UserBook { get; set; }
    }
}
