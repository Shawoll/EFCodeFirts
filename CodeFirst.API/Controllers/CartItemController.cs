using System.Collections.Generic;
using CodeFirst.Models;
using CodeFirst.Models.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirst.API.Controllers
{
    [Route("api/cartitem")]
    [ApiController]
    public class CartItemController : Controller
    {
        private readonly ICartItemDataRepository<CartItem> _dataRepository;

        public CartItemController(ICartItemDataRepository<CartItem> dataRepository)
        {
            _dataRepository = dataRepository;
        }

        // GET: api/Employee
        [HttpGet]
        [ApiExplorerSettings(IgnoreApi = true)]
        public IActionResult Get()
        {
            IEnumerable<CartItem> cartItems = _dataRepository.GetAll();
            return Ok(cartItems);
        }
    }
}
