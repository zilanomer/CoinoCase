using Business.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            //IProductService productService = new ProductManager(new EfProductDal());
            var result = _productService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);

        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            //IProductService productService = new ProductManager(new EfProductDal());
            var result = _productService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);

        }

        [HttpPost("add")]  
        public IActionResult Add(ProductCreateDto productDto)
        {
            Product product = new Product();
            if (productDto != null)
            {
                product.ProductName = productDto.ProductName;
                product.CategoryId = productDto.CategoryId;
                product.UnitPrice=productDto.UnitPrice;
                product.UnitsInStock=productDto.UnitsInStock;
            }

            var result = _productService.Add(product);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
