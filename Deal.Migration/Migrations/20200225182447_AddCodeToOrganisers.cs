using Microsoft.EntityFrameworkCore.Migrations;

namespace Deal.Migration.Migrations
{
    public partial class AddCodeToOrganisers : Microsoft.EntityFrameworkCore.Migrations.Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Organisers",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                table: "Organisers");
        }
    }
}
