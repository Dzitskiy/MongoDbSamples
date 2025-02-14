using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace MongoDbEFProvider.Models
{
    public class Book
    {
        [BsonId]
        public string? Id { get; set; }

        [BsonElement("Name")]
        public string BookName { get; set; } = null!;

        public decimal Price { get; set; }

        public string Category { get; set; } = null!;

        public string Author { get; set; } = null!;
    }
}
