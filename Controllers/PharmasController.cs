using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Pharma.API.Data.Interfaces;
using Pharma.API.DTO;
using Pharma.API.Model;

namespace Pharma.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PharmasController : ControllerBase
    {
        private readonly IPharmaRepository _pharmaRepository;
        private readonly IMapper _mapper;
        public PharmasController(IPharmaRepository pharmaRepository, IMapper mapper)
        {
            _pharmaRepository = pharmaRepository;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult Add([FromBody] PharmaModel model)
        {
            _pharmaRepository.Add(model);
            return Ok();
        }

        [HttpGet("GetId/{pharmaId}")]
        public IActionResult Get(int pharmaId)
        {
            var model = _pharmaRepository.GetById(pharmaId);
            if (model == null)
                return NotFound("Farm�cia n�o encontrada.");
            return Ok(model);
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var model = _pharmaRepository.GetAll();
            if (model == null)
                return NotFound("Nenhum farm�cia cadastrada.");
            var result = _mapper.Map<IEnumerable<PharmaDTO>>(model);

            return Ok(result);
        }

        [HttpPut]
        public IActionResult Update([FromBody] PharmaModel model)
        {
            var pharma = _pharmaRepository.GetById(model.PharmaId);
            if (pharma == null)
                return NotFound("Farm�cia n�o encontrada.");
            _pharmaRepository.Update(model);
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete([FromQuery] int pharmaId)
        {
            var pharma = _pharmaRepository.GetById(pharmaId);
            if (pharma == null)
                return NotFound("Farm�cia n�o encontrada.");
            _pharmaRepository.Delete(pharma);
            return Ok();

        }
    }
}