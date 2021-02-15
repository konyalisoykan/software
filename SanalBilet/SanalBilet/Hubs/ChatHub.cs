using Microsoft.AspNetCore.SignalR;
using SanalBilet.Helper;
using SanalBilet.SingletonService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace SanalBilet.Hubs
{
    public class ChatHub : Hub
    {
        ITicketService _ticketService;
      
        public ChatHub(ITicketService service)
        {
                _ticketService = service;
        }
       
            public async Task SendMessage(string BranchCode)
        {
            try
            {
                TicketRequest _ticket = new TicketRequest();
                _ticket.BranchNo = BranchCode;
                _ticket.ConnectionId = Context.ConnectionId;
                _ticket.Ip = _ticketService.GetBranchIp(BranchCode);
                _ticketService.AddTicket(_ticket);
              
               
                /*
                HttpRequestHelper _request = new HttpRequestHelper();

               
                HttpRequestHelper _helper = new HttpRequestHelper();
                string _result = await _request.SendRequesAsyct("1", "172.16.66.104:90/td", "RQSTCK", "&DeviceId=2001&ButtonNumber=1&CardNo=&PhysicalButtonNo=1");
               // string _result =  _request.SendRequest("1", "172.16.66.104:90/td", "RQSTCK", "&DeviceId=2001&ButtonNumber=1&CardNo=&PhysicalButtonNo=1");

                XmlDocument _doc = _helper.StringToXml("1", _result);
                RequestResult _return = _helper.ParseXmlDoc(_doc, "RQSTCK");
                if (_return.ResultCode == 0 && _return.ErrorMsg == 0)
                {
                    //  await Clients.Client(Context.ConnectionId).SendAsync("ReceiveMessage", _return.TicketNumber.ToString());
                    await Clients.Client(Context.ConnectionId).SendAsync("ReceiveMessage", user, _return.TicketNumber.ToString());
                }
                else
                {

                    await Clients.Client(Context.ConnectionId).SendAsync("ReceiveMessage", user, _return.ErrorMsg.ToString());
                }
                */
            }
            catch(Exception ex)
            {

            }
        }
        public async Task GetTicketByBranchCode()
        {
            IEnumerable<IGrouping<string, TicketRequest>> _ticketRequests = null;
            try
            {
                _ticketRequests = _ticketService. Tickets.GroupBy(x => x.BranchNo);
                List<List<TicketRequest>> _branchData = new List<List<TicketRequest>>();
                foreach (IGrouping<string, TicketRequest> _group in _ticketRequests)
                {
                    List<TicketRequest> _ticketList = _group.ToList();
                    _branchData.Add(_ticketList);
                  //  var task= Send(_ticketList);
                   
                };
             IEnumerable<Task<int>> branchTşcketTasksQuery =
            from branchTickets in _branchData
               select Send(branchTickets);
                List<Task<int>> branchTask = branchTşcketTasksQuery.ToList();
                while (branchTask.Any())
                {
                    Task<int> finishedTask = await Task.WhenAny(branchTask);
                    branchTask.Remove(finishedTask);
                     await finishedTask;
                }

            }
            catch (Exception ex)
            { }

        }
      
        public async Task<int> Send(List<TicketRequest> TicketList)
        {
            int _count = 0;
            if(TicketList!=null && TicketList.Count!=0)
            foreach (TicketRequest item in TicketList)
            {
                try
                {
                       /*
                       //test
                       await Clients.Client(item.ConnectionId).SendAsync("ReceiveMessage", "1", "101");
                         //test
                       _ticketService.DeleteTicket(item);
                         */
                            
                        HttpRequestHelper _request = new HttpRequestHelper();
                   HttpRequestHelper _helper = new HttpRequestHelper();
                   string _result = await _request.SendRequesAsyct(item.BranchNo, item.Ip+":90/td", "RQSTCK", "&DeviceId=2001&ButtonNumber=1&CardNo=&PhysicalButtonNo=1");
                   XmlDocument _doc = _helper.StringToXml("1", _result);
                   RequestResult _return = _helper.ParseXmlDoc(_doc, "RQSTCK");
                   if (_return.ResultCode == 0 && _return.ErrorMsg == 0)
                   {

                           await Clients.Client(item.ConnectionId).SendAsync("ReceiveMessage", _return.TicketNumber.ToString());
                            _ticketService.DeleteTicket(item);
                            _count++;
                        }
                   else
                   {
                       await Clients.Client(item.ConnectionId).SendAsync("ReceiveMessage", item.ConnectionId, "Error");
                   }
                      
                    }
                    catch (Exception ex)
                {

                }

            }
            return _count; ;
        }

        public async Task  PublishMessage()
        {
            try
            {
               // if (_ticketService.Processing == false)
                {
                    _ticketService.Processing = true;
                    // await Clients.user("1").SendAsync("ReceiveMessage", "1", "1");
                 await    GetTicketByBranchCode();
                    _ticketService.Processing = false;
                }
            }
            catch(Exception ex)
            {

            }
        }
        public Task SendPrivateMessage(string user, string message)
        {
           
            return Clients.User(user).SendAsync("ReceiveMessage","1" ,message);
        }
        public async Task AddToGroup(string groupName)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, groupName);

            await Clients.Group(groupName).SendAsync("Send", $"{Context.ConnectionId} has joined the group {groupName}.");
        }

        public async Task RemoveFromGroup(string groupName)
        {
            await Groups.RemoveFromGroupAsync(Context.ConnectionId, groupName);

            await Clients.Group(groupName).SendAsync("Send", $"{Context.ConnectionId} has left the group {groupName}.");
        }
    }

}
