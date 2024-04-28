using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using simpleapi.DTO;
using simpleapi.Entities;

namespace simpleapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly DbContext _dbContext; // Mengubah tipe dari DbContext menjadi CobadotnetContext
        public ProductController(DbContext dbContext) // Mengubah tipe parameter konstruktor
        {
            this._dbContext = dbContext;
        }


        [HttpGet("GetProduct")]
        public async Task<ActionResult<List<ProductDTO>>> Get()
        {
            
            if (_dbContext is not CobadotnetContext cobadotnetContext)
            {
                return BadRequest("Invalid DbContext type");
            }

            // Mengambil daftar produk dari database secara asinkron
            var products = await cobadotnetContext.Products.ToListAsync();


            var productDTOs = products.Select(p => new ProductDTO
            {
                Id = p.Id,
                Nama = p.Nama,
                Harga = p.Harga,
            }).ToList();

            // Mengembalikan hasil sebagai respons HTTP
            return Ok(productDTOs);
        }

        public override bool Equals(object? obj)
        {
            return obj is ProductController controller &&
                   EqualityComparer<DbContext>.Default.Equals(_dbContext, controller._dbContext);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_dbContext);
        }
    }
}