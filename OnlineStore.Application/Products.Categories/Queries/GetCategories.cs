using MediatR;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using OnlineStore.Domain.Entities.Product;
using OnlineStore.Application.Interfaces;

namespace OnlineStore.Application.Products.Categories.Queries
{
    public class GetCategories
    {
        public class Query : IRequest<IEnumerable<Category>>
        {
        }

        public class Handler : IRequestHandler<Query, IEnumerable<Category>>
        {
            private readonly IOS_ProducsDbContext _context;

            public Handler(IOS_ProducsDbContext context)
            {
                _context = context;
            }

            public async Task<IEnumerable<Category>> Handle(Query request, CancellationToken cancellationToken)
            {
                return null;// await _context.Categoty.ToListAsync();
            }
        }
    }
}


