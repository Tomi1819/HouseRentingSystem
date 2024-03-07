namespace HouseRentingSystem.Core.Contracts
{
    public interface IAgentService
    {
        Task<bool> ExistsByIdAsync(string userId);
        Task<bool> UserWithPhoneNumberExistsAsync(string phoneNumber);
        Task<bool> UserHasRents(string userId);
        Task CreateAsync(string userId, string phoneNumber);
    }
}
