namespace HouseRentingSystem.Core.Services
{
    using HouseRentingSystem.Core.Contracts;
    using HouseRentingSystem.Core.Models.Home;
    using HouseRentingSystem.Infrastructure.Data.Common;
    using HouseRentingSystem.Infrastructure.Data.Models;
    using Microsoft.EntityFrameworkCore;

    public class HouseService : IHouseService
    {
        private IRepository repository;

        public HouseService(IRepository repository)
        {
            this.repository = repository;
        }

        public async Task<IEnumerable<HouseIndexServiceModel>> LastThreeHousesAsync()
        {
            return await repository
                .AllReadOnly<House>()
                .OrderByDescending(h => h.Id)
                .Take(3)
                .Select(h => new HouseIndexServiceModel()
                {
                    Id = h.Id,
                    ImageUrl = h.ImageUrl,
                    Title = h.Title
                })
                .ToListAsync();

        }
    }
}
