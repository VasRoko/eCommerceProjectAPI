using System;
using OnlineStore.Core.Entities;
using OnlineStore.Core.SharedKernel;
using System.Collections.Generic;

namespace OnlineStore.Domain.Entities
{
    public class Order : BaseEntity
    {
        public string OrderStatus { get; set; }
        public DateTime OrderDate { get; set; }
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }
        public OrderDetails OrderDetails { get; set; }
    }

    public class OrderDetails : BaseEntity
    {
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
        public short Quantity { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipRegion { get; set; }
        public string ShipPostCode { get; set; }
        public string ShipCountry { get; set; }
    }
}
