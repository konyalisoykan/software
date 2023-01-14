using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendApps.DesignPaterns.Command
{
    internal class StockManager
    {
        public string Name = "Leptop";
        public int Quentiy = 10;
        public void Buy()
        {
            Console.WriteLine("Stock {0} {1} bought ", Name, Quentiy);
        }
        public void Sale()
        {
            Console.WriteLine("Stock {0} {1} sold  ", Name, Quentiy);
        }

    }
    interface Iorder
    {
        void Execute();

    }
    class BuyStock : Iorder
    {
        StockManager _stockManager;

        public BuyStock(StockManager stockManager)
        {
            _stockManager = stockManager;
        }

        public void Execute()
        {
            _stockManager.Buy();
        }
    }
    class SellStock : Iorder
    {
        StockManager _stockManager;

        public SellStock(StockManager stockManager)
        {
            _stockManager = stockManager;
        }

        public void Execute()
        {
            _stockManager.Sale();
        }
    }
     class StockController
    {
        List<Iorder> _orders = new List<Iorder>();
        public void TakeOrder(Iorder Order)
        {
            _orders.Add(Order); 
        }
        public void PlaceOrder()
        {
            foreach(var order in _orders)
            {
                order.Execute();    

            }
            _orders.Clear();
        }
    }

}
