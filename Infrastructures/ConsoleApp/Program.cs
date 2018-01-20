using System;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using MongoDb;
using Newtonsoft.Json;
using RabbitMq;
using SqlServer;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now.ToString(CultureInfo.InvariantCulture));

            Console.WriteLine("Select: r for Read, w for Write, rw for ReadWrite:");
            var select = Console.ReadLine();

            if (select.Contains("r"))
            {
                ReaderRunner(50);
            }

            if (select.Contains("w"))
            {
                WriterRunner(10);
            }

            Console.ReadKey();
        }

        private static void WriterRunner(int threadCount)
        {
            var threads = new Thread[threadCount];
            for (var i = 0; i < threadCount; i++)
            {
                threads[i] = new Thread(Writer)
                {
                    IsBackground = true,
                    Name = nameof(Reader) + i
                };

                threads[i].Start();
            }
        }

        private static void ReaderRunner(int threadCount)
        {
            var threads = new Thread[threadCount];
            for (var index = 0; index < threadCount; index++)
            {
                var fromPage = index * 100;
                var toPage = fromPage + 100;

                threads[index] = new Thread(() => Reader(fromPage, toPage))
                {
                    IsBackground = true,
                    Name = nameof(Reader) + index
                };

                threads[index].Start();
            }
        }

        private static void Writer()
        {
            while (true)
            {
                var forumTopicRepository = new ForumTopicRepository();

                var messageQueue = new MessageQueue();

                messageQueue.Subscribe(forumTopicRepository.Add);
            }
        }

        private static void Reader(int fromPage, int toPage)
        {
            var page = fromPage;

            var messageQueue = new MessageQueue();

            while (true)
            {
                page++;
                if (page == toPage)
                {
                    break;
                }

                var forumPostQueryService = new ForumPostQueryService();

                var items = forumPostQueryService.GetList(page);

                if (!items.Any())
                {
                    break;
                }

                foreach (var item in items)
                {
                    var topic = Convert(item);

                    var message = JsonConvert.SerializeObject(topic);

                    messageQueue.Publish(message);
                }
            }

            Console.WriteLine("Reader Finished");
        }

        static MongoDb.Models.ForumTopic Convert(SqlServer.Models.ForumTopic input)
        {
            var output = new MongoDb.Models.ForumTopic
            {
                Id = input.ForumTopicId,
                Subject = input.Subject,
                CreatedOn = input.CreatedOn,
                UpdatedOn = input.UpdatedOn,
                UserId = input.UserId,
                Deleted = input.Deleted,
                ForumTopicState = input.ForumTopicState,
                LastRepliedOn = input.LastRepliedOn,
                LastReplyId = input.LastReplyId,
                OpenCloseState = input.OpenCloseState,
                LikeCount = input.LikeCount,
                ReportCount = input.ReportCount,
                ShowInAllForum = input.ShowInAllForum,
                Sticky = input.Sticky,
                ViewCount = input.ViewCount
            };

            return output;
        }
    }
}
