using Microsoft.EntityFrameworkCore;
using OnlineStore.Domain.Entities.Product;

namespace OnlineStore.Persistance
{
    public class ProductsContext : DbContext
    {
        public ProductsContext(DbContextOptions<ProductsContext> options) : base(options)
        {}

        public DbSet<Item> Items { get; set; }
        public DbSet<Category> Categoty { get; set; }
        public DbSet<Details> Details { get; set; }
        public DbSet<Review> Reviews { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>()
                .HasOne(d => d.Details)
                .WithOne(p => p.Item)
                .HasForeignKey<Details>(k => k.ItemId)
                .IsRequired();

            modelBuilder.Entity<Review>()
                .HasOne(p => p.Item)
                .WithMany(r => r.Reviews)
                .HasForeignKey(p => p.Id)
                .IsRequired();
        }
    }
}
