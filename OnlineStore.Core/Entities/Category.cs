using OnlineStore.Core.SharedKernel;
using System.Collections.Generic;

namespace OnlineStore.Core.Entities
{
    public class Category : BaseEntity
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public string CategoryName { get; set; }
        public string Description { get; set; }
        public string PhotoUrl { get; set; }
        public ICollection<Product> Products { get; private set; }
    }
}
