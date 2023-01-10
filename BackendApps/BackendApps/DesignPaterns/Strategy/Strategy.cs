using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendApps.DesignPaterns.Strategy
{
    internal class Strategy
    {
    }
    public abstract class CredştCalculateBase
    {
        public abstract void Calculate();

    }
    public class Brfore2000Calculate : CredştCalculateBase
    {
        public override void Calculate()
        {
            Console.WriteLine("Brfore2000Calculate");
        }
    }
    public class After2000Calculate : CredştCalculateBase
    {
        public override void Calculate()
        {
            Console.WriteLine("After2000Calculate");
        }
    }
    public class CustomerManager
    {
        // injectionda yapılabilir
        public CredştCalculateBase CredştCalculateBase { get; set; }
        public void SaveCredit()
        {
            Console.WriteLine("Customer Manager Buseness");
            CredştCalculateBase.Calculate();
        }

    }

}
