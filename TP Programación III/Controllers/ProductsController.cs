using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using TP_Programación_III.Data;
using TP_Programación_III.Entities;
using TP_Programación_III.Models;
using TP_Programación_III.Models.Create;
using TP_Programación_III.Models.Update;
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

        [HttpGet(Name = "GetProducts")]

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

        [HttpPost]
        public ActionResult<ProductDTO> AddProduct(ProductCreateDTO productToCreate)
        {
            var userRole = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Role)?.Value;
            if (userRole != "admin") return Forbid();
            Product newProduct = _mapper.Map<Product>(productToCreate);
            _repository.AddProduct(newProduct);
            _repository.SaveChangesBool();

            return CreatedAtRoute("GetProducts",
                new
                {
                    productId = newProduct.ID
                },
                _mapper.Map<ProductDTO>(newProduct));
        }

        [HttpPut("{productId}")]
        
        public ActionResult UpdateProduct(int productId, ProductUpdateDTO productUpdated)
        {
            var userRole = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Role)?.Value;
            if (userRole != "admin") return Forbid();
            var productToUpdate = _repository.GetProductById(productId);
            if (productToUpdate == null) return NotFound();
            _mapper.Map(productUpdated, productToUpdate);
            _repository.SaveChangesBool();
            return NoContent();
        }

        [HttpDelete("{productId}")]

        public ActionResult DeleteProduct(int productId)
        {
            var userRole = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Role)?.Value;
            if (userRole != "admin") return Forbid();
            var productToDelete = _repository.GetProductById(productId);
            if (productToDelete == null) return NotFound();
            _repository.DeleteProduct(productToDelete);

            _repository.SaveChangesBool();

            return NoContent();
        }
    }
}
