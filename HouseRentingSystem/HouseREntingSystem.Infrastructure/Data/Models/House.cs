namespace HouseRentingSystem.Infrastructure.Data.Models
{
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using static HouseRentingSystem.Infrastructure.DataConstants.ValidationConstants;

    [Comment("Houses table")]
    public class House
    {
        [Key]
        [Comment("House identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(HouseTitleMaxLength)]
        [Comment("House title")]
        public int Title { get; set; }

        [Required]
        [MaxLength(HouseAddressMaxLength)]
        [Comment("House address")]
        public int Address { get; set; }

        [Required]
        [MaxLength(HouseDescriptionMaxLength)]
        [Comment("House description")]
        public int Description { get; set; }

        [Required]
        [Comment("House image url")]
        public string ImageUrl { get; set; } = string.Empty;

        [Required]
        [Comment("Monthly price")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal PricePerMonth { get; set; }

        [Comment("User id of the renterer")]
        public string? RenterId { get; set; }

        [Required]
        [Comment("Category identifier")]
        public int CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; } = null!;

        [Required]
        [Comment("Agent identifier")]
        public int AgentId { get; set; }

        [ForeignKey(nameof(AgentId))]
        public Agent Agent { get; set; } = null!;
    }
}