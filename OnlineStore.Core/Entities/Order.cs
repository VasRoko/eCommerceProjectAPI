using System;
using OnlineStore.Core.Entities;
using OnlineStore.Core.SharedKernel;
using System.Collections.Generic;

namespace OnlineStore.Domain.Entities
{
    public class Order : BaseEntity
    {
        public Order()
        {

        }

        public int orderNumber { get; set; }
        public Guid CustomerId { get; set; }
        public Guid SupplierId { get; set; }
        public Guid ShipperId { get; set; }
        public DateTime OrderPlaced { get; set; } = DateTime.Now;
        public bool OrderPaid { get; set; }
        public ICollection<Product> Products { get; private set; }
    }
}
