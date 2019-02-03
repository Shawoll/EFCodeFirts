using System.Collections.Generic;
using CodeFirst.Models;
using CodeFirst.Models.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirst.API.Controllers
{
    [Route("api/cart")]
    [ApiController]
    public class CartController : Controller
    {
        private readonly ICartDataRepository<Cart> _dataRepository;

        public CartController(ICartDataRepository<Cart> dataRepository)
        {
            _dataRepository = dataRepository;
        }

        // GET: api/Cart
        [HttpGet]
        [ApiExplorerSettings(IgnoreApi = true)]
        public IActionResult Get()
        {
            IEnumerable<Cart> carts = _dataRepository.GetAll();
            return Ok(carts);
        }
    }
}
