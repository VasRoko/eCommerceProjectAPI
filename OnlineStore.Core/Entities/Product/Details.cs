using OnlineStore.Domain.Entities.Product;
using System;

namespace OnlineStore.Domain.Entities.Product
{
    public class Details
    {
        public string Size { get; set; }
        public string Weight { get; set; }
        public string Tags { get; set; }
        public string PhotoURL { get; set; }
        public Guid ItemId { get; set; }
        public Item Item { get; set; }
    }
}
