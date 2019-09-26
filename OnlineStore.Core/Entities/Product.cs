using System;
using System.Collections.Generic;
using OnlineStore.Core.SharedKernel;

namespace OnlineStore.Core.Entities
{
    public class Product : BaseEntity
    {
        public string Title { get; set; }
        public string Excerpt { get; set; }
        public DateTime Date { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
        public ProductDetails ProductDetails { get; set; }
        public ICollection<ProductReviews> ProductReviews { get; set; }
    }

    public class ProductDetails : BaseEntity
    {
        public string Tags { get; set; }
        public string Size { get; set; }
        public string ShippingCodes { get; set; }
        public int InStock { get; set; }
        public string PhotoURL { get; set; }
    }

    public class ProductReviews : BaseEntity
    {
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
        public int Stars { get; set; }
        public string Message { get; set; }
    }


}
