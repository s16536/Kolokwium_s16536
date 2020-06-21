using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Kolokwium_s16536.Migrations
{
    public partial class AddedAlbumTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdMusicAlbum",
                table: "Track",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Album",
                columns: table => new
                {
                    IdAlbum = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlbumName = table.Column<string>(maxLength: 30, nullable: false),
                    PublishDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Album", x => x.IdAlbum);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Track_IdMusicAlbum",
                table: "Track",
                column: "IdMusicAlbum");

            migrationBuilder.AddForeignKey(
                name: "FK_Track_Album_IdMusicAlbum",
                table: "Track",
                column: "IdMusicAlbum",
                principalTable: "Album",
                principalColumn: "IdAlbum",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Track_Album_IdMusicAlbum",
                table: "Track");

            migrationBuilder.DropTable(
                name: "Album");

            migrationBuilder.DropIndex(
                name: "IX_Track_IdMusicAlbum",
                table: "Track");

            migrationBuilder.DropColumn(
                name: "IdMusicAlbum",
                table: "Track");
        }
    }
}
