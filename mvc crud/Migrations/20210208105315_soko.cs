using Microsoft.EntityFrameworkCore.Migrations;

namespace mvc_crud.Migrations
{
    public partial class soko : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    FirstName = table.Column<string>(type: "Varchar(100)", nullable: false),
                    LastName = table.Column<string>(type: "Varchar(100)", nullable: false),
                    CIN = table.Column<string>(type: "Varchar(100)", nullable: false),
                    Address = table.Column<string>(type: "Varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.FirstName);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
