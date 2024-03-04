namespace HouseRentingSystem.Core.Contracts
{
    using HouseRentingSystem.Core.Models.Home;

    public interface IHouseService
    {
        Task<IEnumerable<HouseIndexServiceModel>> LastThreeHousesAsync();
    }
}
