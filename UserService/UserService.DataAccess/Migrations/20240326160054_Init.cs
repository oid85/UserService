using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UserService.DataAccess.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: false),
                    Domain = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Domain = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TagToUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    UserId = table.Column<Guid>(type: "TEXT", nullable: false),
                    TagId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TagToUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TagToUsers_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TagToUsers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Domain", "Value" },
                values: new object[] { new Guid("091c5601-8648-4f43-8a46-cb1662023058"), "example1.com", "value1" });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Domain", "Value" },
                values: new object[] { new Guid("28163433-c281-4e02-8330-6163aa6795dc"), "example3.com", "value3" });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Domain", "Value" },
                values: new object[] { new Guid("443cd29d-86c8-4dc0-821a-3b2f262f18aa"), "example2.com", "value2" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Domain", "Name" },
                values: new object[] { new Guid("76d9b3bb-5251-42fa-aa82-d325e7283f17"), "example3.com", "user3" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Domain", "Name" },
                values: new object[] { new Guid("c635ff1a-11f3-40d5-99f7-7f53886e5d82"), "example2.com", "user2" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Domain", "Name" },
                values: new object[] { new Guid("d8d51a5e-1350-4bb0-b96b-190406924a68"), "example1.com", "user1" });

            migrationBuilder.InsertData(
                table: "TagToUsers",
                columns: new[] { "Id", "TagId", "UserId" },
                values: new object[] { new Guid("4472f9de-d200-4c9f-95a1-ae11f4b66cc1"), new Guid("28163433-c281-4e02-8330-6163aa6795dc"), new Guid("76d9b3bb-5251-42fa-aa82-d325e7283f17") });

            migrationBuilder.InsertData(
                table: "TagToUsers",
                columns: new[] { "Id", "TagId", "UserId" },
                values: new object[] { new Guid("506ae79f-0690-447c-925b-66517d206309"), new Guid("443cd29d-86c8-4dc0-821a-3b2f262f18aa"), new Guid("c635ff1a-11f3-40d5-99f7-7f53886e5d82") });

            migrationBuilder.InsertData(
                table: "TagToUsers",
                columns: new[] { "Id", "TagId", "UserId" },
                values: new object[] { new Guid("819b2781-9d76-48d7-bcb9-085da8c44205"), new Guid("091c5601-8648-4f43-8a46-cb1662023058"), new Guid("d8d51a5e-1350-4bb0-b96b-190406924a68") });

            migrationBuilder.CreateIndex(
                name: "IX_TagToUsers_TagId",
                table: "TagToUsers",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_TagToUsers_UserId",
                table: "TagToUsers",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TagToUsers");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
