using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using OnlineStore.Application.Exceptions;
using OnlineStore.Core.Entities;
using OnlineStore.Persistance;

namespace OnlineStore.Application.Products.Queries
{
    public class GetProductDetails
    {
        public class  Query : IRequest<Product>
        {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, Product>
        {
            private readonly ProductsContext _context;

            public Handler(ProductsContext context)
            {
                _context = context;
            }
            public async Task<Product> Handle(Query request, CancellationToken cancellationToken)
            {
                var product = await _context.ProductItems.FindAsync(request.Id);

                if (product == null)
                    throw new NotFoundException(nameof(Product), request.Id);

                return product;
            }
        }
    }
}
