using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Data
{
    [DataContract]
    public class Item
    {
        public Item() { }
        public Item(int id, string description, int price, int serviceTime, int quantity)
        {
            ID = id;
            Description = description;
            Price = price;
            ServiceTime = serviceTime;
            Quantity = quantity;

        }

        [DataMember]
        public int ID
        {
            get;
            set;
        }

        [DataMember]
        public string Description
        {
            get;
            set;
        }

        [DataMember]
        public int Price
        {
            get;
            set;
        }


        [DataMember]
        public int ServiceTime
        {
            get;
            set;
        }

        [DataMember]
        public int Quantity { get; set; }
    }
}