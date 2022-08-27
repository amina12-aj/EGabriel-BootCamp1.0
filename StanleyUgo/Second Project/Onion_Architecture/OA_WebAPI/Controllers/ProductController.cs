using Microsoft.AspNetCore.Mvc;
using OA_DataAccess;
using OA_Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OA_WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private readonly IProductService productService;
        private readonly IProductDetailsService productDetailsService;

        public ProductController(IProductService productService, IProductDetailsService productDetailsService)
        {
            this.productService = productService;
            this.productDetailsService = productDetailsService;
        }

        [HttpGet]
        public List<ProductDetails> Get()
        {
            List<ProductDetails> productDetails = new List<ProductDetails>();
            var prodcutList = productService.GetProduct().ToList();
            foreach (var product in prodcutList)
            {
                var productDetailList = productDetailsService.GetProductDetail(product.ProductId);
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
