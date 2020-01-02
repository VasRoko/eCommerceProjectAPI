using System;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using OnlineStore.Application.Exceptions;
using OnlineStore.Domain.Entities.Product;
using OnlineStore.Application.Interfaces;

namespace OnlineStore.Application.Products.Queries
{
    public class GetProductDetails
    {
        public class  Query : IRequest<Item>
        {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, Item>
        {
            private readonly IOS_ProducsDbContext _context;

            public Handler(IOS_ProducsDbContext context)
            {
                _context = context;
            }
            public async Task<Item> Handle(Query request, CancellationToken cancellationToken)
            {
                var product = await _context.Items.FindAsync(request.Id);

                if (product == null)
                    throw new NotFoundException(nameof(Item), request.Id);

                return product;
            }
        }
    }
}
