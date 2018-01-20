using AutoMapper;

namespace ConsoleApp
{
    public class ForumTopicProfile : Profile
    {
        public ForumTopicProfile()
        {
            CreateMap<MongoDb.Models.ForumTopic, SqlServer.Models.ForumTopic>();
        }
    }
}