using BookStore_API.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore_API.Data
{
    public class BookDbContext : DbContext
    {
        public BookDbContext(DbContextOptions<BookDbContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
    }
}
