using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendApps.DesignPaterns.AbstractFactory
{
    public abstract class AbstractFactory
    {
        public abstract void Log(string Message);
    }
    public abstract class Cashibg
    {
        public abstract void Cash(string Message);
    }
    public abstract class CrossCuttingConsernsFactory
    {
        public abstract AbstractFactory CreateLogger();
        public abstract Cashibg CreateCashing();
    }
    public class Factory1: CrossCuttingConsernsFactory
    {
        public override AbstractFactory CreateLogger() 
        { 
        return  new  Log4net();
        }
        public override Cashibg CreateCashing()
        {
            return new RedisCash();
        }
    }
    public class Factory2 : CrossCuttingConsernsFactory
    {
        public override AbstractFactory CreateLogger()
        {
            return new Nlogger();
        }
        public override Cashibg CreateCashing()
        {
            return new RedisCash();
        }
        public class Factory3 : CrossCuttingConsernsFactory
        {
            public override AbstractFactory CreateLogger()
            {
                return new Nlogger();
            }
            public override Cashibg CreateCashing()
            {
                return new MemeCash();
            }
        }
    }
    
    public class ProductManager
    {
        private AbstractFactory _logging;
        private Cashibg _cashing;
        CrossCuttingConsernsFactory _crossCuttingConsernsFactory;
        public ProductManager(CrossCuttingConsernsFactory crossCuttingConsernsFactory)
        {
            _logging = crossCuttingConsernsFactory.CreateLogger();
            _cashing = crossCuttingConsernsFactory.CreateCashing();
            _crossCuttingConsernsFactory = crossCuttingConsernsFactory;

        }
        public void  GetAll()
        {
            _logging.Log("Loglandı");
            _cashing.Cash("Casjlendi");
            Console.WriteLine("Ürünler listelendi");
        }

    }
       
    public class Log4net : AbstractFactory
    {
        public override void Log(string Message)
        {
           Console.WriteLine("Log4net");  
        }
    }
    public class Nlogger : AbstractFactory
    {
        public override void Log(string Message)
        {
            Console.WriteLine("Nkogger");
        }
    }
    public class MemeCash : Cashibg
    {
        public override void Cash(string Message)
        {
            Console.WriteLine("MemeCash");
        }
    }
    public class RedisCash : Cashibg
    {
        public override void Cash(string Message)
        {
            Console.WriteLine("Redşs");
        }
    }
}
