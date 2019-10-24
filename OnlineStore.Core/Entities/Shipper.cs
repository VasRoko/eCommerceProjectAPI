using OnlineStore.Core.SharedKernel;
using System.Collections.Generic;

namespace OnlineStore.Domain.Entities
{
    public class Shipper : BaseEntity
    {
        public Shipper()
        {
            Orders = new HashSet<Order>();
        }

        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostCode { get; set; }
        public string Country { get; set; }

        public ICollection<Order> Orders { get; private set; }
    }
}
