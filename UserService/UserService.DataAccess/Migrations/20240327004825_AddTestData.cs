using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UserService.DataAccess.Migrations
{
    public partial class AddTestData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Domain", "Name" },
                values: new object[] { new Guid("05e7fa98-07d7-43dd-adc8-80e8ad6268c5"), "example1.com", "user11" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Domain", "Name" },
                values: new object[] { new Guid("50ef2384-c08a-4631-bd21-b2d70b2ae3c3"), "example1.com", "user12" });

            migrationBuilder.InsertData(
                table: "TagToUsers",
                columns: new[] { "Id", "TagId", "UserId" },
                values: new object[] { new Guid("2c7e7c4a-84df-4fb9-a0be-8f0c24d3add4"), new Guid("091c5601-8648-4f43-8a46-cb1662023058"), new Guid("05e7fa98-07d7-43dd-adc8-80e8ad6268c5") });

            migrationBuilder.InsertData(
                table: "TagToUsers",
                columns: new[] { "Id", "TagId", "UserId" },
                values: new object[] { new Guid("78ad0162-3502-4900-b945-1764ad2da5c8"), new Guid("091c5601-8648-4f43-8a46-cb1662023058"), new Guid("50ef2384-c08a-4631-bd21-b2d70b2ae3c3") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TagToUsers",
                keyColumn: "Id",
                keyValue: new Guid("2c7e7c4a-84df-4fb9-a0be-8f0c24d3add4"));

            migrationBuilder.DeleteData(
                table: "TagToUsers",
                keyColumn: "Id",
                keyValue: new Guid("78ad0162-3502-4900-b945-1764ad2da5c8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("05e7fa98-07d7-43dd-adc8-80e8ad6268c5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("50ef2384-c08a-4631-bd21-b2d70b2ae3c3"));
        }
    }
}
