using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DarthPhotos.Db.Migrations
{
    /// <inheritdoc />
    public partial class v003 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SCN_Hash",
                table: "PHT_Scanned",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "SCN_Is_Processed",
                table: "PHT_Scanned",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SCN_Hash",
                table: "PHT_Scanned");

            migrationBuilder.DropColumn(
                name: "SCN_Is_Processed",
                table: "PHT_Scanned");
        }
    }
}
