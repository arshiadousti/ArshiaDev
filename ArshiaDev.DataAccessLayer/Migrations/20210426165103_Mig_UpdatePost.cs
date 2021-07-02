using Microsoft.EntityFrameworkCore.Migrations;

namespace ArshiaDev.DataAccessLayer.Migrations
{
    public partial class Mig_UpdatePost : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsShared",
                table: "Posts",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsShared",
                table: "Posts");
        }
    }
}
