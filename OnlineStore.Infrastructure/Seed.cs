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

        public static void SeedProducts(ProductsDbContext context)
        {
            var products = new List<Product>
            {
               new Product {
                  Id = new Guid(),  
                  Price = 25,
                  Title = "Brown Brim",
                  Excerpt = "Small Brown hat",
                  Description = "Some random description",
                  CategoryId = new Guid("F9AC6598-B60F-4146-F692-08D7410967A5"),

               },

               new Product {
                  Id = new Guid(),
                  Price = 25,
                  Title = "Blue Beanie",
                  Excerpt = "Small Blue hat",
                  Description = "Some random description",
                  CategoryId = new Guid("F9AC6598-B60F-4146-F692-08D7410967A5"),
               },

               new Product {
                  Id = new Guid(),
                  Price = 35,
                  Title = "Brown Cowboy",
                  Excerpt = "Small Brown Cowboy hat",
                  Description = "Some random description",
                  CategoryId = new Guid("F9AC6598-B60F-4146-F692-08D7410967A5"),
               },

               new Product {
                  Id = new Guid(),
                  Price = 25,
                  Title = "Adidas NMD",
                  Excerpt = "Nice and shiny Adidas NMD",
                  Description = "Some random description",
                  CategoryId = new Guid("327D1513-2893-4D36-F693-08D7410967A5"),
               },

            };

            context.Products.AddRange(products);
            context.SaveChanges();
        }

    }
}
