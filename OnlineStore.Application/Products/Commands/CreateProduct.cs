﻿using System;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using OnlineStore.Application.Exceptions;
using OnlineStore.Domain.Entities.Product;
using OnlineStore.Application.Interfaces;

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
            private readonly IOS_ProducsDbContext _context;

            public Handler(IOS_ProducsDbContext context)
            {
                _context = context;
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                var product = new Item
                {

                };

                try
                {
                    _context.Items.Add(product);
                    await _context.SaveChangesAsync(cancellationToken);

                    return Unit.Value;

                }
                catch (Exception ex)
                {
                    throw new CreateFailureException(nameof(Item), product.Id, ex.Message);
                }
            }
        }
    }
}
