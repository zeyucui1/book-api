using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BookManagementSystemAPI.Models
{
    public class BookEvent
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public int BookId { get; set; }

        public string EventNote { get; set; }
    }
}
