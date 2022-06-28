using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Pharma.API.Data.Interfaces;
using Pharma.API.DTO;
using Pharma.API.Model;

namespace Pharma.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonsController : ControllerBase
    {
        private readonly IPersonRepository _personRepository;
        private readonly IMapper _mapper;
        public PersonsController(IPersonRepository personRepository, IMapper mapper)
        {
            _personRepository = personRepository;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult Add([FromBody] PersonModel model)
        {
            _personRepository.Add(model);
            return Ok();
        }

        [HttpGet("GetId/{personId}")]
        public IActionResult Get(int personId)
        {
            var model = _personRepository.GetById(personId);
            if (model == null)
                return NotFound("Pessoa n�o encontrada.");
            return Ok(model);
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var model = _personRepository.GetAll();
            if (model == null)
                return NotFound("Nenhum indiv�duo cadastrado.");
            var result = _mapper.Map<IEnumerable<PersonDTO>>(model);

            return Ok(result);
        }

        [HttpPut]
        public IActionResult Update([FromBody] PersonModel model)
        {
            var person = _personRepository.GetById(model.PersonId);
            if (person == null)
                return NotFound("Pessoa n�o encontrada.");
            _personRepository.Update(model);
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete([FromQuery] int personId)
        {
            var person = _personRepository.GetById(personId);
            if (person == null)
                return NotFound("Pessoa n�o encontrada.");
            _personRepository.Delete(person);
            return Ok();

        }
    }
}