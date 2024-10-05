using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServiceWizard.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class seedData1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "RepairTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "StatusId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "RepairTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "StatusId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "RepairTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "StatusId",
                value: 1);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "RepairTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "StatusId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "RepairTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "StatusId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "RepairTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "StatusId",
                value: 0);
        }
    }
}
