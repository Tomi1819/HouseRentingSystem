namespace HouseRentingSystem.Core.Models.Agent
{
    using System.ComponentModel.DataAnnotations;
    using static Constants.MessageConstants;
    using static HouseRentingSystem.Infrastructure.DataConstants.ValidationConstants;
    public class BecomeAgentFormModel
    {
        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(AgentPhoneNumberMaxLength,
            MinimumLength = AgentPhoneNumberMinLength,
            ErrorMessage = LengthMessage)]
        [Display(Name = "Phone number")]
        [Phone]
        public string PhoneNumber { get; set; } = null!;
    }
}
