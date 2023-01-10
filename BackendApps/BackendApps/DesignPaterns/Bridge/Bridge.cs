using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendApps.DesignPaterns.Bridge
{
    internal class Bridge
    {
    }
     abstract   class MessageMSenderBase
    {
        public void  Save()
        {
            Console.WriteLine(" Kaydedildi");
        }
        public abstract void Send(Body Body);
    }
    class  Body
    {
        public string  Title { get; set; }
        public string Text { get; set; }
    }
    class SmsSender : MessageMSenderBase
    {
        public override void Send(Body Body)
        { 
            Console.WriteLine("Sms sender {0} ", Body.Title);
        }
    }
    class EmailSender : MessageMSenderBase
    {
        public override void Send(Body Body)
        {
            Console.WriteLine("Mail sender {0} ", Body.Title);
        }
    }
    class CustomerManager
    {
        public MessageMSenderBase MessageMSenderBase { get; set; }
        public void Update() 
        {
            Console.WriteLine("Update customer");
            MessageMSenderBase.Send(new Body{ Title ="Bridge deneme"});
        }

    }
}
