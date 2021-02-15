﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace SanalBilet.Helper
{
    public class RequestResult
    {

        int _rowCount;

        public int RowCount
        {
            get { return _rowCount; }
            set { _rowCount = value; }
        }

        XmlNodeList _rowData;

        public XmlNodeList RowData
        {
            get { return _rowData; }
            set { _rowData = value; }
        }

        int _isThereAnyWaitingCustomer = -1;

        public int IsThereAnyWaitingCustomer
        {
            get { return _isThereAnyWaitingCustomer; }
            set { _isThereAnyWaitingCustomer = value; }
        }

        int _avgWaitingTime = -1;

        public int AvgWaitingTime
        {
            get { return _avgWaitingTime; }
            set { _avgWaitingTime = value; }
        }

        int _resultCode = -1;

        public int ResultCode
        {
            get { return _resultCode; }
            set { _resultCode = value; }
        }
        int _errorMsg = -1;

        public int ErrorMsg
        {
            get { return _errorMsg; }
            set { _errorMsg = value; }
        }
        string _lastRecievedTm = "";

        public string LastRecievedTm
        {
            get { return _lastRecievedTm; }
            set { _lastRecievedTm = value; }
        }

        string _userNAme = "";

        public string UserNAme
        {
            get { return _userNAme; }
            set { _userNAme = value; }
        }
        int _userCode = -1;

        public int UserCode
        {
            get { return _userCode; }
            set { _userCode = value; }
        }
        int userPriorityCode = -1;

        public int UserPriorityCode
        {
            get { return userPriorityCode; }
            set { userPriorityCode = value; }
        }
        int authorityNext = -1;

        public int AuthorityNext
        {
            get { return authorityNext; }
            set { authorityNext = value; }
        }
        int authorityForward = -1;

        public int AuthorityForward
        {
            get { return authorityForward; }
            set { authorityForward = value; }
        }
        int authorityHold = -1;

        public int AuthorityHold
        {
            get { return authorityHold; }
            set { authorityHold = value; }
        }
        int authorityFiction = -1;

        public int AuthorityFiction
        {
            get { return authorityFiction; }
            set { authorityFiction = value; }
        }
        int authorityManuel = -1;

        public int AuthorityManuel
        {
            get { return authorityManuel; }
            set { authorityManuel = value; }
        }

        int ticketNumber = -1;

        public int TicketNumber
        {
            get { return ticketNumber; }
            set { ticketNumber = value; }
        }
        int deskNumber = -1;

        public int DeskNumber
        {
            get { return deskNumber; }
            set { deskNumber = value; }
        }
        int catCode = -1;

        public int CatCode
        {
            get { return catCode; }
            set { catCode = value; }
        }
        string catName = "";

        public string CatName
        {
            get { return catName; }
            set { catName = value; }
        }
        string custName = "";

        public string CustName
        {
            get { return custName; }
            set { custName = value; }
        }
        string waitingTime = "";

        public string WaitingTime
        {
            get { return waitingTime; }
            set { waitingTime = value; }
        }
        string avgProcessTime = "";

        public string AvgProcessTime
        {
            get { return avgProcessTime; }
            set { avgProcessTime = value; }
        }
        int servedCustCount = -1;

        public int ServedCustCount
        {
            get { return servedCustCount; }
            set { servedCustCount = value; }
        }
        int buttonNumber = -1;

        public int ButtonNumber
        {
            get { return buttonNumber; }
            set { buttonNumber = value; }
        }
        int waitingCustCount = -1;

        public int WaitingCustCount
        {
            get { return waitingCustCount; }
            set { waitingCustCount = value; }
        }
        int waitingButtonCount = -1;

        public int WaitingButtonCount
        {
            get { return waitingButtonCount; }
            set { waitingButtonCount = value; }
        }
        string custNo = "";

        public string CustNo
        {
            get { return custNo; }
            set { custNo = value; }
        }
        string cardNo = "";

        public string CardNo
        {
            get { return cardNo; }
            set { cardNo = value; }
        }
        string cardStatus = "";

        public string CardStatus
        {
            get { return cardStatus; }
            set { cardStatus = value; }
        }
        string customerNo = "";

        public string CustomerNo
        {
            get { return customerNo; }
            set { customerNo = value; }
        }
        string processId = "";

        public string ProcessId
        {
            get { return processId; }
            set { processId = value; }
        }
        string productionTime = "";

        public string ProductionTime
        {
            get { return productionTime; }
            set { productionTime = value; }
        }
    }
}
