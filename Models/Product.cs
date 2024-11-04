using System.ComponentModel.DataAnnotations;

namespace ProductRecommendationAPI.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Category { get; set; }
        public double Rating { get; set; }
    }

}