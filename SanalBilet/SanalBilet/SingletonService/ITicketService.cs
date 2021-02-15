using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SanalBilet.SingletonService
{
     public   interface ITicketService
    {
        string GetBranchIp(string BranchCode);
        void AddTicket(TicketRequest Ticket);
        void DeleteTicket(TicketRequest item);
        List<TicketRequest> Tickets { get; set; }
        bool Processing
        {
            get;
            set;
        }


    }
}
