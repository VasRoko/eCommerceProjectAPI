using MediatR;
using OnlineStore.Application.Exceptions;
using OnlineStore.Application.Interfaces;
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
            public string Description { get; set; }
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly IOS_ProducsDbContext _context;

            public Handler(IOS_ProducsDbContext context)
            {
                _context = context;
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                var product = await _context.Items.FindAsync(request.Id);
                               
                if (product == null)
                    throw new NotFoundException(nameof(product), product.Id);

                try
                {
                    await _context.SaveChangesAsync(cancellationToken);
                    
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
