using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DarthPhotos.Db.Migrations
{
    /// <inheritdoc />
    public partial class v002 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PHT_Photos",
                columns: table => new
                {
                    PHT_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PHT_Path = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PHT_Creator_USR_ID = table.Column<int>(type: "int", nullable: false),
                    PHT_Is_Scanned = table.Column<bool>(type: "bit", nullable: false),
                    PHT_Size = table.Column<int>(type: "int", nullable: false),
                    PHT_Hash = table.Column<byte[]>(type: "varbinary(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PHT_Photos", x => x.PHT_ID);
                    table.ForeignKey(
                        name: "FK_PHT_Photos_ADM_Users_PHT_Creator_USR_ID",
                        column: x => x.PHT_Creator_USR_ID,
                        principalTable: "ADM_Users",
                        principalColumn: "USR_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PHT_Scanned",
                columns: table => new
                {
                    SCN_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SCN_Path = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SCN_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SCN_USR_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PHT_Scanned", x => x.SCN_ID);
                    table.ForeignKey(
                        name: "FK_PHT_Scanned_ADM_Users_SCN_USR_Id",
                        column: x => x.SCN_USR_Id,
                        principalTable: "ADM_Users",
                        principalColumn: "USR_ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_PHT_Photos_PHT_Creator_USR_ID",
                table: "PHT_Photos",
                column: "PHT_Creator_USR_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PHT_Scanned_SCN_USR_Id",
                table: "PHT_Scanned",
                column: "SCN_USR_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PHT_Photos");

            migrationBuilder.DropTable(
                name: "PHT_Scanned");
        }
    }
}
