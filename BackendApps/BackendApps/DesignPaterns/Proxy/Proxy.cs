using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendApps.DesignPaterns.Proxy
{
    
    public abstract class CreditBase
    {
        public abstract int Calculate();
    }
    public class CreditManager : CreditBase
    {
        public override int Calculate()
        {
            int _rsulti = 1;
            for(int i=1;i<=10;i++)
            {
                _rsulti *= i;
                Thread.Sleep(1000);
            }
           
            return _rsulti;

           
        }
    }
    public class CreditManagerProxy : CreditBase
    {
        CreditManager _creditManager;
        int _cashVakur;
        public override int Calculate()
        {
            if(_creditManager==null)
            {
                _creditManager = new CreditManager();
                _cashVakur= _creditManager.Calculate();
            }
            return _cashVakur;




        }
    }
}
