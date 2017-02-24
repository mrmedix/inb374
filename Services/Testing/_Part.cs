using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Testing
{
    [DataContract]
    public class _Part : _Item
    {

        public _Part(int unitsInStock, int skill) : base()
        {
            
            UnitsInStock = unitsInStock;
            Skill = skill;


        }

        [DataMember]
        public int UnitsInStock
        {

            get;
            set;
        }

        [DataMember]
        public int Skill
        {

            get;
            set;
        }

    }
}