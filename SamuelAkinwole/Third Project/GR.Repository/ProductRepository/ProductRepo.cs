using GR.Data.Models;
using GR.Repository.GenericRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GR.Repository.ProductRepository
{
    public class ProductRepo : IProductRepo
    {
        private readonly IGenericRepo<Product> _repository;
        private readonly ILogger _logger;

        public ProductRepo(IGenericRepo<Product> repository,
            ILogger<ProductRepo> logger)
        {
            _repository = repository;
            _logger = logger;
        }
        

        public List<Product> GetAllProducts()
        {
            var products = _repository.GetAll();

            return products.AsQueryable().ToList();
        }

        public Task<Product> GetProduct(int Id)
        {
            var product =  _repository.GetByIdAsync(Id);
            //if (product == null) return -1;
            return product;
        }
        public async Task<int> CreateProduct(Product product)
        {
            bool existingProduct = await _repository.EntityExistsAsync(product.Id);
            if (existingProduct == null) return -1;

            int newProduct = await _repository.CreateAsync(product);
            await _repository.SaveChangesToDbAsync();

            return newProduct;
        }
        public async Task<int> Deleteproduct(int Id)
        {
            var existingProduct = _repository.GetByIdAsync(Id);
            if (existingProduct == null) return -1;

            await _repository.DeleteAsync(Id);
            await _repository.SaveChangesToDbAsync();

            return 1;

            //Product product = await _repository.GetByIdAsync(Id);
            //if (product == null)
            //{
            //    _logger.LogError("Entity cannot be null");
            //}

            //await _repository.DeleteAsync(Id);

            //await _repository.SaveChangesToDbAsync();

            //return 1;
        }

        public async Task<int> UpdateProduct(int Id)
        {
            var product = await _repository.GetByIdAsync(Id);
            if(product == null) return -1;

            var updatedProduct = await _repository.UpdateAsync(product);

            return updatedProduct;
        }
    }
}
