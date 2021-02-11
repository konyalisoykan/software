using Confluent.Kafka;
using System.Threading.Tasks;

namespace KafkaWebApp.SingletonService
{
    public interface IKafkaClient
    {
       
        Task< DeliveryResult<string, string>> Send(string BranchCode, string PhoneNumber);
    }
}