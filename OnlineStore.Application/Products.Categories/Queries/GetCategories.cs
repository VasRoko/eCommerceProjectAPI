using MediatR;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using OnlineStore.Core.Entities;
using OnlineStore.Persistance;
using Microsoft.EntityFrameworkCore;

namespace OnlineStore.Application.Products.Categories.Queries
{
    public class GetCategories
    {
        public class Query : IRequest<IEnumerable<Category>>
        {
        }

        public class Handler : IRequestHandler<Query, IEnumerable<Category>>
        {
            private readonly ProductsContext _context;

            public Handler(ProductsContext context)
            {
                _context = context;
            }

            public async Task<IEnumerable<Category>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Categories.ToListAsync();
            }
        }
    }
}


