using MediatR;
using OnlineStore.Application.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace OnlineStore.Application.Systems.SeedCommands
{
    public class SeedDataCommand : IRequest 
    {
        
    }

    public class SeedDataCommandHandler : IRequestHandler<SeedDataCommand>
    {
        private readonly IOS_ProducsDbContext _context;

        public SeedDataCommandHandler(IOS_ProducsDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(SeedDataCommand request, CancellationToken cancellationToken)
        {
            var seed = new SeedData(_context);
            await seed.SeedCategories(cancellationToken);            

            return Unit.Value;
        }
    }
}
