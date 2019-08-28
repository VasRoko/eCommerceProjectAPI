using Microsoft.AspNetCore.Mvc;
using OnlineStore.Persistance;

namespace OnlineStore.Web.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductCategoryController : Controller
    {
            private readonly DataContext _context;

            public ProductCategoryController(DataContext context)
            {
                _context = context;
            }
        }
}