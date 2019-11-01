using MediatR;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineStore.Core.Entities;
using System.Collections.Generic;
using OnlineStore.Application.Products.Queries;
using OnlineStore.Application.Products.Commands;
using System;

namespace OnlineStore.API.Controllers
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
        public async Task<ActionResult<List<Product>>> All()
        {
            return await _mediator.Send(new GetProducts.Query());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetDetails(Guid id)
        {
            return await _mediator.Send(new GetProductDetails.Query { Id = id });
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Unit>> Update(Guid id, UpdateProduct.Command command)
        {
            command.Id = id;
            return await _mediator.Send(command);
        }
           
        [HttpPost]
        public async Task<ActionResult<Unit>> Create(CreateProduct.Command command)
        {
            return await _mediator.Send(command);
        }
    }
}