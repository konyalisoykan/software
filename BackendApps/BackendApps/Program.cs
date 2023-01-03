using BackendApps.DesignPaterns.AbstractFactory;
using BackendApps.DesignPaterns.Factory;
using BackendApps.DesignPaterns.Singleton;
using static BackendApps.DesignPaterns.AbstractFactory.Factory2;

namespace BackendApps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DesignPaterns.Singleton.CustomerManager _customerManager = DesignPaterns.Singleton.CustomerManager.CreateSinglaton();
            Console.WriteLine("Singlaton!");
            DesignPaterns.Factory.CustomerManager _factoryCustomerManager = new DesignPaterns.Factory.CustomerManager(new LoggerFactoy());
            _factoryCustomerManager.Save();
            ProductManager _productManager = new ProductManager(new Factory2());
            _productManager.GetAll();
            Console.ReadLine();
        }
    }
}