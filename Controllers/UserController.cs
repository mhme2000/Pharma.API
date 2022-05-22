using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Pharma.API.Data.Interfaces;
using Pharma.API.DTO;
using Pharma.API.Model;

namespace Pharma.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public UserController(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult Add([FromBody] UserModel model)
        {
            _userRepository.Add(model);
            return Ok();
        }

        [HttpGet("GetId/{userId}")]
        public IActionResult Get(int userId)
        {
            var model = _userRepository.GetById(userId);
            if (model == null)
                return NotFound("Usuário não encontrado.");
            return Ok(model);
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var model = _userRepository.GetAll();
            if (model == null)
                return NotFound("Nenhum usuário cadastrado.");
            var result = _mapper.Map<IEnumerable<UserDTO>>(model);

            return Ok(result);
        }

        [HttpPut]
        public IActionResult Update([FromBody] UserModel model)
        {
            var user = _userRepository.GetById(model.UserId);
            if (user == null)
                return NotFound("Usuário não encontrado.");
            _userRepository.Update(model);
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete([FromQuery] int userId)
        {
            var user = _userRepository.GetById(userId);
            if (user == null)
                return NotFound("Usuário não encontrado.");
            _userRepository.Delete(user);
            return Ok();

        }
    }
}