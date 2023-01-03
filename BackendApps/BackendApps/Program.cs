using BackendApps.DesignPaterns.AbstractFactory;
using BackendApps.DesignPaterns.Builder;
using BackendApps.DesignPaterns.Factory;
using BackendApps.DesignPaterns.Prototype;
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
            Customer customer1 = new Customer { FirstName = "Ali", LastName = "Veli", City = "ist" };
            Customer customer2 =(Customer) customer1.Clone();
            customer2.FirstName = "Soykan";
            Console.WriteLine("Customer1 fitsyname {0}", customer1.FirstName);
            Console.WriteLine("Customer2 FirstName {0}", customer2.FirstName);
            ProductDiractor _diractor = new ProductDiractor();
            var builder = new NewCustomerProductBuilder();
            _diractor.GenerateProduct(builder);
            var model = builder.GetModel();
            Console.WriteLine("eski öüsteri için Name {0} normal fiuat {1} indirimli fiyat {2}", model.Name, model.UnitPrice, model.DiscountedPrice);

            var builder2 = new OldCustomerProductBuilder();
            _diractor.GenerateProduct(builder2);
            var model2 = builder2.GetModel();
            Console.WriteLine("yeni müsteri için Name {0} normal fiuat {1} indirimli fiyat {2}", model2.Name, model2.UnitPrice, model2.DiscountedPrice);


            Console.ReadLine();
        }
    }
}