using System.Collections.Generic;
using System.Threading.Tasks;
using ProductRecommendationAPI.Models;

namespace ProductRecommendationAPI.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public Task<List<Product>> GetAllProductsAsync()
        {
            return Task.FromResult(new List<Product>
            {
                new Product { Id = 1, Name = "Product A", Category = "Category 1", Rating = 4.5 },
                new Product { Id = 2, Name = "Product B", Category = "Category 2", Rating = 4.0 }
            });
        }
    }
}
