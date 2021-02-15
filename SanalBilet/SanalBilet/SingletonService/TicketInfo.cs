using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SanalBilet.SingletonService
{
    public class TicketRequest
    {
        string __connectionId;
        string _ip;
        string _branchNo;

        public string ConnectionId { get => __connectionId; set => __connectionId = value; }
        public string BranchNo { get => _branchNo; set => _branchNo = value; }
        public string Ip { get => _ip; set => _ip = value; }
    }

}
