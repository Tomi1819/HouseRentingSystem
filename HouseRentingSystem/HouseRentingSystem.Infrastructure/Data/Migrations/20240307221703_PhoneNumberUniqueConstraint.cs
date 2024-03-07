using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem.Data.Migrations
{
    public partial class PhoneNumberUniqueConstraint : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e4929622-16ba-4262-b5fc-1bf2ab145e23", "AQAAAAEAACcQAAAAEKs3nmFV6g85LjZWxKDtc/KTK2tBMsIHQ+bq9ngLst/O6aSMBY5roke5BAROHGz37Q==", "351145c4-040b-4548-bb92-b21cb7c61266" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ffeb1c1a-fe09-47d4-844e-63311d301420", "AQAAAAEAACcQAAAAEJky3+Fr3duycd4IEi3tlN5b+RlVShlPjErRpmEPX9nRANd6rW05yYIvWKQWBmrmcA==", "cc380835-d470-4e9e-96b9-aec0fcf12b3f" });

            migrationBuilder.CreateIndex(
                name: "IX_Agents_PhoneNumber",
                table: "Agents",
                column: "PhoneNumber",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Agents_PhoneNumber",
                table: "Agents");

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
        }
    }
}
