using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Pharma.API.DTO;
using Pharma.API.Services.Interfaces;

namespace Pharma.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly IOrdersService _ordersService;
        private readonly IMapper _mapper;
        public OrdersController(IOrdersService ordersService, IMapper mapper)
        {
            _ordersService = ordersService;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult SaveOrder([FromBody] OrderDTO model)
        {
            _ordersService.SaveOrder(model);
            return Ok();
        }
        
        [HttpPost("separate")]
        public IActionResult SeparateOrder([FromBody] SeparateOrderDTO model)
        {
            _ordersService.SeparateOrder(model);
            return Ok();
        }
        
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var orders = _ordersService.GetAll();
            return Ok(orders);
        }
        
        [HttpGet("GetDetails/{orderId}")]
        public IActionResult GetDetails(int orderId)
        {
            var order = _ordersService.GetDetails(orderId);
            return Ok(order);
        }
    }
}