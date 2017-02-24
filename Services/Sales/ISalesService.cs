using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Sales
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISalesService" in both code and config file together.
    [ServiceContract]
    public interface ISalesService
    {
        [OperationContract]
        DataSvc.Customer[] GetCustomers();

        [OperationContract]
        DataSvc.Customer GetCustomer(int customerID);

        [OperationContract]
        DataSvc.Quote[] GetQuotes();

        [OperationContract]
        DataSvc.Quote GetQuote(int quoteID);

        [OperationContract]
        int AddNewQuote(DataSvc.Quote quote);

        [OperationContract]
        void ModifyQuote(DataSvc.Quote quote);
        
        [OperationContract]
        DataSvc.Item[] GetItems();

        [OperationContract]
        void ApproveQuote(int quoteID);

        [OperationContract]
        void RejectQuote(int quoteID);

        [OperationContract]
        DateTime GetPartETA(string description);

        [OperationContract]
        DataSvc.Item[] CheckItemsStockLevel(DataSvc.Item[] items);
    }
}
