using System.Threading.Tasks;

namespace ProductRecommendationAPI.Services
{
    public interface IAuthService
    {
        Task<string> AuthenticateAsync(string username, string password);
    }
}
