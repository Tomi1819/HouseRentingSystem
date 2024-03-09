﻿namespace HouseRentingSystem.Core.Contracts
{
    using HouseRentingSystem.Core.Models.Home;
    using HouseRentingSystem.Core.Models.House;

    public interface IHouseService
    {
        Task<IEnumerable<HouseIndexServiceModel>> LastThreeHousesAsync();
        Task<IEnumerable<HouseCategoryServiceModel>> AllCategoriesAsync();
        Task<bool> CategoryExistsAsync(int categoryId);
        Task<int> CreateAsync(HouseFormModel model, int agentId);
    }
}
