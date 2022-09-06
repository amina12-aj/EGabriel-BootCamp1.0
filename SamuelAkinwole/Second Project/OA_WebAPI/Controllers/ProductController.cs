using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OA_DataAccess;
using OA_Services.Interface;

namespace OA_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;
        private readonly IProductsDetailsService productsDetailsService;

        public ProductController(IProductService productService, IProductsDetailsService productsDetailsService)
        {
            this.productService = productService;
            this.productsDetailsService = productsDetailsService;
        }

        [HttpGet]
        public List<ProductDetails> GetAll()
        {
            List<ProductDetails> productDetails = new List<ProductDetails>();
            var prodcutList = productService.GetAllProduct().ToList();

            return productDetails;
        }

        [HttpGet("{id}")]

        public IActionResult Get(int id)
        {
            var product = productService.GetProduct(id);

            return Ok(product);
        }

    }
}
