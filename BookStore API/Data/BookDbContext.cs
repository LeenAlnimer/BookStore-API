using Microsoft.EntityFrameworkCore;
using BookStore_API.Models;

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
