using MediatR;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using OnlineStore.Domain.Entities.Product;
using OnlineStore.Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace OnlineStore.Application.Products.Categories.Queries
{
    public class GetCategories
    {
        public class Query : IRequest<IEnumerable<Category>>
        {
            public int PageSize { get; set; }
            public int CurrentTotal { get; set; }
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
                return await _context.Categories.Skip(request.CurrentTotal).Take(request.PageSize).ToListAsync(cancellationToken);
            }
        }
    }
}


