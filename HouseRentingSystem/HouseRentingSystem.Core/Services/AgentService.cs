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

        public async Task<bool> ExistsById(string userId)
        {
            return await repository
                .AllReadOnly<Agent>().AnyAsync(a => a.UserId == userId);
        }
    }
}
