using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Pharma.API.Data.Interfaces;
using Pharma.API.DTO;
using Pharma.API.Model;

namespace Pharma.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        public ProductController(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult Add([FromBody] ProductModel model)
        {
            _productRepository.Add(model);
            return Ok();
        }

        [HttpGet("GetId/{productId}")]
        public IActionResult Get(int productId)
        {
            var model = _productRepository.GetById(productId);
            if (model == null)
                return NotFound("Produto não encontrado.");
            return Ok(model);
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var model = _productRepository.GetAll();
            if (model == null)
                return NotFound("Nenhum produto cadastrado.");
            var result = _mapper.Map<IEnumerable<ProductDTO>>(model);
            return Ok(result);
        }

        [HttpPut]
        public IActionResult Update([FromBody] ProductModel model)
        {
            var product = _productRepository.GetById(model.ProductId);
            if (product == null)
                return NotFound("Produto não encontrado.");
            _productRepository.Update(model);
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete([FromQuery] int productId)
        {
            var product = _productRepository.GetById(productId);
            if (product == null)
                return NotFound("Produto não encontrado.");
            _productRepository.Delete(product);
            return Ok();
        }
    }
}