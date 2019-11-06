﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using OnlineStore.Core.Entities;
using OnlineStore.Persistance;
using Microsoft.EntityFrameworkCore;

namespace OnlineStore.Application.Products.Queries
{
    public class GetProducts
    {
        public class Query : IRequest<IEnumerable<Product>>
        {
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
                return await _context.ProductItems.ToListAsync();
            }
        }
    }
}
