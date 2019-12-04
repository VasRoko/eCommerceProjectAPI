using MediatR;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using OnlineStore.Domain.Entities.Product;
using OnlineStore.Application.Products.Queries;
using OnlineStore.Application.Products.Commands;
using System;

namespace OnlineStore.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ProductsController : Controller
    {
        private readonly IMediator _mediator;

        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IEnumerable<Item>> All()
        {
            return await _mediator.Send(new GetProducts.Query());
        }

        [HttpGet]
        [Route("category")]
        public async Task<IEnumerable<Item>> Category([FromQuery]string name )
        {
            return await _mediator.Send(new GetProductsByCategory.Query() { CategoryName = name });
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult<Item>> GetDetails(Guid id)
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

        [HttpDelete("{id}")]
        public async Task<ActionResult<Unit>> Delete(Guid id)
        {
            return await _mediator.Send(new DeleteProduct.Command { Id = id });
        }
    }
}