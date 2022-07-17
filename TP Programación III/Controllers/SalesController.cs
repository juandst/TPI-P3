using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TP_Programación_III.Models;
using TP_Programación_III.Repository;

namespace TP_Programación_III.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class SalesController : ControllerBase
    {
        private readonly ISaleRepository _repository;
        private readonly IMapper _mapper;
        public SalesController(ISaleRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<SaleDTO>> GetSales()
        {
            var sales = _repository.GetSales();
            return Ok(_mapper.Map<IEnumerable<SaleDTO>>(sales));
        }
    }
}
