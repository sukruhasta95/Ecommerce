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
    public class BrandController : ControllerBase
    {
        private IBrandService _brandService;

        public BrandController(IBrandService brandService)
        {
            _brandService = brandService;
        }


        [HttpGet("getall")]


        public IActionResult GetList()
        {

            var result = _brandService.GetAll();
            return Ok(result);
        }


        [HttpGet("getbyid")]

        public IActionResult GetById(int brandId)
        {
            var result = _brandService.GetById(brandId);
            return Ok(result);
        }

        [HttpPost("add")]

        public IActionResult Add(Brand brand)
        {
            _brandService.Add(brand);

            return Ok();

        }

        [HttpPost("update")]

        public IActionResult Update(Brand brand)
        {
            _brandService.Update(brand);

            return Ok();
        }

        [HttpPost("delete")]

        public IActionResult Delete(Brand brand)
        {
            _brandService.Delete(brand);
            return Ok();
        }
    }
}
