using MediatR;
using OnlineStore.Application.Exceptions;
using OnlineStore.Persistance;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace OnlineStore.Application.Products.Commands
{
    public class DeleteProduct 
    {
        public class Command : IRequest
        {
            public Guid Id { get; set; }
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

                if (product == null)
                    throw new NotFoundException(nameof(product), product.Id);

                try
                {
                    _context.Remove(product);
                    await _context.SaveChangesAsync();

                    return Unit.Value;
                }
                catch (Exception ex)
                {
                    throw new DeleteFailureExeception(nameof(product), product.Id, ex.Message);
                }
            }
        }
    }
}
