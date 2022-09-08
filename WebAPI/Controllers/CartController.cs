using Business.Abstract;

using Entities.Concrete;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private ICartService _cartService;

        public CartController(ICartService cartService)
        {
            _cartService = cartService;
        }


        [HttpGet("getall")]


        public IActionResult GetList()
        {

            var result = _cartService.GetAll();
            return Ok(result);
        }


        [HttpGet("getbyid")]

        public IActionResult GetById(int cartId)
        {
            var result = _cartService.GetById(cartId);
            return Ok(result);
        }

        [HttpPost("add")]

        public IActionResult Add(Cart cart)
        {
            _cartService.Add(cart);

            return Ok();

        }

        [HttpPost("update")]

        public IActionResult Update(Cart cart)
        {
            _cartService.Update(cart);

            return Ok();
        }

        [HttpPost("delete")]

        public IActionResult Delete(Cart cart)
        {
            _cartService.Delete(cart);
            return Ok();
        }
    }
}
