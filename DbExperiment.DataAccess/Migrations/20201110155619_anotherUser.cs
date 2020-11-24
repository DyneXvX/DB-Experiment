using Microsoft.EntityFrameworkCore.Migrations;

namespace DbExperiment.Migrations
{
    public partial class anotherUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApplicationUser_FirstName",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApplicationUser_FirstName",
                table: "AspNetUsers");
        }
    }
}
