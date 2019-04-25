using RabbitMQ.Client;

namespace RabbitMQProvider
{
    public  class RabbitMQService
    {
        private readonly string _hostName = "localhost";

        public static string QUEUE_NAME = "SAMPLEQUEUE";

        public IConnection GetRabbitMQConnection()
        {
            ConnectionFactory connectionFactory = new ConnectionFactory()
            {
                HostName = _hostName
            };
            return connectionFactory.CreateConnection();
        }
    }
}
