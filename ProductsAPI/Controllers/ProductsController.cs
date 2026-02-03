using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductsAPI.Models;

namespace ProductsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        static private List<ProductsModel> PM = new List<ProductsModel>
        {
            new ProductsModel
            {
             Id = 1,
            ProductType = "Jeans",
            ProductLabel = "Levi",
            Contractor = "Outsource",
            Quantity = 90
            }, 
            new ProductsModel
            {
                Id = 2,
            ProductType = "T-Shirt",
            ProductLabel = "Next",
            Contractor = "Outsource",
            Quantity = 38
            },
            new ProductsModel
            {
                Id = 3,
            ProductType = "Jacket",
            ProductLabel = "RiverIsland",
            Contractor = "InHouse",
            Quantity = 50
            }

        };

        [HttpGet]
        public ActionResult<List<ProductsModel>>GetProducts()
        {
            return Ok(PM);
        }

        [HttpGet]
        [Route("/{id}")]
        public ActionResult<ProductsModel> GetProductByID(int id)
        {
            var product = PM.FirstOrDefault(p => p.Id == id);
            if (product is null)
            {
                return NotFound();
            }
            else
                return Ok(product);
        }

        [HttpPost]
        public ActionResult<ProductsModel> AddProduct(ProductsModel productsModel)
        {
            if (productsModel is null)
            {
                return BadRequest();
            }
            /*
            var product = new ProductsModel()
            {
                Id = 4,
                ProductType = "Jeans",
                ProductLabel = "Primark",
                Contractor = "Outsource",
                Quantity = 67
            };*/

            productsModel.Id = PM.Max(p => p.Id) + 1;
            PM.Add(productsModel);
            var product = CreatedAtAction(nameof(GetProductByID), new { id = productsModel.Id },productsModel );

            return product;
        }

        [HttpPut("{id}")]
        public IActionResult UpdateProduct(int id, ProductsModel productsModel)
        {
            var product = PM.FirstOrDefault(p => p.Id == id);
            if (product is null)
            {
                return NotFound();
            }

            product.Id = productsModel.Id;
            product.ProductType = productsModel.ProductType;
            product.ProductLabel = productsModel.ProductLabel;
            product.Contractor = productsModel.Contractor;
            product.Quantity = productsModel.Quantity;

            return NoContent();

        }
       


    }
}
