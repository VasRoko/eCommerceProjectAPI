using OnlineStore.Core.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineStore.Domain.Entities
{
    public class Customer : BaseEntity 
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public ICollection<Order> Orders { get; private set; }

    }


}
