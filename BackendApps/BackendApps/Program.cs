using BackendApps.DesignPaterns.AbstractFactory;
using BackendApps.DesignPaterns.Builder;
using BackendApps.DesignPaterns.Decarotor;
using BackendApps.DesignPaterns.Factory;
using BackendApps.DesignPaterns.Fecade;
using BackendApps.DesignPaterns.Prototype;
using BackendApps.DesignPaterns.Proxy;
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
            BackendApps.DesignPaterns.Fecade.CıstomerManager cm = new CıstomerManager();
            cm.Save();
            BackendApps.DesignPaterns.Adapter.ProductManager _pd = new DesignPaterns.Adapter.ProductManager(new DesignPaterns.Adapter.Logger1()); ;
            _pd.Save();
            // Loglama aracını değiştirmek istersek adapterü kullanıyoruz
            BackendApps.DesignPaterns.Adapter.ProductManager _pd2 = new DesignPaterns.Adapter.ProductManager(new DesignPaterns.Adapter.Log4NetAdaoter()); ;
            _pd2.Save();
            // hşyarerşik yapılarda kullanılan bir teknik
            BackendApps.DesignPaterns.Composite.Employee soykan = new DesignPaterns.Composite.Employee { Name = "Soykan" };
            BackendApps.DesignPaterns.Composite.Employee hatice = new DesignPaterns.Composite.Employee { Name = "Hatice" };
            BackendApps.DesignPaterns.Composite.Employee elif = new DesignPaterns.Composite.Employee { Name = "Elif" };
            soykan.AddSubIrdinate(hatice);
            hatice.AddSubIrdinate(elif);
            
           Console.WriteLine(soykan.Name);

            foreach (BackendApps.DesignPaterns.Composite.Employee emp in soykan)
            {
                Console.WriteLine(emp.Name);
              
                foreach (BackendApps.DesignPaterns.Composite.Employee subemp in hatice)
                {
                    Console.WriteLine(subemp.Name);
                }
            }
            //2. calculate fonksiyonunda bekleme olmayacak
            CreditManagerProxy _proxu = new CreditManagerProxy();
            Console.WriteLine(_proxu.Calculate());
            Console.WriteLine(_proxu.Calculate());

            PersonalCar _personalCar = new PersonalCar { Make = "Opel", HirePrice = 2500, Model = "Astra" };
            SpecialOffer _specialCar = new SpecialOffer(_personalCar);
            _specialCar.DiscountPercentage = 10;
            Console.WriteLine(_personalCar.HirePrice);
            Console.WriteLine(_specialCar.HirePrice);
            Console.ReadLine();
        }
    }
}