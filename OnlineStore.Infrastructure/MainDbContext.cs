using Microsoft.EntityFrameworkCore;
using OnlineStore.Core.Entities;

namespace OnlineStore.Persistance
{
    public class MainDbContext : DbContext
    {
        public MainDbContext(DbContextOptions options) : base(options)
        { }

    }
}
