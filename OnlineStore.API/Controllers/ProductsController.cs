using MediatR;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineStore.Core.Entities;
using System.Collections.Generic;
using OnlineStore.Application.Products.Queries;

namespace OnlineStore.API.Controllers
{
    [ApiController]
    [Route("products")]
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


    }
}