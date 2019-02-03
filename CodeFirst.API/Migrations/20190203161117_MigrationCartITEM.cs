using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirst.API.Migrations
{
    public partial class MigrationCartITEM : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Weight = table.Column<int>(nullable: false),
                    PurchaseDate = table.Column<DateTime>(nullable: false),
                    ExpirationDate = table.Column<DateTime>(nullable: false),
                    Calories = table.Column<int>(nullable: false),
                    Sacharides = table.Column<int>(nullable: false),
                    Proteins = table.Column<int>(nullable: false),
                    Fats = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "CartItems",
                columns: new[] { "Id", "Calories", "Description", "ExpirationDate", "Fats", "Name", "Proteins", "PurchaseDate", "Sacharides", "Weight" },
                values: new object[] { 1, 150, "Cheat day", new DateTime(2019, 2, 13, 16, 11, 15, 777, DateTimeKind.Utc).AddTicks(8689), 100, "Snack", 100, new DateTime(2019, 2, 3, 16, 11, 15, 777, DateTimeKind.Utc).AddTicks(5615), 100, 100 });

            migrationBuilder.InsertData(
                table: "CartItems",
                columns: new[] { "Id", "Calories", "Description", "ExpirationDate", "Fats", "Name", "Proteins", "PurchaseDate", "Sacharides", "Weight" },
                values: new object[] { 2, 333, "xxx", new DateTime(2019, 2, 13, 16, 11, 15, 778, DateTimeKind.Utc).AddTicks(1293), 111, "Healthy", 222, new DateTime(2019, 2, 3, 16, 11, 15, 778, DateTimeKind.Utc).AddTicks(1281), 333, 222 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItems");
        }
    }
}
