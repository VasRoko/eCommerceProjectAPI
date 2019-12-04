using OnlineStore.Core.SharedKernel;
using System.Collections.Generic;

namespace OnlineStore.Domain.Entities.Product
{
    public class Category : BaseEntity
    {
        public Category()
        {
            Items = new HashSet<Item>();
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public ICollection<Item> Items { get; private set; }
    }
}
