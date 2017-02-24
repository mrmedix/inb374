using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.IO;

namespace Testing
{
    class Program
    {
        private static SqlConnection connection = new SqlConnection("Data Source=fastapps04.qut.edu.au;Initial Catalog=n5499879;User ID=n5499879;Password=ohmedix");

        static void Main(string[] args)
        {

            #region Invoke REST webservice

            WebRequest wr = WebRequest.Create(@"http://localhost:8080/SupplierSvc/webresources/entities.part");
            wr.Method = "GET";

            HttpWebResponse response = wr.GetResponse() as HttpWebResponse;
            if (response.StatusCode == HttpStatusCode.OK)
            {
                using (Stream responseStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                    Console.WriteLine(reader.ReadToEnd());
                }
            }
            else
            {
                Console.WriteLine("Status Code: " + response.StatusCode + " ||| Status Description: " + response.StatusDescription);
            }
            #endregion


            /*
            List<SalesSvc.Item> items = new List<SalesSvc.Item>();

            Console.WriteLine(items.ToArray().Length);

            */

            /*
            #region Data Mod Quote
            //ServiceReference1.DataServiceClient client = new ServiceReference1.DataServiceClient();

            //ServiceReference1.Quote clQuote = client.GetQuote(14);

            //clQuote.CustomerID = 5;
            //clQuote.IsApproved = false;
            //clQuote.PartsETA = Convert.ToDateTime("11/10/14");
            //clQuote.ServiceDescription = "Workin' hard to get my fill, everybody wants a thrill!";

            //ServiceReference1.Item i1 = new ServiceReference1.Item();
            //i1.ID = 1;
            //i1.Quantity = 200;
            //ServiceReference1.Item i2 = new ServiceReference1.Item();
            //i2.ID = 2;
            //i2.Quantity = 1;

            //ServiceReference1.Item i3 = new ServiceReference1.Item();
            //i3.ID = 3;
            //i3.Quantity = 20;

            //ServiceReference1.Item[] items = {i1, i3};

            //clQuote.Items = items;

            //client.ModifyQuote(clQuote);


            //client.Close();
            #endregion

            SalesSvc.SalesServiceClient client = new SalesSvc.SalesServiceClient();

            SalesSvc.Quote quote = new SalesSvc.Quote();
            quote.ServiceDescription = "Testing app Console";
            quote.AdditionalLabourPrice = 50;
            quote.CustomerID = 4;

            SalesSvc.Item i1 = new SalesSvc.Item();
            i1.ID = 3;
            i1.Quantity = 2;

            SalesSvc.Item i2 = new SalesSvc.Item();
            i2.ID = 5;
            i2.Quantity = 6;

            SalesSvc.Item[] items = { i1, i2 };

            quote.Items = items;

            quote.ID = client.AddNewQuote(quote);

            */
        }

        private static int AddNewQuote(_Quote quote)
        {
            SqlCommand cmdQuote = new SqlCommand("INSERT INTO Quote (TotalServiceTime, CustomerID, ServiceDescription, AdditionalLabourPrice) " +
                "VALUES (@totalServiceTime, @customerID, @serviceDescription, @additionalLabourPrice)", connection);
            cmdQuote.Parameters.Add("@totalServiceTime", SqlDbType.Int).Value = quote.TotalServiceTime;
            cmdQuote.Parameters.Add("@customerID", SqlDbType.Int).Value = quote.CustomerID;
            cmdQuote.Parameters.Add("@serviceDescription", SqlDbType.Text).Value = quote.ServiceDescription;
            cmdQuote.Parameters.Add("@additionalLabourPrice", SqlDbType.Int).Value = quote.AdditionalLabourPrice;

            try
            {
                connection.Open();
                quote.ID = Convert.ToInt32(cmdQuote.ExecuteScalar());
                /*
                foreach (Item i in quote.Items)
                {
                    SqlCommand cmdQP = new SqlCommand("INSERT INTO QuotePart VALUES(" + quote.ID + "," + i.ID + "," + i.Quantity + ")", connection);
                    cmdQP.ExecuteNonQuery();
                }*/
            }
            finally
            {
                connection.Close();
            }

            return quote.ID;
        }

        private static void sqlGetQuotes()
        {

            //SqlConnection connection = new SqlConnection("Data Source=fastapps04.qut.edu.au;Initial Catalog=n5499879;User ID=n5499879;Password=ohmedix");


            List<_Quote> quotes = new List<_Quote>();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Quote", connection);
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    _Quote q = new _Quote();
                    q.TotalServiceTime = reader.GetInt32(1);
                    q.PartsETA = reader.GetDateTime(3);
                    q.IsApproved = reader.GetBoolean(4);
                    q.PurchaseOrderID = reader.GetInt32(5);
                    q.ServiceDescription = reader.GetString(7);
                    q.AdditionalLabourPrice = reader.GetInt32(8);
                    quotes.Add(q);
                }
                reader.Close();

                foreach (_Quote q in quotes)
                {
                    cmd.CommandText = "SELECT * FROM QuotePart qp INNER JOIN WarehouseStock whs ON qp.PartID = whs.PartID WHERE qp.QuoteID=" + q.ID;
                    SqlDataReader r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        _Item i = new _Item();
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



        }
        private static void sqlGetCustomers()
        {
            //SqlConnection connection = new SqlConnection("Data Source=fastapps04.qut.edu.au;Initial Catalog=n5499879;User ID=n5499879;Password=ohmedix");



            SqlCommand cmd = new SqlCommand("SELECT CustomerID, Name, Street, Postcode, Email FROM Customer", connection);
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    Console.WriteLine(reader.GetInt32(0));
                    Console.WriteLine(reader.GetString(1));
                    Console.WriteLine(reader.GetString(2));
                    Console.WriteLine(reader.GetString(3));
                    Console.WriteLine(reader.GetString(4));


                }
                reader.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {

                connection.Close();
            }
        }
    }
}
