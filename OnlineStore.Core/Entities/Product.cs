using System;
using OnlineStore.Core.SharedKernel;

namespace OnlineStore.Core.Entities
{
    public class Product : BaseEntity
    {
        public string Title { get; set; }
        public string Excerpt { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public ProductDetails ProductDetails { get; set; }
    }

    public class ProductDetails : BaseEntity
    {
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
        public string[] Tags { get; set; }
        public string[] Size { get; set; }
        public string[] ShippingCodes { get; set; }
        public int InStock { get; set; }
        public string PhotoURL { get; set; }
    }

    public class ProductReviews : BaseEntity
    {
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
        public int Stars { get; set; }
        public string Review { get; set; }

    }


}
