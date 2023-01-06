using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BackendApps.DesignPaterns.Adapter
{
    internal class Adapter
    {
    }
    public class ProductManager
    {
        ILogging _logger;
        public ProductManager(ILogging Logger)
        {
            _logger = Logger;
        }
        public void   Save() {
            _logger.Log("Save edildi");
        }
    }
    public interface ILogging
    {
        public void Log(string  message);
    }
    public class Logger1 : ILogging
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
    public class  Log4bet
    {
        public void Log(string message)
        {
            Console.WriteLine("Logged with log4net {0}", message);
        }

    }
    public class Log4NetAdaoter:ILogging
    {
        public void Log(string message) 
        {
            Log4bet _logger=new Log4bet();  
            _logger.Log(message);   
        }
    }

}
