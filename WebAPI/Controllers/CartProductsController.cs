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
    public class CartProductsController : ControllerBase
    {
        private ICartProductsService _cartProductsService;

        public CartProductsController(ICartProductsService cartProductsService)
        {
            _cartProductsService = cartProductsService;
        }

        [HttpGet("getall")]


        public IActionResult GetList()
        {

            var result = _cartProductsService.GetAll();
            return Ok(result);
        }


        [HttpGet("getbyid")]

        public IActionResult GetById(int cartProductId)
        {
            var result = _cartProductsService.GetById(cartProductId);
            return Ok(result);
        }

        [HttpPost("add")]

        public IActionResult Add(CartProduct cartProduct)
        {
            _cartProductsService.Add(cartProduct);

            return Ok();

        }

        [HttpPost("update")]

        public IActionResult Update(CartProduct cartProduct)
        {
            _cartProductsService.Update(cartProduct);

            return Ok();
        }

        [HttpPost("delete")]

        public IActionResult Delete(CartProduct cartProduct)
        {
            _cartProductsService.Delete(cartProduct);
            return Ok();
        }
    }
}
