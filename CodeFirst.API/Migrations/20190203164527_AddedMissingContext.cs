using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirst.API.Migrations
{
    public partial class AddedMissingContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CartId",
                table: "CartItems",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ExpirationDate", "PurchaseDate" },
                values: new object[] { new DateTime(2019, 2, 13, 16, 45, 26, 79, DateTimeKind.Utc).AddTicks(6332), new DateTime(2019, 2, 3, 16, 45, 26, 79, DateTimeKind.Utc).AddTicks(4923) });

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ExpirationDate", "PurchaseDate" },
                values: new object[] { new DateTime(2019, 2, 13, 16, 45, 26, 79, DateTimeKind.Utc).AddTicks(7841), new DateTime(2019, 2, 3, 16, 45, 26, 79, DateTimeKind.Utc).AddTicks(7834) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CartId",
                table: "CartItems");

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ExpirationDate", "PurchaseDate" },
                values: new object[] { new DateTime(2019, 2, 13, 16, 11, 15, 777, DateTimeKind.Utc).AddTicks(8689), new DateTime(2019, 2, 3, 16, 11, 15, 777, DateTimeKind.Utc).AddTicks(5615) });

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ExpirationDate", "PurchaseDate" },
                values: new object[] { new DateTime(2019, 2, 13, 16, 11, 15, 778, DateTimeKind.Utc).AddTicks(1293), new DateTime(2019, 2, 3, 16, 11, 15, 778, DateTimeKind.Utc).AddTicks(1281) });
        }
    }
}
