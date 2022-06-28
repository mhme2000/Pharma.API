using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Pharma.API.Data.Interfaces;
using Pharma.API.DTO;
using Pharma.API.Model;

namespace Pharma.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StockItemsController : ControllerBase
    {
        private readonly IStockItemRepository _stockItemRepository;
        private readonly IMapper _mapper;
        public StockItemsController(IStockItemRepository stockItemRepository, IMapper mapper)
        {
            _stockItemRepository = stockItemRepository;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult Add([FromBody] StockItemModel model)
        {
            _stockItemRepository.Add(model);
            return Ok();
        }

        [HttpGet("GetId/{stockItemId}")]
        public IActionResult Get(int stockItemId)
        {
            var model = _stockItemRepository.GetById(stockItemId);
            if (model == null)
                return NotFound("Item não encontrado.");
            return Ok(model);
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var model = _stockItemRepository.GetAll();
            if (model == null)
                return NotFound("Nenhum item cadastrado.");
            var result = _mapper.Map<IEnumerable<StockItemDTO>>(model);
            return Ok(result);
        }

        [HttpPut]
        public IActionResult Update([FromBody] StockItemModel model)
        {
            var stockItem = _stockItemRepository.GetById(model.StockItemId);
            if (stockItem == null)
                return NotFound("Item n�o encontrado.");
            _stockItemRepository.Update(model);
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete([FromQuery] int stockItemId)
        {
            var stockItem = _stockItemRepository.GetById(stockItemId);
            if (stockItem == null)
                return NotFound("Item n�o encontrado.");
            _stockItemRepository.Delete(stockItem);
            return Ok();
        }
    }
}