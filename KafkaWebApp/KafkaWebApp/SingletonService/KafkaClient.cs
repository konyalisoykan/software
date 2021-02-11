using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Confluent.Kafka;

namespace KafkaWebApp.SingletonService
{
    public class KafkaClient : IKafkaClient
    {
        public async Task< DeliveryResult<string, string>> Send(string BranchCode,string PhoneNumber)
        {
            Message<string, string> _message=null;

            DeliveryResult<string, string> _result; 
            
            Console.WriteLine("Producer Tarafı\n");
            string brokerEndpoint = "localhost:9092";
            var config = new ProducerConfig
            {

                BootstrapServers = brokerEndpoint,
                //  BootstrapServers = "host1:9092,host2:9092",
                ClientId = Dns.GetHostName()

            };


            using (var producer = new ProducerBuilder<string, string>(config).Build())
            {

               
                 _message = new Message<string, string> { Key = BranchCode, Value = PhoneNumber  };

              Task<  DeliveryResult<string, string>>peoduceResulr =   producer.ProduceAsync("RequestTicket", _message);
                peoduceResulr.Wait();
                _result = peoduceResulr.Result;

            }

            return _result;
        }
    }
}
