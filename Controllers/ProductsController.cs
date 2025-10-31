using AspWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private ApplicationDbContext _context;
        public ProductsController(ApplicationDbContext context) {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Products> Get()
        {
            return _context.Products.ToList<Products>();
        }

        [HttpPost]
        public IActionResult AddProduct(Products product)
        {
            try {
                _context.Products.Add(product);
                _context.SaveChanges(true);
                return StatusCode(StatusCodes.Status200OK, product);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);

                throw;
            }
        }

        [HttpGet("{id}")]
        public Products GetProduct(int id)
        {
            return _context.Products.Find(id);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateProduct(int id, Products product)
        {
            try
            {
                if (id != product.ProductsId)
                {
                    return StatusCode(StatusCodes.Status400BadRequest);
                }
                _context.Products.Update(product);
                _context.SaveChanges(true);
                return StatusCode(StatusCodes.Status201Created, product);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
                throw;
            }
        }
    }
}
