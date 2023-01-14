using BackendApps.DesignPaterns.AbstractFactory;
using BackendApps.DesignPaterns.Bridge;
using BackendApps.DesignPaterns.Builder;
using BackendApps.DesignPaterns.ChainOfResponsibilty;
using BackendApps.DesignPaterns.Decarotor;
using BackendApps.DesignPaterns.Factory;
using BackendApps.DesignPaterns.Fecade;
using BackendApps.DesignPaterns.Memento;
using BackendApps.DesignPaterns.Prototype;
using BackendApps.DesignPaterns.Proxy;
using BackendApps.DesignPaterns.Singleton;
using BackendApps.DesignPaterns.Strategy;
using BackendApps.Mediator;
using BackendApps.State;
using BackendApps.Template;
using Microsoft.VisualBasic.FileIO;
using System.Globalization;
using System.Runtime.InteropServices;
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
            Customer customer2 = (Customer)customer1.Clone();
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

            //
            PersonalCar _personalCar = new PersonalCar { Make = "Opel", HirePrice = 2500, Model = "Astra" };
            SpecialOffer _specialCar = new SpecialOffer(_personalCar);
            _specialCar.DiscountPercentage = 10;
            Console.WriteLine(_personalCar.HirePrice);
            Console.WriteLine(_specialCar.HirePrice);

            BackendApps.DesignPaterns.Bridge.CustomerManager _customerMAnager = new DesignPaterns.Bridge.CustomerManager();
            _customerMAnager.MessageMSenderBase = new EmailSender();
            _customerMAnager.Update();
            _customerMAnager.MessageMSenderBase = new SmsSender();
            _customerMAnager.Update();

            BackendApps.DesignPaterns.Strategy.CustomerManager _customerMAneger = new DesignPaterns.Strategy.CustomerManager();
            _customerMAneger.CredştCalculateBase = new After2000Calculate();
            _customerMAneger.SaveCredit();
            _customerMAneger.CredştCalculateBase = new Brfore2000Calculate();
            _customerMAneger.SaveCredit();

            BackendApps.Observar.CustomerObserver? custObserver = new Observar.CustomerObserver();
            BackendApps.Observar.ProductManager _observer = new BackendApps.Observar.ProductManager();
            _observer.Attach(custObserver);
            _observer.Attach(new BackendApps.Observar.EmployeeObserver());
            _observer.UpdatePrice();
            _observer.Detach(custObserver);
            _observer.UpdatePrice();
            BackendApps.DesignPaterns.ChainOfResponsibilty.Manager _manager = new DesignPaterns.ChainOfResponsibilty.Manager();
            VisePresident _visePresident = new VisePresident();
            VisePresident _president = new VisePresident();

            _manager.SetSuccessor(_visePresident);
            _visePresident.SetSuccessor(_president);
            Expeense _expense = new Expeense { Detail = "Eğitim", Amount = 125 };
            _manager.HandleExpense(_expense);
          
            Book _book = new Book
            {
                Isbn = "1234",
                LastEdited = DateTime.Now,
                Title = "Csharp",
                Author = "Soykan"
            };
            _book.showBook();
            CareTaker _history = new CareTaker();
            _history.Memento = _book.CreateUndı();
            _book.Isbn = "00000";
            _book.Author="Nur";
            _book.showBook();
            _book.RestoreFromUndo(_history.Memento);
            _book.showBook();

            ScoringAlgoritm _algoritm;
            _algoritm = new MensScoringAlgoritm();
            _algoritm.GemerateScore(8, new TimeSpan(0, 5, 20));
           Console.WriteLine("mens sore "+ _algoritm.GemerateScore(8, new TimeSpan(0, 5, 20)).ToString());
            _algoritm.CalsulateReduction(new TimeSpan(0, 5, 20));

            _algoritm = new WomensScoringAlgoritm();
            _algoritm.GemerateScore(8, new TimeSpan(0, 5, 20));
            _algoritm.CalsulateReduction(new TimeSpan(0, 5, 20));
            Console.WriteLine("womens sore " + _algoritm.GemerateScore(8, new TimeSpan(0, 5, 20)).ToString());
           
            _algoritm = new ChildrensScoringAlgoritm();
            _algoritm.GemerateScore(8, new TimeSpan(0, 5, 20));
            _algoritm.CalsulateReduction(new TimeSpan(0, 5, 20));
            Console.WriteLine("Children  sore " + _algoritm.GemerateScore(8, new TimeSpan(0, 5, 20)).ToString());

            Context _context = new Context();
            
            ModifiedState _ms = new ModifiedState();
            _ms.DoAction(_context);
            Console.WriteLine(_context.GetState().ToString());

            AddeddState As = new AddeddState();
            As.DoAction(_context);
            Console.WriteLine(_context.GetState().ToString());

            Mediator.Mediator _mediator = new BackendApps.Mediator.Mediator();
            Teacher _teacher = new Teacher(_mediator);
            _teacher.Name="soykan";
           // _mediator.Teacher = _teacher;

            Student ahmet = new Student(_mediator);
            ahmet.Name = "Ahmet";
           

            Student kerem = new Student(_mediator);
            kerem.Name = "kerem";
          //  _mediator.Students = new List<Student> { ahmet, kerem };


            _teacher.SendNewImage("image2");
            _teacher.ReveiveQuestion("Is ıt true", ahmet);
            Console.ReadLine();

        }
    }
}