using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendApps.DesignPaterns.Factory
{
    public class CustomerManager
    {
        ILoggerFactoy _loggerFactory;
        ILogger _logger;
        public CustomerManager(ILoggerFactoy ILoggerFactoy)
        {
            _loggerFactory= ILoggerFactoy;
            _logger = _loggerFactory.CreateLogger();
        }
        public void Save()
        {
         
            _logger.Log();

        }
    }
}
