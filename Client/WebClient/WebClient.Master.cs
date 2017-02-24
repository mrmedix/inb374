using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebClient
{
    public partial class Client : System.Web.UI.MasterPage
    {
        SalesSvc.SalesServiceClient client = new SalesSvc.SalesServiceClient();
        SalesSvc.Quote[] quotes;
        SalesSvc.Customer[] customers;
        protected void Page_Load(object sender, EventArgs e)
        {
            quotes = client.GetQuotes();
            quotes = quotes.Reverse().ToArray();
            customers = client.GetCustomers();
            QuotesListLiteral.Text = "";
            foreach (SalesSvc.Quote q in quotes)
            {
                int i = findIndex(customers, q.CustomerID);
                QuotesListLiteral.Text += "<a href=\"EditQuote.aspx?quote=" + q.ID + "\"><li>" + customers[i].Name + "<br />" + q.Status + "<br />" + q.ServiceDescription + "</li></a>";

            }
        }

        private int findIndex(SalesSvc.Customer[] customers, int customerID)
        {
            int index = 0;
            for (int i = 0; i < customers.Length; i++)
            {
                if (customers[i].ID == customerID)
                    index = i;
            }
            return index;
        }
    }
}