namespace HouseRentingSystem.Infrastructure.Data.DataSeed
{
    using HouseRentingSystem.Infrastructure.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal class HouseConfiguration : IEntityTypeConfiguration<House>
    {
        public void Configure(EntityTypeBuilder<House> builder)
        {
            builder
                .HasOne(h => h.Agent)
                .WithMany(h => h.Houses)
                .HasForeignKey(h => h.AgentId)
            .OnDelete(DeleteBehavior.Restrict);

            builder
                 .HasOne(h => h.Category)
                 .WithMany(h => h.Houses)
                 .HasForeignKey(h => h.CategoryId)
                 .OnDelete(DeleteBehavior.Restrict);

            var data = new DataSeeder();

            builder.HasData(new House[]
            {
                data.FirstHouse,
                data.SecondHouse,
                data.ThirdHouse
            });
        }
    }
}
