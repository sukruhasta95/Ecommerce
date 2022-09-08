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
    public class CategoryController : ControllerBase
    {
        private ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }


        [HttpGet("getall")]


        public IActionResult GetList()
        {

            var result = _categoryService.GetAll();
            return Ok(result);
        }


        [HttpGet("getbyid")]

        public IActionResult GetById(int categoryId)
        {
            var result = _categoryService.GetById(categoryId);
            return Ok(result);
        }

        [HttpPost("add")]

        public IActionResult Add(Category category)
        {
            _categoryService.Add(category);

            return Ok();

        }

        [HttpPost("update")]

        public IActionResult Update(Category category)
        {
            _categoryService.Update(category);

            return Ok();
        }

        [HttpPost("delete")]

        public IActionResult Delete(Category category)
        {
            _categoryService.Delete(category);
            return Ok();
        }
    }
}
