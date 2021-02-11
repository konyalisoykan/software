using Confluent.Kafka;
using KafkaWebApp.SingletonService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KafkaWebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        IKafkaClient _kafkaClient;
        public WeatherForecastController(IKafkaClient KafkaClient)
        {
            _kafkaClient = KafkaClient;
        }
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        /*
        public WeatherForecastController(ILogger<WeatherForecastController> logger, KafkaClient KafkaClient)
        {
            _kafkaClient = KafkaClient;
            _logger = logger;
        }
        */

        [HttpGet]
        public async Task< IActionResult > Get()
        {
            string _text = "";
           Task< DeliveryResult<string, string>> result = _kafkaClient.Send("2","2222222222");
            _text = result.Result.Key + " " + result.Result.Partition.Value.ToString() +" "+ result.Result.Offset.Value.ToString() + " " + result.Result.Status.ToString()+Environment.NewLine;
              result =  _kafkaClient.Send("1", "111111111111");
            _text += result.Result.Key + " " + result.Result.Partition.Value.ToString() + " " + result.Result.Offset.Value.ToString() + " " + result.Result.Status.ToString() + Environment.NewLine;
            result =  _kafkaClient.Send("3", "3333333333333");
            _text += result.Result.Key + " " + result.Result.Partition.Value.ToString() + " " + result.Result.Offset.Value.ToString() + " " + result.Result.Status.ToString() + Environment.NewLine;
            /*
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
            */
            return Ok(_text);
        }
    }
}
