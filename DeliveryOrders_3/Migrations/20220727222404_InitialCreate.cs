using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeliveryOrders_3.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DeliveryOrders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SenderCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SenderAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecipientCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecipientAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CargoWeight = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DatePickup = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryOrders", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "DeliveryOrders",
                columns: new[] { "Id", "CargoWeight", "DatePickup", "RecipientAddress", "RecipientCity", "SenderAddress", "SenderCity" },
                values: new object[] { new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"), 5.3m, new DateTime(2022, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Улица Рождественская 15, кв 7", "Нижний Новгород", "Улица Куйбышева 5, кв 51", "Самара" });

            migrationBuilder.InsertData(
                table: "DeliveryOrders",
                columns: new[] { "Id", "CargoWeight", "DatePickup", "RecipientAddress", "RecipientCity", "SenderAddress", "SenderCity" },
                values: new object[] { new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"), 10.5m, new DateTime(2022, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Улица им.Колотушкина 56, кв 36", "Москва", "Улица им.Пушкина 36, кв 5", "Санкт-Петербург" });

            migrationBuilder.InsertData(
                table: "DeliveryOrders",
                columns: new[] { "Id", "CargoWeight", "DatePickup", "RecipientAddress", "RecipientCity", "SenderAddress", "SenderCity" },
                values: new object[] { new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"), 3.5m, new DateTime(2022, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Улица Ленина 65, кв 23", "Омск", "Улица Баныкина 31, кв 65", "Тольятти" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeliveryOrders");
        }
    }
}
