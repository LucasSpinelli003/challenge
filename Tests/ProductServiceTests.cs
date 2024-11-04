using Moq;
using ProductRecommendationAPI.Models;
using ProductRecommendationAPI.Repositories;
using ProductRecommendationAPI.Services;
using System.Threading.Tasks;
using Xunit;

namespace ProductRecommendationAPI.Tests
{
    public class ProductServiceTests
    {
        [Fact]
        public async Task GetRecommendations_ShouldReturnProducts()
        {
            var mockRepo = new Mock<IProductRepository>();
            mockRepo.Setup(repo => repo.GetAllProductsAsync()).ReturnsAsync(new List<Product>());
            var service = new ProductService(mockRepo.Object);

            var result = await service.GetRecommendationsAsync();
            Assert.NotNull(result);
        }
    }
}
