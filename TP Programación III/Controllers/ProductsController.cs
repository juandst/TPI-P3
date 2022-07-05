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


        [HttpGet]

        public ActionResult<IEnumerable<Product>> GetProducts()
        {
        }

    }
}
