using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        ICategoryService _categoryService;

        public CategoryController(ICategoryService CategoryService)
        {
            _categoryService = CategoryService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            //ICategoryService CategoryService = new CategoryManager(new EfCategoryDal());
            var result = _categoryService.GetAll();
                return Ok(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            //ICategoryService CategoryService = new CategoryManager(new EfCategoryDal());
            var result = _categoryService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }


        [HttpPost("add")]  
        public IActionResult Add(CategoryCreateDto categoryDto)
        {
            Category category = new Category();
            if (categoryDto!=null)
            {
                category.CategoryName = categoryDto.CategoryName;
            }
            var result = _categoryService.Add(category);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
