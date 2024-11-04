using Microsoft.EntityFrameworkCore;
using ProductRecommendationAPI.Data;
using ProductRecommendationAPI.Repositories;
using ProductRecommendationAPI.Services;

namespace ProductRecommendationAPI
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

         public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseOracle(Configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IProductService, ProductService>();
            services.AddHttpClient<IAuthService, AuthService>();

            services.AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
