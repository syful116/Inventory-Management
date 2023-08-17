using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventoryManagement.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CreateInventoryCustomerTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Created", "CreatedBy", "CustomerCity", "CustomerEmail", "CustomerName", "CustomerPhone", "LastModified", "LastModifiedBy", "Status" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2023, 8, 16, 16, 5, 39, 384, DateTimeKind.Unspecified).AddTicks(4970), new TimeSpan(0, 6, 0, 0, 0)), "1", "Dhaka", "tactsotft@gmail.com", "Rumi", "01646928869", null, null, 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
