using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Xml.Linq;

namespace Sales
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SalesService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select SalesService.svc or SalesService.svc.cs at the Solution Explorer and start debugging.
    public class SalesService : ISalesService
    {
        private DataSvc.DataServiceClient client = new DataSvc.DataServiceClient();

        private List<DataSvc.Item> poItems = new List<DataSvc.Item>();
        private int poID = 0;

        public DataSvc.Quote[] GetQuotes()
        {
            return client.GetQuotes();
        }

        public DataSvc.Quote GetQuote(int quoteID)
        {
            return client.GetQuote(quoteID);
        }

        public int AddNewQuote(DataSvc.Quote quote)
        {
            quote.TotalServiceTime = calcServiceTime(quote.Items);
            return client.AddNewQuote(quote);
        }

        public void ModifyQuote(DataSvc.Quote quote)
        {
            quote.TotalServiceTime = calcServiceTime(quote.Items);
            client.ModifyQuote(quote);
        }

        public DataSvc.Item[] GetItems()
        {
            return client.GetItems();
        }

        public void ApproveQuote(int quoteID)
        {
            DataSvc.Quote q = client.GetQuote(quoteID);
            if (q.Status == DataSvc.StatusCode.New )
            {
                q.Status = DataSvc.StatusCode.ApprovedCheckStock;
            }
            else if (q.Status == DataSvc.StatusCode.ETAPendingApproval)
            {
                q.Status = DataSvc.StatusCode.ApprovedETA;
            }
            
            client.ModifyQuote(q);
        }

        public void RejectQuote(int quoteID)
        {
            DataSvc.Quote q = client.GetQuote(quoteID);
            q.Status = DataSvc.StatusCode.Rejected;

            client.ModifyQuote(q);
        }

        public void NotifyCustomer(int quoteID)
        {

        }

        private void SendPurchaseOrder(int quoteID, DataSvc.Item[] items)
        {
        }

        public DateTime GetPartETA(string partSKU)
        {
            #region Invoke REST webservice

            int numDays = 0;

            WebRequest wr = WebRequest.Create(@"http://fastws.qut.edu.au:8080/n5499879SupplierSvc/webresources/entities.part/" + partSKU);

            wr.Method = "GET";

            HttpWebResponse response = wr.GetResponse() as HttpWebResponse;
             
            if (response.StatusCode == HttpStatusCode.OK)
            {
                using (Stream responseStream = response.GetResponseStream())
                {
                    XDocument xmlDoc = new XDocument();

                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                    xmlDoc = XDocument.Parse(reader.ReadToEnd());

                    numDays = Convert.ToInt32(xmlDoc.Root.Element("leadDays").Value);
                }
            }
            else
            {
                Console.WriteLine("Status Code: " + response.StatusCode + " ||| Status Description: " + response.StatusDescription);
            }
            #endregion

            return DateTime.Today.Add(TimeSpan.FromDays(numDays));
        }
        private int calcServiceTime(DataSvc.Item[] items)
        {
            int totalTime = 0;
            if (items != null)
            {
                for (int i = 0; i < items.Length; i++)
                {
                    totalTime += items[i].ServiceTime * items[i].Quantity;
                }
            }

            return totalTime;
        }

        public DataSvc.Item[] CheckItemsStockLevel(DataSvc.Item[] items)
         {
            DataSvc.Item[] stockedItems = GetItems();

            foreach (DataSvc.Item i in items)
            {
                // TODO: LINQ Baby!! ehhh not so simple after all @__@

                var resultItems = from item in stockedItems where item.ID == i.ID select item;
                foreach (var r in resultItems)
                {
                    if (i.Quantity > r.Quantity)
                    {
                        poItems.Add(r);
                        r.Quantity = i.Quantity - r.Quantity;
                    }
                }
                
            }


            return poItems.ToArray();
        }

        public DataSvc.Customer[] GetCustomers()
        {
            return client.GetCustomers();
        }

        public DataSvc.Customer GetCustomer(int customerID)
        {
            return client.GetCustomer(customerID);
        }
    }
}
