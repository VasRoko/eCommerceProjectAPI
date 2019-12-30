using MediatR;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using OnlineStore.Domain.Entities.Product;
using OnlineStore.Application.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace OnlineStore.Application.Products.Queries
{
    public class GetProducts
    {
        public class Query : IRequest<IEnumerable<Item>>
        {
        }

        public class Handler : IRequestHandler<Query, IEnumerable<Item>>
        {
            private readonly IOS_ProducsDbContext _context;

            public Handler(IOS_ProducsDbContext context)
            {
                _context = context;
            }

            public async Task<IEnumerable<Item>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Items.ToListAsync();
            }
        }
    }
}
