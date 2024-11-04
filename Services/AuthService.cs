using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace ProductRecommendationAPI.Services
{
    public class AuthService : IAuthService
    {
        private readonly HttpClient _httpClient;

        public AuthService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> AuthenticateAsync(string username, string password)
        {
            var response = await _httpClient.PostAsJsonAsync("https://api.external-service.com/auth", new { username, password });
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
    }
}
