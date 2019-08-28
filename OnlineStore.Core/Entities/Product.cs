using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using OnlineStore.Core.SharedKernel;

namespace OnlineStore.Core.Entities
{
    public class Product : BaseEntity
    {
        public string Title { get; set; }
        public DateTime DateAdded { get; set; }
        public Size? Size { get; set; }
        public string Tag { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal? UnitPrice { get; set; }
        public short? UnitsInStock { get; set; }
        public bool Discontinued { get; set; }
        public string PhotoUrl { get; set; }
        public Guid? SupplierId { get; set; }
        public Guid? CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<Photo> Photos { get; set; }
        public void SetDateAdded()
        {
            DateAdded = DateTime.Now;
        }
    }

    public enum Size
    {
        xxs,
        xs,
        s,
        m,
        l,
        xl,
        xxl,
        xxxl
    }
}
