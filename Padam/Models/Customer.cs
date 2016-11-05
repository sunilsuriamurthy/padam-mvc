using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Padam.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        public MembershipType MembershipType { get; set; }
        public byte MembershipTypeID { get; set; }
    }
}