using Confluent.Kafka;
using System;
using System.Collections.Generic;
using System.Text;

namespace KioskConsumer
{
    public class Consumerclass
    {
        IConsumer<string, string> consumer;
        public Consumerclass()
        {
            var config = new ConsumerConfig
            {
               
              
                BootstrapServers = "localhost:9092,localhost:9093,localhost:9094",
                GroupId = "ConsumerGroup1",
                AutoOffsetReset = AutoOffsetReset.Earliest,
                EnableAutoCommit = false,
              

        };
             
            consumer = new ConsumerBuilder<string, string>(config).Build();
            
           
            consumer.Subscribe("RequestTicket");
            
            // 
        }
        public  string  Read()
        {

            string _result = "";
            {

          
               //  while (!isCancelled)
                {
                    int cancellationToken = 5000;
                   


                    var consumeResult = consumer.Consume(cancellationToken);

                    // process message 1.
                    int commitPeriod = 1;
                    if (consumeResult != null && consumeResult.Offset % commitPeriod == 0)
                    {
                        try
                        {

                            //Console.WriteLine($"Received message at {consumeResult.TopicPartitionOffset}: {consumeResult.Value}");
                            consumer.Commit(consumeResult);
                            _result= ($"Received message at {consumeResult.TopicPartitionOffset}: {consumeResult.Value}");
                        }
                        catch (KafkaException e)
                        {
                            Console.WriteLine($"Commit error: {e.Error.Reason}");
                        }
                    }

                    return _result;
                }



            }
        }

    }
}
