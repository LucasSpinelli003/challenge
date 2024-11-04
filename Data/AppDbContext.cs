using Microsoft.EntityFrameworkCore;
using ProductRecommendationAPI.Models; // Certifique-se de que este namespace está correto.

namespace ProductRecommendationAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        // Adicione outros DbSets conforme necessário
    }
}
