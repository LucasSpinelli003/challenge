using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ProductRecommendationAPI.Services;

namespace ProductRecommendationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("recommendations")]
        public async Task<IActionResult> GetRecommendations()
        {
            var recommendations = await _productService.GetRecommendationsAsync();
            return Ok(recommendations);
        }
    }
}