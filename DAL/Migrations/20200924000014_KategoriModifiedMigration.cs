using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class KategoriModifiedMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Aciklama",
                table: "Kategoris",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Logo",
                table: "Kategoris",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Aciklama",
                table: "Kategoris");

            migrationBuilder.DropColumn(
                name: "Logo",
                table: "Kategoris");
        }
    }
}
