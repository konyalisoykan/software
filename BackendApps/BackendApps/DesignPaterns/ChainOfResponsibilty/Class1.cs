using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendApps.DesignPaterns.ChainOfResponsibilty
{
    class Expeense
    {
        public string Detail { get; set; }
        public decimal Amount { get; set; }
    }
    abstract class ExpenseHandlerBase
    {
        protected ExpenseHandlerBase _successor;
        public abstract void HandleExpense(Expeense Expeense);
        public void SetSuccessor(ExpenseHandlerBase successor)
        {
            _successor = successor;
        }
    }
    class Manager : ExpenseHandlerBase
    {
        public override void HandleExpense(Expeense Expeense)
        {
            if(Expeense.Amount<100)
            {
                Console.WriteLine("Manager  onylayabilir");
            }
            else if(_successor!=null)
            {
                _successor.HandleExpense(Expeense);
            }
           
        }
    }
    class VisePresident : ExpenseHandlerBase
    {
        public override void HandleExpense(Expeense Expeense)
        {
            if (Expeense.Amount >100 && Expeense.Amount <= 1000)
            {
                Console.WriteLine("başkan yardımcısı   onylayabilir");
            }
            else if (_successor != null)
            {
                _successor.HandleExpense(Expeense);
            }
        }

    }
     class Presşdent : ExpenseHandlerBase
    {
        public override void HandleExpense(Expeense Expeense)
        {
            if (Expeense.Amount > 1000)
            {
                Console.WriteLine("başkan yardımcısı   onylayabilir");
            }
           
        }
    }


}