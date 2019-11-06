using OnlineStore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OnlineStore.Persistance
{
    public class Seed
    {
        public static void SeedCategory(ProductsContext context)
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
                    new Category
                    {
                        Id = new Guid(),
                        CategoryName = "Other",
                        Description = "There is a lot more!",
                    },
                };

                context.Categories.AddRange(categories);
                context.SaveChanges();
            }
        }

        public static void SeedProducts(ProductsContext context)
        {
            var products = new List<Product>
            {
               new Product {
                  Id = new Guid(),
                  Price = 25,
                  InStock = 23,
                  Title = "Brown Brim",
                  Description = "Some random description",
               },

               new Product {
                  Id = new Guid(),
                  Price = 25,
                  InStock = 15,
                  Title = "Blue Beanie",
                  Description = "Some random description",
               },

               new Product {
                  Id = new Guid(),
                  Price = 35,
                  InStock = 10,
                  Title = "Brown Cowboy",
                  Description = "Some random description",
                  CategoryId = new Guid("446C8C6F-ACC0-433B-7FE0-08D762D0420A")
               },

               new Product {
                  Id = new Guid(),
                  Price = 25,
                  InStock = 20,
                  Title = "Adidas NMD",
                  Description = "Some random description",
               },

            };

            context.ProductItems.AddRange(products);
            context.SaveChanges();

        }

    }
}
