using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace Data
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "DataService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select DataService.svc or DataService.svc.cs at the Solution Explorer and start debugging.
    public class DataService : IDataService
    {
        SqlConnection connection = new SqlConnection("Data Source=fastapps04.qut.edu.au;Initial Catalog=n5499879;User ID=n5499879;Password=ohmedix");
        //SqlConnection connection = new SqlConnection("Data Source=mrmedixi5;Initial Catalog=ServicingAutos;Trusted_Connection=True");       

        public Customer GetCustomer(int customerID)
        {
            SqlCommand cmd = new SqlCommand("SELECT CustomerID, Name, Street, Postcode, Email FROM Customer WHERE CustomerID=" + customerID, connection);
            Customer c = new Customer(customerID);
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    c.Name = reader.GetString(1);
                    c.Street = reader.GetString(2);
                    c.Postcode = reader.GetString(3);
                    c.Email = reader.GetString(4);
                }

                reader.Close();
            }
            finally
            {
                connection.Close();
            }

            return c;
        }
        public Customer[] GetCustomers()
        {
            List<Customer> customers = new List<Customer>();

            SqlCommand cmd = new SqlCommand("SELECT CustomerID, Name, Street, Postcode, Email FROM Customer", connection);
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Customer c = new Customer(reader.GetInt32(0));
                    c.Name = reader.GetString(1);
                    c.Street = reader.GetString(2);
                    c.Postcode = reader.GetString(3);
                    c.Email = reader.GetString(4);

                    customers.Add(c);
                }
                reader.Close();
            }
            finally
            {
                connection.Close();
            }

            return customers.ToArray();
        }

        public Quote[] GetQuotes()
        {

            List<Quote> quotes = new List<Quote>();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Quote", connection);
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    Quote q = new Quote(reader.GetInt32(0));
                    q.TotalServiceTime = reader.GetInt32(1);
                    q.CustomerID = reader.GetInt32(2);
                    q.PartsETA = reader.GetDateTime(3);
                    q.Status = (StatusCode)reader.GetInt32(4);
                    q.PurchaseOrderID = reader.GetInt32(5);
                    q.ServiceDescription = reader.GetString(7);
                    q.LabourPrice = reader.GetInt32(8);
                    quotes.Add(q);
                }
                reader.Close();

                foreach (Quote q in quotes)
                {
                    cmd.CommandText = "SELECT * FROM QuotePart qp INNER JOIN WarehouseStock whs ON qp.PartID = whs.PartID WHERE qp.QuoteID=" + q.ID;
                    SqlDataReader r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        Item i = new Item();
                        i.ID = r.GetInt32(1);
                        i.Quantity = r.GetInt32(2);
                        i.Description = r.GetString(4);
                        i.Price = r.GetInt32(5);
                        i.ServiceTime = r.GetInt32(7);
                        q.AddItem(i);
                    }
                    r.Close();
                }
            }
            finally
            {
                connection.Close();
            }

            return quotes.ToArray();
        }

        public int AddNewQuote(Quote quote)
        {
            SqlCommand cmdQuote = new SqlCommand("INSERT INTO Quote (TotalServiceTime, CustomerID, ServiceDescription, LabourPrice) OUTPUT INSERTED.QuoteID " +
                "VALUES (@totalServiceTime, @customerID, @serviceDescription, @labourPrice)", connection);
            cmdQuote.Parameters.Add("@totalServiceTime", SqlDbType.Int).Value = quote.TotalServiceTime;
            cmdQuote.Parameters.Add("@customerID", SqlDbType.Int).Value = quote.CustomerID;
            cmdQuote.Parameters.Add("@serviceDescription", SqlDbType.Text).Value = quote.ServiceDescription;
            cmdQuote.Parameters.Add("@labourPrice", SqlDbType.Int).Value = quote.LabourPrice;

            try
            {
                connection.Open();
                quote.ID = Convert.ToInt32(cmdQuote.ExecuteScalar());

                AddQuoteItems(quote.Items, quote.ID);
            }
            finally
            {
                connection.Close();
            }

            return quote.ID;
        }
        private void AddQuoteItems(Item[] items, int quoteID)
        {

            if (items != null)
            {
                foreach (Item i in items)
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO QuotePart VALUES(" + quoteID + "," + i.ID + "," + i.Quantity + ")", connection);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        private void DeleteQuoteItems(int quoteID)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM QuotePart WHERE QuoteID = " + quoteID, connection);
            cmd.ExecuteNonQuery();
        }
        public void ModifyQuote(Quote quote)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Quote SET TotalServiceTime = @time, CustomerID = @cID, PartsETA = @eta, Status = @status," +
                "PurchaseOrderID = @poID, ServiceDescription = @description, LabourPrice = @labourPrice WHERE QuoteID =" + quote.ID, connection);
            cmd.Parameters.Add("@time", SqlDbType.Int).Value = quote.TotalServiceTime;
            cmd.Parameters.Add("@cID", SqlDbType.Int).Value = quote.CustomerID;
            cmd.Parameters.Add("@eta", SqlDbType.SmallDateTime).Value = quote.PartsETA;
            cmd.Parameters.Add("@status", SqlDbType.Int).Value = quote.Status;
            cmd.Parameters.Add("@poID", SqlDbType.Int).Value = quote.PurchaseOrderID;
            cmd.Parameters.Add("@description", SqlDbType.Text).Value = quote.ServiceDescription;
            cmd.Parameters.Add("@labourPrice", SqlDbType.Int).Value = quote.LabourPrice;

            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();
                DeleteQuoteItems(quote.ID);
                AddQuoteItems(quote.Items, quote.ID);

            }
            finally
            {
                connection.Close();
            }

        }

        public Quote GetQuote(int quoteID)
        {
            Quote q = new Quote(quoteID);
            SqlCommand cmd = new SqlCommand("SELECT * FROM Quote WHERE QuoteID=" + quoteID, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    q.TotalServiceTime = reader.GetInt32(1);
                    q.CustomerID = reader.GetInt32(2);
                    q.PartsETA = reader.GetDateTime(3);
                    q.Status = (StatusCode)reader.GetInt32(4);
                    q.PurchaseOrderID = reader.GetInt32(5);
                    q.ServiceDescription = reader.GetString(7);
                    q.LabourPrice = reader.GetInt32(8);
                }
                reader.Close();

                cmd.CommandText = "SELECT * FROM QuotePart qp INNER JOIN WarehouseStock whs ON qp.PartID = whs.PartID WHERE qp.QuoteID=" + quoteID;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Item i = new Item();
                    i.ID = reader.GetInt32(1);
                    i.Quantity = reader.GetInt32(2);
                    i.Description = reader.GetString(4);
                    i.Price = reader.GetInt32(5);
                    i.ServiceTime = reader.GetInt32(7);
                    q.AddItem(i);
                }
                reader.Close();

            }
            finally
            {
                connection.Close();
            }

            return q;
        }

        public Item[] GetItems()
        {
            List<Item> items = new List<Item>();
            SqlCommand cmd = new SqlCommand("SELECT * FROM WarehouseStock", connection);
            try
            {
                connection.Open();
                SqlDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    Item i = new Item();
                    i.ID = r.GetInt32(0);
                    i.Description = r.GetString(1);
                    i.Price = r.GetInt32(2);
                    i.Quantity = r.GetInt32(3);
                    i.ServiceTime = r.GetInt32(4);

                    items.Add(i);
                }
                r.Close();
            }
            finally
            {
                connection.Close();
            }

            return items.ToArray();
        }

        #region GetItem(int itemID)
        /*
        public Item GetItem(int itemID)
        {
            Item i = new Item();
            SqlCommand cmd = new SqlCommand("SELECT * FROM WarehouseStock WHERE PartID = "+itemID, connection);

            try
            {
                SqlDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    i.ID = r.GetInt32(0);
                    i.Description = r.GetString(1);
                    i.Price = r.GetInt32(2);
                    i.ServiceTime = r.GetInt32(4);
                }
                r.Close();
            }
            finally
            {
                connection.Close();
            }


            return i;
        }
        */
        #endregion

        public string HelloWorld()
        {
            return "Hello World!";
        }
    }
}
