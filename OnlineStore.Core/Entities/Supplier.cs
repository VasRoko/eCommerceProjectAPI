using OnlineStore.Core.Entities;
using System.Collections.Generic;

namespace OnlineStore.Domain.Entities
{
    public class Supplier
    {
        public Supplier()
        {
            Products = new HashSet<Product>();
        }

        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }

        public ICollection<Product> Products { get; private set; }
    }
}
