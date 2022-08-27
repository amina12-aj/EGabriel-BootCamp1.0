using Microsoft.AspNetCore.Mvc;
using ProductCatalog.Dormain;
using ProductCatalog.Service;

namespace ProductCatalog.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IProductDetailService _productDetailService;

        public ProductController(IProductService productService, IProductDetailService productDetailService)
        {
                _productService = productService;
                _productDetailService = productDetailService;
        } 
        

        [HttpGet]
        public IActionResult Get()
        {
            List<ProductDetail> productDetails = new List<ProductDetail>();  
            var prodcutList = _productService.GetProduct().ToList();  
            foreach(var product in prodcutList)  
            {  
                var productDetailList = _productDetailService.GetProductDetail(product.ProductId);  
                ProductDetail details = new ProductDetail  
                {  
                    ProductId = product.ProductId,    
                    Price = productDetailList.Price,
                    ProductName = product.ProductName,  
                    StockAvailable = productDetailList.StockAvailable,  
                };  
                productDetails.Add(details);  
            }  
            return Ok(productDetails);  
        }
    }
}