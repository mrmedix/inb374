using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Data
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IDataService" in both code and config file together.
    [ServiceContract]
    public interface IDataService
    {
        [OperationContract]
        Customer[] GetCustomers();

        [OperationContract]
        Customer GetCustomer(int customerID);

        [OperationContract]
        Quote[] GetQuotes();

        [OperationContract]
        Quote GetQuote(int quoteID);

        [OperationContract]
        int AddNewQuote(Quote quote);

        [OperationContract]
        void ModifyQuote(Quote quote);

        [OperationContract]
        Item[] GetItems();

        [OperationContract]
        string HelloWorld();
    }
}
