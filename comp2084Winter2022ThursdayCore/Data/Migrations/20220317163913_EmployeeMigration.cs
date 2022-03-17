using Microsoft.EntityFrameworkCore.Migrations;

namespace comp2084Winter2022ThursdayCore.Data.Migrations
{
    public partial class EmployeeMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeAge = table.Column<int>(type: "int", nullable: false),
                    EmployeeName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    EmployeePosition = table.Column<string>(type: "nvarchar(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employees", x => x.EmployeeID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "employees");
        }
    }
}
