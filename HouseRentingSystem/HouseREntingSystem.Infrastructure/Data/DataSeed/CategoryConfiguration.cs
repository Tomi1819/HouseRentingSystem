namespace HouseRentingSystem.Infrastructure.Data.DataSeed
{
    using HouseRentingSystem.Infrastructure.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            var data = new DataSeeder();

            builder.HasData(new Category[]
            {
                data.DuplexCategory,
                data.SingleCategory,
                data.CottageCategory
            });
        }
    }
}
