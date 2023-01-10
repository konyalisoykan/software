using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendApps.Observar
{
    public abstract  class Observar
    {
        public abstract void Update();
    }
    public class ProductManager
    {
        List<Observar>  _observers=new List<Observar>();
        public void Attach(Observar Observar)
        {
            _observers.Add(Observar);   
        }
        public void Detach(Observar Observar)
        {
            _observers.Remove(Observar);
        }
         private void Notify()
        {
            foreach( var observar in _observers)
            {
                observar.Update();
            }
        }
        public void UpdatePrice()
        {
            Console.WriteLine("Ürün fityatı değişti");
            Notify();
        }
    }
    public class CustomerObserver : Observar
    {
        public override void Update()
        {
            Console.WriteLine(" Müşteriye Ürün fityatı değişti mesajı tollanadı ");
        }
    }
    public class EmployeeObserver : Observar
    {
        public override void Update()
        {
            Console.WriteLine(" Çalılanlara  Ürün fityatı değişti mesajı tollanadı ");
        }
    }
}
