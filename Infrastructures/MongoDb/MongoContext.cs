using MongoDb.Models;
using MongoDB.Driver;

namespace MongoDb
{
    public class MongoContext
    {
        private readonly IMongoDatabase _database;

        public MongoContext()
        {
            var client = new MongoClient("mongodb://localhost:27017");

            _database = client.GetDatabase("ForumDb");
        }

        public IMongoCollection<ForumTopic> ForumTopics => _database.GetCollection<ForumTopic>("ForumTopic");
    }
}