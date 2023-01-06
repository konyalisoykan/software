using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BackendApps.DesignPaterns.Fecade
{// Amaç daha teniz bir kod yazmak
    //CrossCuttongCıncernFacade injectşonlaro yapıp 
    //Customer managerı tenşz burakmak

    public class Logging : ILogging
    {
        public void Log()
        {
            Console.Write("Loging");
        }
    }
    public class Cashing : ICashşng
    {
        public void  Cash()
        {
            Console.Write("Cash");
        }
    }
   public   class CıstomerManager
    {
        CrossCuttongCıncernFacade _crossCuttongCıncernFacade;
        public CıstomerManager()
        {
             _crossCuttongCıncernFacade = new CrossCuttongCıncernFacade();
        }
        public void  Save()
        {
            _crossCuttongCıncernFacade.Logger.Log();
            _crossCuttongCıncernFacade.Casher.Cash();
        }
    }
    public class CrossCuttongCıncernFacade
    {
        internal ILogging Logger;
        internal ICashşng Casher;
        public CrossCuttongCıncernFacade()
        {
            //normalde burada containerlarla yapılıyor
            Logger = new Logging();
            Casher = new Cashing();
        }
    }
}
