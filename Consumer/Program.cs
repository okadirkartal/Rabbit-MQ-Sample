﻿using System;

namespace Consumer
{
    class Program
    { 
        private static Consumer _consumer;
        static void Main(string[] args)
        {
            _consumer = new  Consumer(RabbitMQProvider.RabbitMQService.QUEUE_NAME);
            Console.ReadKey();
        }
    }
}
