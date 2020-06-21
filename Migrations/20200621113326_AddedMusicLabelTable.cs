using Microsoft.EntityFrameworkCore.Migrations;

namespace Kolokwium_s16536.Migrations
{
    public partial class AddedMusicLabelTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdMusicLabel",
                table: "Album",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "MusicLabel",
                columns: table => new
                {
                    IdMusicLabel = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MusicLabel", x => x.IdMusicLabel);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Album_IdMusicLabel",
                table: "Album",
                column: "IdMusicLabel");

            migrationBuilder.AddForeignKey(
                name: "FK_Album_MusicLabel_IdMusicLabel",
                table: "Album",
                column: "IdMusicLabel",
                principalTable: "MusicLabel",
                principalColumn: "IdMusicLabel",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Album_MusicLabel_IdMusicLabel",
                table: "Album");

            migrationBuilder.DropTable(
                name: "MusicLabel");

            migrationBuilder.DropIndex(
                name: "IX_Album_IdMusicLabel",
                table: "Album");

            migrationBuilder.DropColumn(
                name: "IdMusicLabel",
                table: "Album");
        }
    }
}
