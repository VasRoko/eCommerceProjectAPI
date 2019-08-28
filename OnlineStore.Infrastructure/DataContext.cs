using System;
using Microsoft.EntityFrameworkCore;
using OnlineStore.Core.Entities;

namespace OnlineStore.Persistance
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category>  Categories { get; set; }

    }
}
