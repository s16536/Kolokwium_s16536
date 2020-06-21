using Microsoft.EntityFrameworkCore.Migrations;

namespace Kolokwium_s16536.Migrations
{
    public partial class AddedTracksCollectionToMusician : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MusicianIdMusician",
                table: "Track",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Track_MusicianIdMusician",
                table: "Track",
                column: "MusicianIdMusician");

            migrationBuilder.AddForeignKey(
                name: "FK_Track_Musician_MusicianIdMusician",
                table: "Track",
                column: "MusicianIdMusician",
                principalTable: "Musician",
                principalColumn: "IdMusician",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Track_Musician_MusicianIdMusician",
                table: "Track");

            migrationBuilder.DropIndex(
                name: "IX_Track_MusicianIdMusician",
                table: "Track");

            migrationBuilder.DropColumn(
                name: "MusicianIdMusician",
                table: "Track");
        }
    }
}
