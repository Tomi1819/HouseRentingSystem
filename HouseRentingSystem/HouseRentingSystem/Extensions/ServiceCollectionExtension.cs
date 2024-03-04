namespace Microsoft.Extensions.DependencyInjection
{
    using HouseRentingSystem.Core.Contracts;
    using HouseRentingSystem.Core.Services;
    using HouseRentingSystem.Data;
    using HouseRentingSystem.Infrastructure.Data;
    using HouseRentingSystem.Infrastructure.Data.Common;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddApplicatinServices(this IServiceCollection services)
        {
            services.AddScoped<IHouseService, HouseService>();
            return services;
        }

        public static IServiceCollection AddApplicatinDbContext(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            services.AddDbContext<HouseRentingDbContext>(options =>
                 options.UseSqlServer(connectionString));

            services.AddDatabaseDeveloperPageExceptionFilter();

            services.AddScoped<IRepository, Repository>();

            return services;
        }

        public static IServiceCollection AddApplicatinIdentity(this IServiceCollection services, IConfiguration config)
        {
            services
                .AddDefaultIdentity<IdentityUser>(options =>
                {
                    options.SignIn.RequireConfirmedAccount = false;
                    options.Password.RequireDigit = false;
                    options.Password.RequireLowercase = false;
                    options.Password.RequireNonAlphanumeric = false;
                    options.Password.RequireUppercase = false;
                })
                .AddEntityFrameworkStores<HouseRentingDbContext>();

            return services;
        }
    }
}
