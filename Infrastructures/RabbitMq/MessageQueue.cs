using System;
using System.Text;
using MongoDb.Models;
using Newtonsoft.Json;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace RabbitMq
{
    public class MessageQueue
    {
        private const string QueueName = "topicQueue";

        public void Publish(string message)
        {
            var factory = new ConnectionFactory()
            {
                HostName = "localhost",
                Port = 5672,
                UserName = "guest",
                Password = "guest"
            };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: QueueName,
                    durable: false,
                    exclusive: false,
                    autoDelete: true,
                    arguments: null);

                var body = Encoding.UTF8.GetBytes(message);

                channel.BasicPublish(exchange: "",
                    routingKey: QueueName,
                    basicProperties: null,
                    body: body);
            }
        }

        public void Subscribe(Action<ForumTopic> action)
        {
            Console.WriteLine("starting consumption");
            var factory = new ConnectionFactory()
            {
                HostName = "localhost",
                Port = 5672,
                UserName = "guest",
                Password = "guest"
            };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: QueueName,
                    durable: false,
                    exclusive: false,
                    autoDelete: true,
                    arguments: null);

                var consumer = new EventingBasicConsumer(channel);

                consumer.Received += (model, ea) =>
                {
                    var body = ea.Body;

                    var message = Encoding.UTF8.GetString(body);

                    var topic = JsonConvert.DeserializeObject<ForumTopic>(message);

                    action(topic);
                };
                channel.BasicConsume(QueueName, true, consumer);

                Console.WriteLine("Done.");
                Console.ReadLine();
            }
        }
    }
}
