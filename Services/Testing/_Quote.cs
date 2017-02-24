using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Testing
{
    [DataContract]
    public class _Quote
    {
        LinkedList<_Item> items;

        public _Quote()
        {
            items = new LinkedList<_Item>();
        }
        public _Quote(int quoteID)
        {
            ID = quoteID;
            items = new LinkedList<_Item>();
        }

        public void AddItem(_Item item)
        {
            items.AddLast(item);
        }

        [DataMember]
        public _Item[] Items
        {
            get { return items != null ? items.ToArray() : null; }
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
        public bool IsApproved
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
        public int AdditionalLabourPrice { get; set; }
    }
}
