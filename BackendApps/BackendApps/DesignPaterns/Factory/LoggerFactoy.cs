using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendApps.DesignPaterns.Factory
{
    internal class LoggerFactoy : ILoggerFactoy
    {
        public ILogger CreateLogger()
        {
            return new Log4net();
        }
    }
    internal class LoggerFactoy2 : ILoggerFactoy
    {
        public ILogger CreateLogger()
        {
            return new Nlog();
        }
    }
}
