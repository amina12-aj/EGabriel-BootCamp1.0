using Microsoft.AspNetCore.Mvc;
using Onion_Domain;
using Onion_Service;

namespace Onion_Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly IProductDetailService _productDetailsService;

        public ProductController(IProductService productService, IProductDetailService productDetailsService)
        {
            _productService = productService;
            _productDetailsService = productDetailsService;
        }
        [HttpGet]
        public List<ProductDetails> Get()
        {
            List<ProductDetails> productDetails = new List<ProductDetails>();
            var prodcutList = _productService.GetProduct().ToList();
            foreach (var product in prodcutList)
            {
                var productDetailList = _productDetailsService.GetProductDetail(product.ProductId);
                ProductDetails details = new ProductDetails
                {
                    ProductId = product.ProductId,
                    ProductName = product.ProductName,
                    Price = productDetailList.Price,
                    StockAvailable = productDetailList.StockAvailable,
                };
                productDetails.Add(details);
            }
            return productDetails;
        }
    }
}
