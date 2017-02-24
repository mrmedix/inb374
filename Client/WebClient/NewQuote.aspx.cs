using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebClient
{
    public partial class NewQuote : System.Web.UI.Page
    {
        SalesSvc.SalesServiceClient client = new SalesSvc.SalesServiceClient();

        List<SalesSvc.Customer> customers = new List<SalesSvc.Customer>();
        List<SalesSvc.Item> parts = new List<SalesSvc.Item>();
        SalesSvc.Quote quote = new SalesSvc.Quote();

        protected void Page_Load(object sender, EventArgs e)
        {
            customers = client.GetCustomers().ToList();
            parts = client.GetItems().ToList();

            if (!IsPostBack)
            {

                CustomerDropDownList.DataSource = customers;
                CustomerDropDownList.DataTextField = "Name";
                CustomerDropDownList.DataValueField = "ID";
                CustomerDropDownList.DataBind();

                PartDropDownList1.DataSource = parts;
                PartDropDownList1.DataTextField = "Description";
                PartDropDownList1.DataValueField = "ID";
                PartDropDownList1.DataBind();
                PartDropDownList1.Items.Add("-");
                PartDropDownList1.SelectedValue = "-";

            }
        }

        protected void SaveQuoteButton_Click(object sender, EventArgs e)
        {
            quote.CustomerID = Convert.ToInt32(CustomerDropDownList.SelectedItem.Value);
            quote.LabourPrice = Convert.ToInt32(LabourPriceTextBox.Text);
            quote.ServiceDescription = LabourTextArea.InnerText;
            quote.Items = GetSelectedItems();

            int newID = client.AddNewQuote(quote);
            if (IsPostBack)
                StatusLabel.Text = "New quote ID is " + newID.ToString();
        }

        private SalesSvc.Item[] GetSelectedItems()
        {
            List<SalesSvc.Item> selectedItems = new List<SalesSvc.Item>();
            foreach (SalesSvc.Item i in parts)
            {
                if (i.ID == Convert.ToInt32(PartDropDownList1.SelectedValue))
                {
                    i.Quantity = Convert.ToInt32(QuantityTextBox1.Text);
                    selectedItems.Add(i);
                }
            }
            return selectedItems.ToArray();
        }
    }
}