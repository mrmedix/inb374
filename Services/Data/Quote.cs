using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Data

{
    [DataContract]
    public enum StatusCode
    {
        [EnumMember]
        New,
        [EnumMember]
        ApprovedCheckStock,
        [EnumMember]
        ApprovedBookService,
        [EnumMember]
        ApprovedNotInStock,
        [EnumMember]
        ETAPendingApproval,
        [EnumMember]
        ApprovedETA,
        [EnumMember]
        Booked,
        [EnumMember]
        Rejected
    }

    [DataContract]
    public class Quote
    {
        List<Item> items;

        public Quote()
        {
            items = new List<Item>();
        }
        public Quote(int quoteID)
        {
            ID = quoteID;
            items = new List<Item>();
        }
                
        public void AddItem(Item item)
        {
            items.Add(item);
        }

        [DataMember]
        public Item[] Items
        {
            get { return items != null ? items.ToArray() : null; }
            set
            {
                if (value != null)
                    items = value.ToList<Item>();
                else
                    items = null;
            }
        }

        [DataMember]
        public int ID
        {
            get;
            set;
        }

        [DataMember]
        public int CustomerID { get; set; }

        [DataMember]
        public int TotalServiceTime
        {
            get;
            set;
        }

        [DataMember]
        public DateTime PartsETA
        {
            get;
            set;
        }

        [DataMember]
        public StatusCode Status
        {
            get;
            set;
        }

        [DataMember]
        public int PurchaseOrderID
        {
            get;
            set;
        }

        [DataMember]
        public string ServiceDescription { get; set; }

        [DataMember]
        public int LabourPrice { get; set; }
    }
}
