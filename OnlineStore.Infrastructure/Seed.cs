using OnlineStore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OnlineStore.Persistance
{
    public class Seed
    {
        public static void SeedCategory(ProductsDbContext context)
        {
            if(!context.Categories.Any())
            {
                var categories = new List<Category>
                {
                    new Category
                    {
                        Id = new Guid(),
                        CategoryName = "Hats",
                        Description = "Our latest your best!",
                    },
                    new Category
                    {
                        Id = new Guid(),
                        CategoryName = "Shoes",
                        Description = "Our latest your best!",
                    },
                    new Category
                    {
                        Id = new Guid(),
                        CategoryName = "Jackets",
                        Description = "Our latest your best!",
                    },                   
                    new Category
                    {
                        Id = new Guid(),
                        CategoryName = "Sunglasses",
                        Description = "Our latest your best!",
                    },
                    new Category
                    {
                        Id = new Guid(),
                        CategoryName = "Trousers",
                        Description = "Our latest your best!",
                    },
                };

                context.Categories.AddRange(categories);
                context.SaveChanges();
            }
        }
    }
}
