namespace HouseRentingSystem.Core.Models.House
{
    using System.ComponentModel.DataAnnotations;
    using static HouseRentingSystem.Core.Constants.MessageConstants;
    using static HouseRentingSystem.Infrastructure.DataConstants.ValidationConstants;

    public class HouseFormModel
    {
        public HouseFormModel()
        {
            Categories = new List<HouseCategoryServiceModel>();
        }

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(HouseTitleMaxLength,
            MinimumLength = HouseTitleMinLength,
            ErrorMessage = LengthMessage)]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(HouseAddressMaxLength,
            MinimumLength = HouseAddressMinLength,
            ErrorMessage = LengthMessage)]
        public string Address { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(HouseDescriptionMaxLength,
            MinimumLength = HouseDescriptionMinLength,
            ErrorMessage = LengthMessage)]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [Display(Name = "Image URL")]
        public string ImageUrl { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [Range(typeof(decimal),
            MinPricePerMonth,
            MaxPricePerMonth,
            ConvertValueInInvariantCulture = true,
            ErrorMessage = PriceErrorMessage)]
        [Display(Name = "Price Per Month")]
        public decimal PricePerMonth { get; set; }

        [Display(Name = "Category")]
        public int CategoryId { get; set; }
        public IEnumerable<HouseCategoryServiceModel> Categories { get; set; }
    }
}
