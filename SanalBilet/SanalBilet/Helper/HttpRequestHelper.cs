﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml;

namespace SanalBilet.Helper
{
    public class HttpRequestHelper
    {
        public string SendRequest(string BranchCode, string ServerAddress, string Command, string Paremeters)
        {
            string responseFromServer = "";
            try
            {
                //  Request.Url.GetLeftPart(UriPartial.Authority);

                // Create a request for the URL. 
                //WebRequest request = WebRequest.Create(
                // "http://10.16.66.243:1285/vt?Command=OPN&DeviceId=2001");
                string _req = "http://"+ServerAddress + "?Command=" + Command + Paremeters;


                Uri serverUri = new Uri(_req);
                WebRequest request = (HttpWebRequest)WebRequest.Create(serverUri);


             //   WebRequest request = WebRequest.Create(ServerAddress + "?Command=" + Command + Paremeters);
              //  TextLog.LogInfo(BranchCode, "VtHTTP' ye yollanan mesaj= " + ServerAddress + "?Command=" + Command + Paremeters);
                // If required by the server, set the credentials.
                request.Credentials = CredentialCache.DefaultCredentials;
                request.Timeout = 10000;
                // Get the response.

                WebResponse response = request.GetResponse();

                // Display the status.
                Console.WriteLine(((HttpWebResponse)response).StatusDescription);
                // Get the stream containing content returned by the server.
                Stream dataStream = response.GetResponseStream();
                // Open the stream using a StreamReader for easy access.
                StreamReader reader = new StreamReader(dataStream, System.Text.Encoding.Default);
                // Read the content.
                responseFromServer = reader.ReadToEnd();
              //  TextLog.LogInfo(BranchCode, "VtHTTP cevabı= " + responseFromServer);

                // Display the content.

                // Clean up the streams and the response.
                reader.Close();
                response.Close();
            }
            catch (Exception ex)
            {
              //  TextLog.LogError(BranchCode, ex.ToString());
            }
            return responseFromServer;
        }
        public async Task<string > SendRequesAsyct(string BranchCode, string ServerAddress, string Command, string Paremeters)
        {
            string _req = "http://" + ServerAddress + "?Command=" + Command + Paremeters;

            var client = new HttpClient();

            Task<string> getStringTask =
                client.GetStringAsync(_req);

            

            string contents = await getStringTask;

            return contents;
        }

        public XmlDocument StringToXml(string BranchCode, String XmlString)
        {

            XmlDocument xml = null;
            try
            {
                xml = new XmlDocument();
                xml.LoadXml(XmlString); // suppose that myXmlString contains "<Names>...</Names>"
            }
            catch (Exception ex)
            {
              //  TextLog.LogError(BranchCode, ex.ToString());
            }
            return xml;

        }

