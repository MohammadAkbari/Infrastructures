using System;
using System.Text;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace EmitLog
{
    class EmitLog
    {
        public static void Main(string[] args)
        {
            //var factory = new ConnectionFactory()
            //{
            //    HostName = "localhost",
            //    Port = 5672,
            //    UserName = "guest",
            //    Password = "guest"
            //};
            //using (var connection = factory.CreateConnection())
            //using (var channel = connection.CreateModel())
            //{
            //    channel.QueueDeclare(queue: "niftyqueue",
            //        durable: false,
            //        exclusive: false,
            //        autoDelete: false,
            //        arguments: null);

            //    var body = Encoding.UTF8.GetBytes("Hello World!");

            //    channel.BasicPublish(exchange: "",
            //        routingKey: "niftyqueue",
            //        basicProperties: null,
            //        body: body);
            //}


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
                channel.QueueDeclare(queue: "niftyqueue",
                    durable: false,
                    exclusive: false,
                    autoDelete: false,
                    arguments: null);

                var consumer = new EventingBasicConsumer(channel);
                consumer.Received += (model, ea) =>
                {
                    var body = ea.Body;
                    var message = Encoding.UTF8.GetString(body);
                    Console.WriteLine($"Creating user {message}");
                };
                channel.BasicConsume("niftyqueue", true, consumer);

                Console.WriteLine("Done.");
                Console.ReadLine();
            }
        }
    }
}
