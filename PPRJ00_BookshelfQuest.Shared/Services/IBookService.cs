using System.Collections.Generic;
using System.Threading.Tasks;

namespace PPRJ00_BookshelfQuest.Items
{
    // Interface for book operations
    public interface IBookService
    {
        Task<IEnumerable<Book>> GetAllBooksAsync(); // Retrieve all books asynchronously
        Task<Book> GetBookByIdAsync(int bookId); // Retrieve a book by ID asynchronously
        Task AddBookAsync(Book book); // Add a new book asynchronously
        Task UpdateBookAsync(Book book); // Update an existing book asynchronously
        Task DeleteBookAsync(int bookId); // Delete a book by ID asynchronously
        Task<int> GetBooksReadCountAsync(); // Get the count of read books asynchronously
    }
}
