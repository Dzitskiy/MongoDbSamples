using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MongoDB.EntityFrameworkCore.Extensions;
using MongoDbEFProvider.Models;

namespace MongoDbEFProvider.DataAccess
{
    public class EfCoreMongoDbContext(
        DbContextOptions options,
        IOptions<BookStoreDatabaseSettings> bookStoreDatabaseSettings) 
        : DbContext(options)
    {
        public DbSet<Book> Books { get; init; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Book>()
                .ToCollection(bookStoreDatabaseSettings.Value.BooksCollectionName)
                .Property(x => x.Id).HasConversion<string>();
        }
    }

}
