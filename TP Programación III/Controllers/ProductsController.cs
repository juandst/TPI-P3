using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TP_Programación_III.Data;
using TP_Programación_III.Models;
using TP_Programación_III.Services;

namespace TP_Programación_III.Controllers
{
    [ApiController]
    [Route("products/")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _repository;
        public ProductsController(IProductRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]

        public JsonResult GetProducts()
        {
            return new JsonResult(_repository.GetProducts());
        }
    }
}
