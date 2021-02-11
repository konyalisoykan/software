using System;
using System.Collections.Generic;
using Confluent.Kafka;


namespace KioskConsumer
{
    class Program
    {
      
        static void Main(string[] args)
        {

            Consumerclass _consumerclass = new Consumerclass();

           
            Console  .WriteLine("Kod giriniz");
            while (true)
            {
                string _kod = Console.ReadLine();
                if (_kod == "1")
                {
                 string _result=   _consumerclass.Read();
                    Console.WriteLine(_result);
                }
            }
        }


      
        /*
        public static  void Read()
        {
            bool isCancelled = false;
            Console.WriteLine("Hello World!");
            var config = new ConsumerConfig
            {
                BootstrapServers = "localhost:9092",
                GroupId = "ConsumerGroup1",
                AutoOffsetReset = AutoOffsetReset.Earliest,
                EnableAutoCommit = false
            };
            Console.CancelKeyPress += (_, e) => {
                e.Cancel = true;
                isCancelled = true;
            };
            using (var consumer = new ConsumerBuilder<string, string>(config).Build())
            {
                consumer.Subscribe("RequestTicket");
                while (!isCancelled)
                {
                    int cancellationToken = 1000;
                    var consumeResult = consumer.Consume(cancellationToken);

                    // process message here.
                    int commitPeriod = 1;
                    if (consumeResult != null && consumeResult.Offset % commitPeriod == 0)
                    {
                        try
                        {
                            Console.WriteLine($"Received message at {consumeResult.TopicPartitionOffset}: {consumeResult.Value}");
                            consumer.Commit(consumeResult);
                        }
                        catch (KafkaException e)
                        {
                            Console.WriteLine($"Commit error: {e.Error.Reason}");
                        }
                    }
                }
            }



        }
        */
    }
}
