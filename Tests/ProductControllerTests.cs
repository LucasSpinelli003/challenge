using Microsoft.AspNetCore.Mvc;
using Moq;
using ProductRecommendationAPI.Controllers;
using ProductRecommendationAPI.Services;
using System.Threading.Tasks;
using Xunit;

namespace ProductRecommendationAPI.Tests
{
    public class ProductControllerTests
    {
        [Fact]
        public async Task GetRecommendations_ShouldReturnOkResult()
        {
            var mockService = new Mock<IProductService>();
            var controller = new ProductController(mockService.Object);

            var result = await controller.GetRecommendations();
            Assert.IsType<OkObjectResult>(result);
        }
    }
}
