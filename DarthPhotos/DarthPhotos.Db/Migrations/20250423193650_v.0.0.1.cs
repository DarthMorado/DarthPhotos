using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DarthPhotos.Db.Migrations
{
    /// <inheritdoc />
    public partial class v001 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "USR_Gmail",
                table: "ADM_Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "USR_Is_Admin",
                table: "ADM_Users",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "USR_Gmail",
                table: "ADM_Users");

            migrationBuilder.DropColumn(
                name: "USR_Is_Admin",
                table: "ADM_Users");
        }
    }
}
