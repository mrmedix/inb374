using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace WebClient
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SalesSvc.SalesServiceClient client = new SalesSvc.SalesServiceClient();

            SalesSvc.Quote[] quotes = client.GetQuotes();

            List<SalesSvc.Quote> newQuotes = new List<SalesSvc.Quote>();
            List<SalesSvc.Quote> quotesCheckStock = new List<SalesSvc.Quote>();
            List<SalesSvc.Quote> quotesPendingApprovalETA = new List<SalesSvc.Quote>();

            foreach (SalesSvc.Quote q in quotes)
            {
                switch (q.Status)
                {
                    case SalesSvc.StatusCode.New:
                        newQuotes.Add(q);
                        break;
                    case SalesSvc.StatusCode.ApprovedCheckStock:
                        quotesCheckStock.Add(q);
                        break;
                    case SalesSvc.StatusCode.ETAPendingApproval:
                        quotesPendingApprovalETA.Add(q);
                        break;
                    default:
                        break;
                }
            }

            CheckStockCountLabel.Text = quotesCheckStock.Count.ToString();
            NewQuotesCountLabel.Text = newQuotes.Count.ToString();
            ETACountLabel.Text = quotesPendingApprovalETA.Count.ToString();

            
            
        }
    }
}