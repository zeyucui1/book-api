using BookManagementSystemAPI.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace BookManagementSystemAPI.Data
{
    public class MongoDbContext
    {
        private readonly IMongoDatabase _database;
        private readonly string BookCollectionName;

        public MongoDbContext(IOptions<MongoDbSettings> mongdoDbSettings)
        {
            var client = new MongoClient(mongdoDbSettings.Value.ConnectionString);
            _database = client.GetDatabase(mongdoDbSettings.Value.DatabaseName);
            BookCollectionName = mongdoDbSettings.Value.BookEventCollectionName;
            BookEvents = _database.GetCollection<BookEvent>(BookCollectionName);
        }

        public virtual IMongoCollection<BookEvent> BookEvents { get; set; }
    }
}
