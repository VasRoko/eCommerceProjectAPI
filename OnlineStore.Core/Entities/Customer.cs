using OnlineStore.Core.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineStore.Domain.Entities
{
    public class Customer : BaseEntity 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNumber { get; set; }
        public BillingAddress customerBillingAddress { get; set; }
        public ShippingAddress shippingAddress { get; set; }
    }

    public class BillingAddress : BaseEntity 
    {
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }
        public string AddressLine1 { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }

    }

    public class ShippingAddress : BaseEntity
    {
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }
    }

}
