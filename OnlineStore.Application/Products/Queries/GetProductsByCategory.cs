using System;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using OnlineStore.Persistance;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using OnlineStore.Core.Domain.Entities;
using OnlineStore.Application.Exceptions;

namespace OnlineStore.Application.Products.Queries
{
    public class GetProductsByCategory
    {
        public class Query : IRequest<IEnumerable<Product>>
        {
            public string CategoryName { get; set; }
        }

        public class Handler : IRequestHandler<Query, IEnumerable<Product>>
        {
            private readonly ProductsContext _context;

            public Handler(ProductsContext context)
            {
                _context = context;
            }

            public async Task<IEnumerable<Product>> Handle(Query request, CancellationToken cancellationToken)
            {
                var category = await _context.Categories.Where(c => c.Description == request.CategoryName).AsNoTracking().FirstOrDefaultAsync();

                if (category == null)
                    throw new NotFoundException(nameof(Category), category.Id);

                var products = _context.ProductItems.Where(p => p.CategoryId.Equals(category.Id)).AsNoTracking().ToList();
                
                return products;
            }
        }
    }
}
