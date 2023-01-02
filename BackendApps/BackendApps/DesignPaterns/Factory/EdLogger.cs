using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendApps.DesignPaterns.Factory
{
    internal class Log4net:ILogger
    {
      public  void Log()
        {
            Console.WriteLine("Log4net");
        }
    }
    internal class Nlog : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Nlog");
        }
    }
}
