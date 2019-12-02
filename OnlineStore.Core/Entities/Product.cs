using System;
using System.Collections.Generic;
using OnlineStore.Core.SharedKernel;

namespace OnlineStore.Core.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal? UnitPrice { get; set; }
        public short? UnitsInStock { get; set; }
        public double Price { get; set; }
        public Guid CategoryId { get; set; }
        public string Description { get; set; }
        public ProductDetails ProductDetails { get; set; }
        public ICollection<ProductReview> ProductReviews { get; set; }
        public bool Discontinued { get; private set; }

        public void SetDiscontinued()
        {
            Discontinued = true;
        }

    }

    public class ProductDetails : BaseEntity
    {
        public string Size { get; set; }
        public string Tags { get; set; }
        public string PhotoURL { get; set; }
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
    }

    public class ProductReview : BaseEntity
    {
        public int Score { get; set; }
        public string Message { get; set; }
        public Product Product { get; set; }
    }
}
