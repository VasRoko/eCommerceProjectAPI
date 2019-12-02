using Microsoft.EntityFrameworkCore;

namespace OnlineStore.Persistance
{
    public class MainDbContext : DbContext
    {
        public MainDbContext(DbContextOptions<MainDbContext> options) : base(options)
        { }

        
    }
}
