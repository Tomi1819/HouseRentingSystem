namespace HouseRentingSystem.Infrastructure.Data.DataSeed
{
    using HouseRentingSystem.Infrastructure.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    internal class AgentConfiguration : IEntityTypeConfiguration<Agent>
    {
        public void Configure(EntityTypeBuilder<Agent> builder)
        {
            var data = new DataSeeder();

            builder.HasData(new Agent[] { data.Agent });
        }
    }
}
