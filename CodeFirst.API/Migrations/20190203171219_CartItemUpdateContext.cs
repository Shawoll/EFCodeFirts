using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirst.API.Migrations
{
    public partial class CartItemUpdateContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ExpirationDate", "PurchaseDate" },
                values: new object[] { new DateTime(2019, 2, 13, 17, 12, 18, 662, DateTimeKind.Utc).AddTicks(8014), new DateTime(2019, 2, 3, 17, 12, 18, 662, DateTimeKind.Utc).AddTicks(7135) });

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ExpirationDate", "PurchaseDate" },
                values: new object[] { new DateTime(2019, 2, 13, 17, 12, 18, 662, DateTimeKind.Utc).AddTicks(8972), new DateTime(2019, 2, 3, 17, 12, 18, 662, DateTimeKind.Utc).AddTicks(8969) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
