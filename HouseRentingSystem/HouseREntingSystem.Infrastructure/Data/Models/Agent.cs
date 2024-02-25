namespace HouseRentingSystem.Infrastructure.Data.Models
{
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;
    using static HouseRentingSystem.Infrastructure.DataConstants.ValidationConstants;

    [Comment("Agents table")]
    public class Agent
    {
        [Key]
        [Comment("Agent identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(AgentPhoneNumberMaxLength)]
        public string PhoneNumber { get; set; } = string.Empty;

        public IList<House> Houses { get; set; } = new List<House>();
    }
}