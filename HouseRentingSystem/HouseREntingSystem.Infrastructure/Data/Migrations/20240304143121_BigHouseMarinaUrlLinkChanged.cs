using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem.Data.Migrations
{
    public partial class BigHouseMarinaUrlLinkChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "86d3f72e-c872-46c8-bd9b-823962ef26a4", "AQAAAAEAACcQAAAAEJJSFVIhUy39IXcdTy80EmgldZEL6IcTjLYqvl3Tr6vOYEiZbjycDmHUmEDIlZBQMg==", "1efed114-b596-47ea-b2eb-14234c08d929" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6dd4e383-505c-475c-bbdd-2a93e0376c64", "AQAAAAEAACcQAAAAEOtjkRnxEA1ki31fIcEo/kV2kZ9FIEVPi7XX/GeHW0Jf3snUX+3EA4hq43y7Lm/ThA==", "063da92d-87d4-41b2-b5f7-62104cff84aa" });

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://bgvoice.com/wp-content/uploads/2020/05/fachada-casa-esplugues_de_llobregat_1279-img3476652-26961759G.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "906e6501-41f2-425a-9c2a-26c299be5d26", "AQAAAAEAACcQAAAAEPSODOTT8QokQYjLKiket/ypMad8iEgKfgJQ3gdX4KbS47HBJV9rARlxWHcfI4zJ5A==", "13bd0ac9-17bd-492e-8777-d8713edbf618" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "39e04b39-c0cc-4261-8543-1114dda43bbc", "AQAAAAEAACcQAAAAELdRXyEuugdUEGBLk4zh0+ETD2tkVwNJiyMDsDkX8vjIJkIQcOHyJPXsfrz57vpb6w==", "0b3ee67d-6740-4dae-a81d-74aee101b75d" });

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://www.luxury-architecture.net/wp-content/uploads/2017/12/1513217889-7597-FAIRWAYS-010.jpg");
        }
    }
}
