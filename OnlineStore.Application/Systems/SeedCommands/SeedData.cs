using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using OnlineStore.Application.Interfaces;
using OnlineStore.Domain.Entities.Product;

namespace OnlineStore.Application.Systems
{
    public class SeedData
    {
        private readonly IOS_ProducsDbContext _context;

        public SeedData(IOS_ProducsDbContext context)
        {
            _context = context;
        }

        public async Task SeedCategories(CancellationToken cancellationToken)
        {
            if (!_context.Categories.Any())
            {
                var categories = new Category[]
                {
                    new Category() { Id = Guid.NewGuid(), Name = "Hats", Description =null, ImageUrl=null },
                    new Category() { Id = Guid.NewGuid(), Name = "Jackets", Description =null, ImageUrl=null },
                    new Category() { Id = Guid.NewGuid(), Name = "Trousers", Description =null, ImageUrl=null },
                    new Category() { Id = Guid.NewGuid(), Name = "TShirt", Description =null, ImageUrl=null },
                    new Category() { Id = Guid.NewGuid(), Name = "Shoes", Description =null, ImageUrl=null }
                };

                _context.Categories.AddRange(categories);
                await _context.SaveChangesAsync(cancellationToken);
            }
        }

        //public static void SeedProducts(ProductsContext context)
        //{

        //}
    }
}
