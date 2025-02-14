using Microsoft.EntityFrameworkCore;
using MongoDB.Bson;
using MongoDbEFProvider.Models;

namespace MongoDbEFProvider.DataAccess
{
    public class BookRepository
    {
        private readonly EfCoreMongoDbContext _context;

        public BookRepository(EfCoreMongoDbContext context)
        {
            _context = context;
        }

        public async Task<List<Book>> GetAsync() =>
            await _context.Books.ToListAsync();

        public async Task<Book?> GetAsync(string id) =>
            await _context.Books.FindAsync(id);

        public async Task CreateAsync(Book newBook)
        {
            newBook.Id = ObjectId.GenerateNewId().ToString();
            await _context.Books.AddAsync(newBook);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(string id, Book updatedBook)
        {
            if (id == updatedBook.Id)
            {
                var existingBook = await _context.Books.FindAsync(id);
                if (existingBook != null)
                {
                    existingBook.BookName = updatedBook.BookName;
                    existingBook.Price = updatedBook.Price;
                    existingBook.Category = updatedBook.Category;
                    existingBook.Author = updatedBook.Author;
                    
                    await _context.SaveChangesAsync();
                }
            }
        }

        public async Task RemoveAsync(string id)
        {
            var existingBook = await _context.Books.FindAsync(id);
            if (existingBook != null)
            {
                _context.Books.Remove(existingBook);
                await _context.SaveChangesAsync();
            }
        }
    }
}