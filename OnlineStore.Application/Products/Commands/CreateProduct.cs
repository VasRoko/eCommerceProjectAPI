using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using OnlineStore.Application.Exceptions;
using OnlineStore.Core.Entities;
using OnlineStore.Persistance;

namespace OnlineStore.Application.Products.Commands
{
    public class CreateProduct
    {
        public class Command : IRequest
        {
            public string Title { get; set; }
            public double Price { get; set; }
            public int InStock { get; set; }
            public string Description { get; set; }
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly ProductsDbContext _context;

            public Handler(ProductsDbContext context)
            {
                _context = context;
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                var product = new Product
                {
                    Id = new Guid(),
                    Date = DateTime.Now,
                    Title = request.Title,
                    Price = request.Price,
                    InStock = request.InStock,
                    Description = request.Description,
                };

                try
                {
                    _context.ProductItems.Add(product);
                    await _context.SaveChangesAsync();

                    return Unit.Value;

                }
                catch (Exception ex)
                {
                    throw new CreateFailureException(nameof(Product), product.Id, ex.Message);
                }
            }
        }
    }
}
