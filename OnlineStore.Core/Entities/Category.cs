using OnlineStore.Core.SharedKernel;
using System.Collections.Generic;

namespace OnlineStore.Core.Domain.Entities
{
    public class Category : BaseEntity
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public ICollection<Product> Products { get; private set; }
    }
}
