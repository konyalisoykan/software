using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SanalBilet.SingletonService
{
    public class Branch
    {
        string  _branchNo;
        string _ip;

        public string BranchNo { get => _branchNo; set => _branchNo = value; }
        public string Ip { get => _ip; set => _ip = value; }
    }
}
