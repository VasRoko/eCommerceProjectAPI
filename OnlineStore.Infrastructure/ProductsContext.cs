using Microsoft.EntityFrameworkCore;
using OnlineStore.Core.Entities;

namespace OnlineStore.Persistance
{
    public class ProductsContext : DbContext
    {
        public ProductsContext(DbContextOptions<ProductsContext> options) : base(options)
        {}

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> ProductItems { get; set; }
        public DbSet<ProductDetails> ProductDetails { get; set; }
        public DbSet<ProductReview> ProductReviews { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasOne(d => d.ProductDetails)
                .WithOne(p => p.Product)
                .HasForeignKey<ProductDetails>(k => k.ProductId)
                .IsRequired();

            modelBuilder.Entity<ProductReview>()
                .HasOne(p => p.Product)
                .WithMany(r => r.ProductReviews)
                .HasForeignKey(p => p.Id)
                .IsRequired();
        }
    }
}
