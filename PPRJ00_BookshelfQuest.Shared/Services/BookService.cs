using Microsoft.EntityFrameworkCore;
using PPRJ00_BookshelfQuest.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PPRJ00_BookshelfQuest.Items
{
    // Implementation of the IBookService interface using Entity Framework Core
    public class BookService : IBookService
    {
        private readonly BookDbContext _dbContext;

        public BookService(BookDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // Retrieve all books from the database
        public async Task<IEnumerable<Book>> GetAllBooksAsync()
        {
            return await _dbContext.Books.ToListAsync();
        }

        // Retrieve a book by its ID from the database
        public async Task<Book> GetBookByIdAsync(int bookId)
        {
            return await _dbContext.Books.FindAsync(bookId);
        }

        // Add a new book to the database
        public async Task AddBookAsync(Book book)
        {
            _dbContext.Books.Add(book);
            await _dbContext.SaveChangesAsync();
        }

        // Update an existing book in the database
        public async Task UpdateBookAsync(Book book)
        {
            _dbContext.Entry(book).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        // Delete a book from the database by ID
        public async Task DeleteBookAsync(int bookId)
        {
            var book = await _dbContext.Books.FindAsync(bookId);
            if (book != null)
            {
                _dbContext.Books.Remove(book);
                await _dbContext.SaveChangesAsync();
            }
        }

        // Count the number of books that have been read
        public async Task<int> GetBooksReadCountAsync()
        {
            return await _dbContext.Books
                .Where(b => b.ReadDate != null)
                .CountAsync();
        }
    }
}