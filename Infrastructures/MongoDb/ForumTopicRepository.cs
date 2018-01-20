using MongoDb.Models;

namespace MongoDb
{
    public class ForumTopicRepository
    {
        private readonly MongoContext _dbContext = null;

        public ForumTopicRepository()
        {
            _dbContext = new MongoContext();
        }

        public void Add(ForumTopic item)
        {
            _dbContext.ForumTopics.InsertOne(item);
        }
    }
}
