using MediatR;
using OnlineStore.Application.Exceptions;
using OnlineStore.Persistance;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace OnlineStore.Application.Products.Commands
{
    public class UpdateProduct
    {
        public class Command : IRequest
        {
            public Guid Id { get; set; }
            public string Title { get; set; }
            public double? Price { get; set; }
            public int? InStock { get; set; }
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
                var product = await _context.ProductItems.FindAsync(request.Id);

                try
                {
                    if (product != null)
                    {
                        product.Title = request.Title ?? product.Title;
                        product.Price = request.Price ?? product.Price;
                        product.InStock = request.InStock ?? product.InStock;
                        product.Description = request.Description ?? product.Description;
                    }
                    await _context.SaveChangesAsync();
                    
                    return Unit.Value;
                } 
                catch (Exception ex)
                {
                    throw new UpdateFailureException(nameof(product), product.Id, ex.Message);
                }             
            }
        }
    }
}
