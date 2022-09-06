using GR.Data.Models;
using GR.Repository.ProductRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GenericRepoProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ProductRepo _repo;

        public ProductsController(ProductRepo repo)
        {
            _repo = repo;
        }


        [HttpGet]
        public IActionResult GetAll()
        {
            var products = _repo.GetAllProducts();
            
            return Ok(products);

        }

        [HttpGet("{id}")]
        public IActionResult GetProduct(int Id)
        {
            var product = _repo.GetProduct(Id);

            return Ok(product);
        }

    }
}
