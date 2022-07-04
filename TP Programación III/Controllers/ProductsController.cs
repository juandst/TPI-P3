using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TP_Programación_III.Data;
using TP_Programación_III.Models;

namespace TP_Programación_III.Controllers
{
    [ApiController]
    [Route("products/")]
    public class ProductsController : ControllerBase
    {

        private readonly ProductsData _productsData;

        public ProductsController(ProductsData productsData)
        {
            _productsData = productsData;
        }

        [HttpGet]

        public ActionResult<IEnumerable<ProductDTO>> GetProducts()
        {
            return Ok(_productsData.Products);
        }

    }
}
