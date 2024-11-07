using Core.Interfaces;
using Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("productGet")] // Route içindeki "/productGet" kısmını kaldırdım
        public async Task<ActionResult<List<Product>>> GetAllProducts()
        {
            var products = await _productService.GetAllProductsAsync();
            return Ok(products);
        }

        [HttpGet("productGet/{id}")] // Route içindeki "/productGet/{id}" kısmını kaldırdım
        public async Task<ActionResult<Product>> GetProductById(int id)
        {
            var product = await _productService.GetProductByIdAsync(id);
            if (product == null)
                return NotFound();

            return Ok(product);
        }

        [HttpPost("productAdd")] // Route içindeki "/productAdd" kısmını kaldırdım
        public async Task<ActionResult> AddProduct([FromBody] Product product) // [FromBody] ile body'den alınmasını sağlıyoruz
        {
            await _productService.AddProductAsync(product);
            return CreatedAtAction(nameof(GetProductById), new { id = product.Id }, product);
        }

        [HttpPut("productUpdate/{id}")] // Route içindeki "/productUpdate/{id}" kısmını kaldırdım
        public async Task<ActionResult> UpdateProduct(int id, [FromBody] Product product) // [FromBody] ile body'den alınmasını sağlıyoruz
        {
            if (id != product.Id)
                return BadRequest();

            await _productService.UpdateProductAsync(product);
            return NoContent();
        }

        [HttpDelete("productDelete/{id}")] // Route içindeki "/productDelete/{id}" kısmını kaldırdım
        public async Task<ActionResult> DeleteProduct(int id)
        {
            await _productService.DeleteProductAsync(id);
            return NoContent();
        }
    }
}
