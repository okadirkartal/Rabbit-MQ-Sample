using RabbitMQ.Client;
using RabbitMQProvider;
using System;
using System.Text;

namespace Producer
{
    public  class Producer
    {
        private readonly RabbitMQService _rabbitMQService;

        public Producer(string queueName, string message)
        {
            _rabbitMQService = new RabbitMQService();

            using (var connection = _rabbitMQService.GetRabbitMQConnection())
            {
                using (var channel = connection.CreateModel())
                {
                    channel.QueueDeclare(queueName, false, false, false, null);

                    channel.BasicPublish("", queueName, null, Encoding.UTF8.GetBytes(message));

                    Console.WriteLine($"{message}  is written on {queueName}");
                }
            }
        }
    }
}
