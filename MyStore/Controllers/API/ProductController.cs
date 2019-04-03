using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyStore.BusinessLayer.BusinessEntities;
using MyStore.BusinessLayer.Interfaces;
using MyStore.Views;

namespace MyStore.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductServices _productService;

        public ProductController(IProductServices productService)
        {
            _productService = productService;
        }

       


        // GET api/product
        [HttpGet("GetAllProducts")]
        public IActionResult GetAllProducts()
        {
            var products = _productService.GetAllProducts();

            if (products == null)
            {
                return BadRequest("No product");
            }
            return Ok(products);


        }

        // POST api/product
        [HttpPost("AddProduct")]
        public IActionResult AddProduct([FromBody]ProductViewModel product)
        {
            var res = _productService.CreateProduct(
                new ProductDto {
                    Name = product.Name,
                    Description = product.Description,
                    Discount = product.Discount,
                    Price = product.Price,
                    Quantity = product.Quantity
               });

            return Ok(res);
        }

        // DELETE api/product/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            if (id > 0)
                return _productService.DeleteProduct(id);
            return false;
        }

        [HttpPut]
        public IActionResult Put([FromBody]ProductAddViewModel product)
        {
            if (product == null)
            {
                return BadRequest();
            }

            var result=_productService.UpdateProduct(product.Id,
                new ProductDto
                {
                    Name = product.Name,
                    Description = product.Description,
                    Discount = product.Discount,
                    Price = product.Price,
                    Quantity = product.Quantity
                });
            if (result==false)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}