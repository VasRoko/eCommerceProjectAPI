using Microsoft.EntityFrameworkCore;
using OnlineStore.Domain.Entities.Product;
using System.Threading;
using System.Threading.Tasks;

namespace OnlineStore.Application.Interfaces
{
    public interface IOS_ProducsDbContext
    {
        DbSet<Item> Items { get; set; }
        DbSet<Category> Categories { get; set; }
        DbSet<Details> Details { get; set; }
        DbSet<Review> Reviews { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
