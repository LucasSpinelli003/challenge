using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductRecommendationAPI.Models;
using ProductRecommendationAPI.Repositories;

namespace ProductRecommendationAPI.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<List<Product>> GetRecommendationsAsync()
        {
            var products = await _productRepository.GetAllProductsAsync();
            return products.OrderByDescending(p => p.Rating).ToList();
        }
    }
}
