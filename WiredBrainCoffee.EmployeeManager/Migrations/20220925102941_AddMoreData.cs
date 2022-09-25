using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WiredBrainCoffee.EmployeeManager.Migrations
{
    public partial class AddMoreData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DepartmentId", "FirstName", "IsDeveloper", "LastName" },
                values: new object[,]
                {
                    { 10, 2, "I", false, "Nguyen" },
                    { 11, 2, "K", false, "Nguyen" },
                    { 12, 1, "L", false, "Nguyen" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 12);
        }
    }
}
