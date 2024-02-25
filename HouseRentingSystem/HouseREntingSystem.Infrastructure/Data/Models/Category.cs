namespace HouseRentingSystem.Infrastructure.Data.Models
{
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;
    using static HouseRentingSystem.Infrastructure.DataConstants.ValidationConstants;

    [Comment("Categories table")]
    public class Category
    {
        [Key]
        [Comment("Table identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(CategoryNameMaxLength)]
        [Comment("Table name")]
        public string Name { get; set; } = null!;

        public IEnumerable<House> Houses { get; set; } = new List<House>();
    }
}
