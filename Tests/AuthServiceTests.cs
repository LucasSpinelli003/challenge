using Moq;
using ProductRecommendationAPI.Services;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace ProductRecommendationAPI.Tests
{
    public class AuthServiceTests
    {
        [Fact]
        public async Task AuthenticateAsync_ShouldReturnToken()
        {
            var mockHttp = new Mock<HttpClient>();
            var authService = new AuthService(mockHttp.Object);

            var token = await authService.AuthenticateAsync("user", "password");
            Assert.NotNull(token);
        }
    }
}