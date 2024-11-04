using System.Collections.Generic;
using System.Threading.Tasks;
using ProductRecommendationAPI.Models;

namespace ProductRecommendationAPI.Repositories
{
    public interface IProductRepository
    {
        Task<List<Product>> GetAllProductsAsync();
    }
}
