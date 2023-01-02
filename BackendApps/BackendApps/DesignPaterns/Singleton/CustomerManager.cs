using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendApps.DesignPaterns.Singleton
{
    class CustomerManager
    {

        private static object _lockObject=new object ()  ;
        private static  CustomerManager _customerManager;
        private CustomerManager()
        {


        }
        public static CustomerManager CreateSinglaton()
        {
            lock (_lockObject)
            {
                if (_customerManager == null)
                {
                    _customerManager = new CustomerManager();
                }
            }
            return _customerManager;

        }
    }
        
}
