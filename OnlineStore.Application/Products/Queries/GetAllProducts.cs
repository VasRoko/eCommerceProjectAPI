using MediatR;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using OnlineStore.Core.Entities;
using OnlineStore.Persistance;
using Microsoft.EntityFrameworkCore;

namespace OnlineStore.Application.Products.Queries
{
    public class GetAllProducts
    {
        public class Query : IRequest<List<Product>>
        {
        }

        public class Handler : IRequestHandler<Query, List<Product>>
        {
            private readonly DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<List<Product>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Products.ToListAsync();
            }
        }
    }
}
