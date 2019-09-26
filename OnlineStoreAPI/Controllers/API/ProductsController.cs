using System;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Threading;
using OnlineStore.Application.Products.Commands;
using OnlineStore.Core.Entities;
using OnlineStore.Application.Products.Queries;

namespace OnlineStore.Web.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : Controller
    {
        private readonly IMediator _mediator;

        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> Get(CancellationToken ct)
        {
            return await _mediator.Send(new GetProducts.Query(), ct);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(Guid id)
        {
            return await _mediator.Send(new GetProductDetails.Query{Id = id});
        }

        [HttpPost]
        public async Task<ActionResult<Unit>> Create(CreateProduct.Command command)
        {
            return await _mediator.Send(command);
        }
    }
}