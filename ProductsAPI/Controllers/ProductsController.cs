using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductsAPI.Data;
using ProductsAPI.Models;

namespace ProductsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ProductsDbContext _context;
        public ProductsController(ProductsDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task <ActionResult<List<ProductsModel>>>GetProducts()
        {
            return Ok(await _context.ProductsModels.ToListAsync());
        }

        [HttpGet]
        [Route("getproduct/{id}")]
        public async Task <ActionResult<ProductsModel>> GetProductByID(int id)
        {
            var product = await _context.ProductsModels.FindAsync(id);
            if (product is null)
            {
                return NotFound();
            }
            else
                return Ok(product);
        }

        [HttpPost("/add")]
        public async Task <ActionResult<ProductsModel>> AddProduct(ProductsModel productsModel)
        {
            if (productsModel is null)
            {
                return BadRequest();
            }
             _context.ProductsModels.Add(productsModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetProductByID), new { id = productsModel.Id }, productsModel);
        }

        [HttpPut("put/{id}")]
        public async Task <IActionResult> UpdateProduct(int id, ProductsModel productsModel)
        {
            var product = await _context.ProductsModels.FindAsync(id);
            if (product is null)
            {
                return NotFound();
            }

            product.Id = productsModel.Id;
            product.ProductType = productsModel.ProductType;
            product.ProductLabel = productsModel.ProductLabel;
            product.Contractor = productsModel.Contractor;
            product.Quantity = productsModel.Quantity;

            await _context.SaveChangesAsync();

            return NoContent();

        }

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> DeleteProductModel(int id)
        {
            var product = await _context.ProductsModels.FindAsync(id);
            if (product is null)
            {
                return NotFound();
            }

            _context.ProductsModels.Remove(product);
            await _context.SaveChangesAsync();

            return NoContent();
        }
       
        

    }
}
