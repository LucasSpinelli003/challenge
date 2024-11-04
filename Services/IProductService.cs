using System.Collections.Generic;
using System.Threading.Tasks;
using ProductRecommendationAPI.Models;

namespace ProductRecommendationAPI.Services
{
    public interface IProductService
    {
        Task<List<Product>> GetRecommendationsAsync();
    }
}