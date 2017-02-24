using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Data
{
    [DataContract]
    public class Customer
    {

        public Customer()
        {

        }
        public Customer(int id)
        {
            ID = id;
        }

        public Customer(int id, string name, string street, string postcode, string email)
        {
            ID = id;
            Name = name;
            Street = street;
            Postcode = postcode;
            Email = email;
        }

        [DataMember]
        public int ID
        {
            get;
            set;
        }

        [DataMember]
        public string Name
        {
            get; 
            set; 
        }

        [DataMember]
        public string Street
        {
            get;
            set;
        }

        [DataMember]
        public string Postcode
        {
            get; 
            set; 
        }

        [DataMember]
        public string Email
        {
            get;
            set;
        }
    }
}
