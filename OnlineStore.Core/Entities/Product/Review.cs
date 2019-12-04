using OnlineStore.Domain.Entities;
using OnlineStore.Domain.Entities.Product;
using OnlineStore.Core.SharedKernel;
using System;

namespace OnlineStore.Domain.Entities.Product
{
    public class Review : BaseEntity
    {
        public Guid ItemId { get; set; }
        public Item Item { get; set; }
        public DateTime Date { get; set; }
        public short Rate { get; set; }
        public string Comment { get; set; }
    }
}
