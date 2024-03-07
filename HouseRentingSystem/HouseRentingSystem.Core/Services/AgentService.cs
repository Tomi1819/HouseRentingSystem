namespace HouseRentingSystem.Core.Services
{
    using HouseRentingSystem.Core.Contracts;
    using HouseRentingSystem.Infrastructure.Data.Common;
    using HouseRentingSystem.Infrastructure.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using System.Threading.Tasks;

    public class AgentService : IAgentService
    {
        private readonly IRepository repository;

        public AgentService(IRepository repository)
        {
            this.repository = repository;
        }

        public async Task CreateAsync(string userId, string phoneNumber)
        {
            await repository.AddAsync(new Agent()
            {
                UserId = userId,
                PhoneNumber = phoneNumber
            });

            await repository.SaveChangesAsync();
        }

        public async Task<bool> ExistsByIdAsync(string userId)
        {
            return await repository
                .AllReadOnly<Agent>()
                .AnyAsync(a => a.UserId == userId);
        }

        public async Task<bool> UserHasRents(string userId)
        {
            return await repository
                .AllReadOnly<House>()
                .AnyAsync(h => h.RenterId == userId);
        }

        public async Task<bool> UserWithPhoneNumberExistsAsync(string phoneNumber)
        {
            return await repository
                .AllReadOnly<Agent>()
                .AnyAsync(a => a.PhoneNumber == phoneNumber);
        }
    }
}
