using Microsoft.EntityFrameworkCore.Migrations;

namespace comp2084Winter2022ThursdayCore.Data.Migrations
{
    public partial class Jobs_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "JobID",
                table: "employees",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Jobs",
                columns: table => new
                {
                    JobID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobTitle = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobs", x => x.JobID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_employees_JobID",
                table: "employees",
                column: "JobID");

            migrationBuilder.AddForeignKey(
                name: "FK_employees_Jobs_JobID",
                table: "employees",
                column: "JobID",
                principalTable: "Jobs",
                principalColumn: "JobID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_employees_Jobs_JobID",
                table: "employees");

            migrationBuilder.DropTable(
                name: "Jobs");

            migrationBuilder.DropIndex(
                name: "IX_employees_JobID",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "JobID",
                table: "employees");
        }
    }
}
