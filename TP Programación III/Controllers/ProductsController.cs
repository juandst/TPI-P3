using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TP_Programación_III.Data;
using TP_Programación_III.Models;
using TP_Programación_III.Repository;

namespace TP_Programación_III.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _repository;
        private readonly IMapper _mapper;
        public ProductsController(IProductRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]

        public ActionResult<IEnumerable<ProductDTO>> GetProducts()
        {
            var products = _repository.GetProducts();
            return Ok(_mapper.Map<IEnumerable<ProductDTO>>(products));
        }

        [HttpGet("{idProduct}")]
        
        public ActionResult<ProductDTO> GetProductById(int idProduct)
        {
            var product = _repository.GetProductById(idProduct);
            if (product == null) return NotFound();
            return Ok(_mapper.Map<ProductDTO>(product));
        }

        [HttpGet]
        public ActionResult<IEnumerable<ProductDTO>> GetProductOnSale()
        {
            var productOnSale = _repository.GetProductsOnSale();
            if (productOnSale == null) return NotFound();
            return Ok(_mapper.Map<IEnumerable<ProductDTO>>(productOnSale));
        }

        [HttpGet]
        public ActionResult<IEnumerable<ProductDTO>> GetProductByName(string name)
        {
            var products = _repository.GetProductByName(name);
            if (products == null) return NotFound();
            return Ok(_mapper.Map<IEnumerable<ProductDTO>>(products));
    }
    }
}
