using OnlineStore.Persistance;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using OnlineStore.Core.Entities;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace OnlineStore.Web.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : Controller
    {
        private readonly DataContext _context;

        public ProductsController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetAsync()
        {
            return Ok(await _context.Products.ToListAsync());
        }

        [HttpGet("id")]
        public async Task<ActionResult<Product>> GetActionAsync(int id)
        {
            return Ok(await _context.Products.FindAsync(id));
        }
    }
}