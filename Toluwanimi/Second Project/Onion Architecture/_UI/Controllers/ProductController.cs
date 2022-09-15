using _DataAccess;
using _Service;
using Microsoft.AspNetCore.Mvc;


namespace _UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;
        private readonly IProductDetailsService productsDetailsService;

        public ProductController(IProductService productService, IProductDetailsService productsDetailsService)
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