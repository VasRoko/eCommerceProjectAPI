using System;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using OnlineStore.Domain.Entities.Product;
using OnlineStore.Application.Interfaces;

namespace OnlineStore.Application.Products.Queries
{
    public class GetProductsByCategory
    {
        public class Query : IRequest<IEnumerable<Item>>
        {
            public string CategoryName { get; set; }
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
                //var category = await _context.Categoty.Where(c => c.Description == request.CategoryName).AsNoTracking().FirstOrDefaultAsync();

                //if (category == null)
                //    throw new NotFoundException(nameof(Category), category.Id);

                //var products = _context.Items.Where(p => p.CategoryId.Equals(category.Id)).AsNoTracking().ToList();

                return null;// products;
            }
        }
    }
}
