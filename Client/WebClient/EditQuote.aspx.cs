using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebClient
{
    public partial class EditQuote : System.Web.UI.Page
    {
        SalesSvc.SalesServiceClient client = new SalesSvc.SalesServiceClient();
        SalesSvc.Quote quote;

        List<SalesSvc.Customer> customers = new List<SalesSvc.Customer>();
        List<SalesSvc.Item> parts = new List<SalesSvc.Item>();

        Array statusNames = System.Enum.GetNames(typeof(SalesSvc.StatusCode));


        protected void Page_Load(object sender, EventArgs e)
        {

            quote = client.GetQuote(Convert.ToInt32(Request.QueryString["quote"]));
            QuoteNumberLabel.Text = quote.ID.ToString();


            customers = client.GetCustomers().ToList();
            parts = client.GetItems().ToList();

            if (!IsPostBack)
            {
                CustomerDropDownList.DataSource = customers;
                CustomerDropDownList.DataTextField = "Name";
                CustomerDropDownList.DataValueField = "ID";
                CustomerDropDownList.DataBind();
                CustomerDropDownList.SelectedValue = quote.CustomerID.ToString();

                PartDropDownList1.DataSource = parts;
                PartDropDownList1.DataTextField = "Description";
                PartDropDownList1.DataValueField = "ID";
                PartDropDownList1.DataBind();
                PartDropDownList1.SelectedValue = quote.Items[0].ID.ToString();

                QuantityTextBox1.Text = quote.Items[0].Quantity.ToString();

                LabourPriceTextBox.Text = quote.LabourPrice.ToString();
                LabourTextArea.InnerText = quote.ServiceDescription;

                ETALabel.Text = quote.PartsETA.ToShortDateString();

                for (int i = 0; i < statusNames.Length; i++)
                {
                    ListItem item = new ListItem(Convert.ToString(statusNames.GetValue(i)), Convert.ToString(i));
                    StatusDropDownList.Items.Add(item);
                }
                StatusDropDownList.SelectedValue = Convert.ToInt32(quote.Status).ToString();

            }


            #region Display appropriate LinkButtons
            switch (quote.Status)
            {
                case SalesSvc.StatusCode.New:
                    ApproveLinkButton.Visible = true;
                    RejectLinkButton.Visible = true;
                    break;

                case SalesSvc.StatusCode.ApprovedCheckStock:
                    CheckStockLinkButton.Visible = true;
                    RejectLinkButton.Visible = true;
                    break;

                case SalesSvc.StatusCode.ApprovedBookService:
                    BookLinkButton.Visible = true;
                    RejectLinkButton.Visible = true;
                    break;

                case SalesSvc.StatusCode.ApprovedNotInStock:
                    GetETALinkButton.Visible = true;
                    RejectLinkButton.Visible = true;
                    break;

                case SalesSvc.StatusCode.ETAPendingApproval:
                    ApproveLinkButton.Visible = true;
                    RejectLinkButton.Visible = true;
                    break;

                case SalesSvc.StatusCode.ApprovedETA:
                    BookLinkButton.Visible = true;
                    BookLinkButton.Text = "Book & send purchase order";
                    RejectLinkButton.Visible = true;
                    break;

                case SalesSvc.StatusCode.Booked:
                    RejectLinkButton.Visible = true;
                    break;

                default:
                    break;
            }
            #endregion


        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            quote.CustomerID = Convert.ToInt32(CustomerDropDownList.SelectedItem.Value);
            quote.LabourPrice = Convert.ToInt32(LabourPriceTextBox.Text);
            quote.ServiceDescription = LabourTextArea.InnerText;
            quote.Items = GetSelectedItems();
            SalesSvc.StatusCode sc = (SalesSvc.StatusCode)Convert.ToInt32(StatusDropDownList.SelectedItem.Value);
            quote.Status = sc;


            client.ModifyQuote(quote);

            Response.Redirect(Request.RawUrl);
        }

        private SalesSvc.Item[] GetSelectedItems()
        {
            List<SalesSvc.Item> selectedItems = new List<SalesSvc.Item>();
            foreach (SalesSvc.Item i in parts)
            {
                if (i.ID == Convert.ToInt32(PartDropDownList1.SelectedItem.Value))
                {
                    i.Quantity = Convert.ToInt32(QuantityTextBox1.Text);
                    selectedItems.Add(i);
                }
            }
            return selectedItems.ToArray();
        }

        protected void ApproveLinkButton_Click(object sender, EventArgs e)
        {
            client.ApproveQuote(quote.ID);
            Response.Redirect(Request.RawUrl);
        }

        protected void CheckStockLinkButton_Click(object sender, EventArgs e)
        {
            StatusLiteral.Text = "";


           SalesSvc.Item[] outofstockItems = client.CheckItemsStockLevel(quote.Items);

            if (outofstockItems.Length > 0)
            {
                quote.Status = SalesSvc.StatusCode.ApprovedNotInStock;

                foreach (SalesSvc.Item i in outofstockItems)
                {
                    StatusLiteral.Text += "Not enough stock in warehouse of part: " + i.Description + ". Quantity required to order: " + i.Quantity + "<br />";
                }
            }
            else
            {
                quote.Status = SalesSvc.StatusCode.ApprovedBookService;
                StatusLiteral.Text = "All items in stock.";
            }
            
            client.ModifyQuote(quote);
        }

        protected void GetETALinkButton_Click(object sender, EventArgs e)
        {
            SalesSvc.Item[] outofstockItems = client.CheckItemsStockLevel(quote.Items);

            quote.PartsETA = client.GetPartETA(outofstockItems[0].Description);

            quote.Status = SalesSvc.StatusCode.ETAPendingApproval;

            client.ModifyQuote(quote);

            Response.Redirect(Request.RawUrl);
        }

        protected void BookLinkButton_Click(object sender, EventArgs e)
        {
            /*
            if (quote.Status == SalesSvc.StatusCode.ApprovedETA)
                client.SendPurchaseOrder(quote.ID);
             * */

            quote.Status = SalesSvc.StatusCode.Booked;
            StatusLiteral.Text = "Service booked, sent confirmation to customer.";
            
            client.ModifyQuote(quote);
        }

        protected void RejectLinkButton_Click(object sender, EventArgs e)
        {
            quote.Status = SalesSvc.StatusCode.Rejected;
            client.ModifyQuote(quote);
            Response.Redirect(Request.RawUrl);
        }

    }
}