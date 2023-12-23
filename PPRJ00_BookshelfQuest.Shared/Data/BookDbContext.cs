using Microsoft.EntityFrameworkCore;
using PPRJ00_BookshelfQuest.Items;

namespace PPRJ00_BookshelfQuest.Data
{
    // Database context class for books
    public class BookDbContext : DbContext
    {
        public BookDbContext(DbContextOptions options) : base(options)
        {
        }

        // DbSet for the Book entity
        public DbSet<Book> Books { get; set; }
    }
}
