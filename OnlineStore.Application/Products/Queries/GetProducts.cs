using MediatR;
using System.Threading;
using System.Threading.Tasks;
using OnlineStore.Persistance;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using OnlineStore.Domain.Entities.Product;

namespace OnlineStore.Application.Products.Queries
{
    public class GetProducts
    {
        public class Query : IRequest<IEnumerable<Item>>
        {
        }

        public class Handler : IRequestHandler<Query, IEnumerable<Item>>
        {
            private readonly ProductsContext _context;

            public Handler(ProductsContext context)
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
