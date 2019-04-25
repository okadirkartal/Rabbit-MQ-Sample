using System;

namespace Producer
{
    class Program
    { 
        private static Producer _producer;

        static void Main(string[] args)
        {
            _producer = new Producer(RabbitMQProvider.RabbitMQService.QUEUE_NAME, "Zdrastvuyte :)");

            Console.ReadKey();
        }
    }
}
