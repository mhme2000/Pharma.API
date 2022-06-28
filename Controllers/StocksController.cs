using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Pharma.API.Data.Interfaces;
using Pharma.API.DTO;
using Pharma.API.Model;

namespace Pharma.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StocksController : ControllerBase
    {
        private readonly IStockRepository _stockRepository;
        private readonly IMapper _mapper;
        public StocksController(IStockRepository stockRepository, IMapper mapper)
        {
            _stockRepository = stockRepository;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult Add([FromBody] StockModel model)
        {
            _stockRepository.Add(model);
            return Ok();
        }

        [HttpGet("GetId/{stockId}")]
        public IActionResult Get(int stockId)
        {
            var model = _stockRepository.GetById(stockId);
            if (model == null)
                return NotFound("Estoque n�o encontrado.");
            return Ok(model);
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var model = _stockRepository.GetAll();
            if (model == null)
                return NotFound("Nenhum estoque cadastrado.");
            var result = _mapper.Map<IEnumerable<StockDTO>>(model);

            return Ok(result);
        }

        [HttpPut]
        public IActionResult Update([FromBody] StockModel model)
        {
            var stock = _stockRepository.GetById(model.StockId);
            if (stock == null)
                return NotFound("Estoque n�o encontrado.");
            _stockRepository.Update(model);
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete([FromQuery] int stockId)
        {
            var stock = _stockRepository.GetById(stockId);
            if (stock == null)
                return NotFound("Estoque n�o encontrado.");
            _stockRepository.Delete(stock);
            return Ok();

        }
    }
}