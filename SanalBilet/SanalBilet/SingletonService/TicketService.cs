using Microsoft.AspNetCore.SignalR.Client;

using SanalBilet.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;


namespace SanalBilet.SingletonService
{

    public class TicketService : ITicketService
    {
        HubConnection connection;
       
       
        List<TicketRequest> _tickets;
        bool _processing = false;
        public List<TicketRequest> Tickets { get => _tickets; set => _tickets = value; }
        public bool Processing { get => _processing; set => _processing = value; }
        List<Branch> _branches;
        public List<Branch> Branches { get => _branches; set => _branches = value; }

        public TicketService()
        {
            _branches = new List<Branch>();
            _tickets = new List<TicketRequest>();
            _branches= GetBranchList();
        }
        public string GetBranchIp(string BranchCode)
        {
          return  _branches.Where(x => x.BranchNo == BranchCode).First().Ip;
        }
        private List<Branch> GetBranchList()
        {
            List<Branch> _list = new List<Branch>();
            Branch _branch1 = new Branch();
            _branch1.BranchNo = "1";
            _branch1.Ip = "172.16.66.104";
            _list.Add(_branch1);
            Branch _branch2 = new Branch();
            _branch2.BranchNo = "2";
            _branch2.Ip = "172.16.66.105";
            _list.Add(_branch2);
            return _list;
        }
        



        public void AddTicket(TicketRequest Ticket)
        {
            Tickets.Add(Ticket);
        }
        public void DeleteTicket(TicketRequest item)
        {
            try
            {
              
                Tickets.Remove(item);
            }
            catch (Exception ex)
            {

            }
        }
        
    }
  
}
