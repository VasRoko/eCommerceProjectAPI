using System;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using OnlineStore.Persistance;
using Microsoft.EntityFrameworkCore;
using OnlineStore.Application.Exceptions;
using OnlineStore.Domain.Entities.Product;

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
            private readonly ProductsContext _context;

            public Handler(ProductsContext context)
            {
                _context = context;
            }

            public async Task<IEnumerable<Item>> Handle(Query request, CancellationToken cancellationToken)
            {
                var category = await _context.Categoty.Where(c => c.Description == request.CategoryName).AsNoTracking().FirstOrDefaultAsync();

                if (category == null)
                    throw new NotFoundException(nameof(Category), category.Id);

                var products = _context.Items.Where(p => p.CategoryId.Equals(category.Id)).AsNoTracking().ToList();
                
                return products;
            }
        }
    }
}
