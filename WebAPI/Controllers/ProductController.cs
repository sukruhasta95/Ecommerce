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
    public class ProductController : ControllerBase
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("getall")]
        
        
        public IActionResult GetList()
        {

            var result = _productService.GetAll();

            return Ok(result);
          
        }

        [HttpGet("getlistbycategory")]
       
        public IActionResult GetListByCategory(int categoryId)
        {
            var result = _productService.GetByCategory(categoryId);

            return Ok(result);
        }

        [HttpGet("getbyid")]
       
        public IActionResult GetById(int productId)
        {
            var result = _productService.GetById(productId);
            return Ok(result);
        }

        [HttpPost("add")]
       
        public IActionResult Add(Product product)
        {
           _productService.Add(product);

           return Ok();
           
        }

        [HttpPost("update")]

        public IActionResult Update(Product product)
        {
         _productService.Update(product);

            return Ok();
        }

        [HttpPost("delete")]
       
        public IActionResult Delete(Product product)
        {
             _productService.Delete(product);
            return Ok();
        }
    }
}