        public RequestResult ParseXmlDoc(XmlDocument XmlDoc, string Cmd)
        {
            RequestResult _result = new RequestResult();
            try
            {
                XmlNodeList xnList = XmlDoc.SelectNodes("/Result");
                try
                {


                    _result.RowData = XmlDoc.SelectNodes("/Result/ROWDATA/ROW");
                }
                catch
                {

                }
                foreach (XmlNode xn in xnList)
                {
                    try
                    {
                        if (xn["resultCode"] != null)
                            _result.ResultCode = Convert.ToInt32(xn["resultCode"].InnerText);
                    }
                    catch
                    {
                        _result.ResultCode = -1;
                    }
                    try
                    {
                        if (xn["rowCount"] != null)
                            _result.RowCount = Convert.ToInt32(xn["rowCount"].InnerText);
                    }
                    catch
                    {
                        _result.RowCount = -1;
                    }

                    try
                    {
                        if (xn["isThereAnyWaitingCustomer"] != null)
                            _result.IsThereAnyWaitingCustomer = Convert.ToInt32(xn["isThereAnyWaitingCustomer"].InnerText);
                    }
                    catch
                    {
                        _result.IsThereAnyWaitingCustomer = -1;
                    }

                    try
                    {
                        if (xn["avgWaitingTime"] != null)
                            _result.AvgWaitingTime = Convert.ToInt32(xn["avgWaitingTime"].InnerText);
                    }
                    catch
                    {
                        _result.AvgWaitingTime = -1;
                    }

                    try
                    {
                        if (xn["errorMsg"] != null)
                            _result.ErrorMsg = Convert.ToInt32(xn["errorMsg"].InnerText);
                    }
                    catch
                    {
                        _result.ErrorMsg = -1;
                    }
                    try
                    {
                        if (xn["lastReceivedTM"] != null)
                            _result.LastRecievedTm = (xn["lastReceivedTM"].InnerText);
                    }
                    catch
                    {
                        _result.LastRecievedTm = "";
                    }

                    try
                    {
                        if (xn["userName"] != null)
                            _result.UserNAme = (xn["userName"].InnerText);
                    }
                    catch
                    {
                        _result.UserNAme = "";
                    }

                    try
                    {
                        if (xn["userCode"] != null)
                            _result.UserCode = Convert.ToInt32(xn["userCode"].InnerText);
                    }
                    catch
                    {
                        _result.UserCode = -1;
                    }

                    try
                    {
                        if (xn["userPriorityCode"] != null)
                            _result.UserPriorityCode = Convert.ToInt32(xn["userPriorityCode"].InnerText);
                    }
                    catch
                    {
                        _result.UserPriorityCode = -1;
                    }

                    try
                    {
                        if (xn["authorityNext"] != null)
                            _result.AuthorityNext = Convert.ToInt32(xn["authorityNext"].InnerText);
                    }
                    catch
                    {
                        _result.AuthorityNext = -1;
                    }

                    try
                    {
                        if (xn["authorityForward"] != null)
                            _result.AuthorityForward = Convert.ToInt32(xn["authorityForward"].InnerText);
                    }
                    catch
                    {
                        _result.AuthorityForward = -1;
                    }

                    try
                    {
                        if (xn["authorityHold"] != null)
                            _result.AuthorityHold = Convert.ToInt32(xn["authorityHold"].InnerText);
                    }
                    catch
                    {
                        _result.AuthorityHold = -1;
                    }

                    try
                    {
                        if (xn["authorityFiction"] != null)
                            _result.AuthorityFiction = Convert.ToInt32(xn["authorityFiction"].InnerText);
                    }
                    catch
                    {
                        _result.AuthorityFiction = -1;
                    }

                    try
                    {
                        if (xn["authorityManuel"] != null)
                            _result.AuthorityManuel = Convert.ToInt32(xn["authorityManuel"].InnerText);
                    }
                    catch
                    {
                        _result.AuthorityManuel = -1;
                    }

                    try
                    {
                        if (xn["ticketNumber"] != null)
                            _result.TicketNumber = Convert.ToInt32(xn["ticketNumber"].InnerText);
                    }
                    catch
                    {
                        _result.TicketNumber = -1;
                    }
                    try
                    {
                        if (xn["deskNumber"] != null)
                            _result.DeskNumber = Convert.ToInt32(xn["deskNumber"].InnerText);
                    }
                    catch
                    {
                        _result.DeskNumber = -1;
                    }
                    try
                    {
                        if (xn["catCode"] != null)
                            _result.CatCode = Convert.ToInt32(xn["catCode"].InnerText);
                    }
                    catch
                    {
                        _result.CatCode = -1;
                    }
                    try
                    {
                        if (xn["catName"] != null)
                            _result.CatName = (xn["catName"].InnerText);
                    }
                    catch
                    {
                        _result.CatName = "";
                    }
                    try
                    {
                        if (xn["custName"] != null)
                            _result.CustName = (xn["custName"].InnerText);
                    }
                    catch
                    {
                        _result.CustName = "";
                    }
                    try
                    {
                        if (xn["waitingTime"] != null)
                            _result.WaitingTime = (xn["waitingTime"].InnerText);
                    }
                    catch
                    {
                        _result.WaitingTime = "";
                    }
                    try
                    {
                        if (xn["avgProcessTime"] != null)
                            _result.AvgProcessTime = (xn["avgProcessTime"].InnerText);
                    }
                    catch
                    {
                        _result.AvgProcessTime = "";
                    }
                    try
                    {
                        if (xn["servedCustCount"] != null)
                            _result.ServedCustCount = Convert.ToInt32(xn["servedCustCount"].InnerText);
                    }
                    catch
                    {
                        _result.ServedCustCount = -1;
                    }

                    try
                    {
                        if (xn["buttonNumber"] != null)
                            _result.ButtonNumber = Convert.ToInt32(xn["buttonNumber"].InnerText);
                    }
                    catch
                    {
                        _result.ButtonNumber = -1;
                    }
                    try
                    {
                        if (xn["waitingCustCount"] != null)
                            _result.WaitingCustCount = Convert.ToInt32(xn["waitingCustCount"].InnerText);
                    }
                    catch
                    {
                        _result.WaitingCustCount = -1;
                    }
                    try
                    {
                        if (xn["waitingButtonCount"] != null)
                            _result.WaitingButtonCount = Convert.ToInt32(xn["waitingButtonCount"].InnerText);
                    }
                    catch
                    {
                        _result.WaitingButtonCount = -1;
                    }

                    try
                    {
                        if (xn["custNo"] != null)
                            _result.CustNo = (xn["custNo"].InnerText);
                    }
                    catch
                    {
                        _result.CustNo = "";
                    }
                    try
                    {
                        if (xn["cardNo"] != null)
                            _result.CardNo = (xn["cardNo"].InnerText);
                    }
                    catch
                    {
                        _result.CardNo = "";
                    }
                    try
                    {
                        if (xn["cardStatus"] != null)
                            _result.CardStatus = (xn["cardStatus"].InnerText);
                    }
                    catch
                    {
                        _result.CardStatus = "";
                    }

                    try
                    {
                        if (xn["customerNo"] != null)
                            _result.CustomerNo = (xn["customerNo"].InnerText);
                    }
                    catch
                    {
                        _result.CustomerNo = "";
                    }

                    try
                    {
                        if (xn["processId"] != null)
                            _result.ProcessId = (xn["processId"].InnerText);
                    }
                    catch
                    {
                        _result.ProcessId = "";
                    }

                    try
                    {
                        if (xn["productionTime"] != null)
                            _result.ProductionTime = (xn["productionTime"].InnerText);
                    }
                    catch
                    {
                        _result.ProductionTime = "";
                    }
                }
            }

            catch
            {

            }
            return _result;
        }
    }
}

