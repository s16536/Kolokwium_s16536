using Microsoft.EntityFrameworkCore.Migrations;

namespace Kolokwium_s16536.Migrations
{
    public partial class AddedMusicianTrackTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Musician_Track",
                columns: table => new
                {
                    IdMusicianTrack = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdTrack = table.Column<int>(nullable: false),
                    IdMusician = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musician_Track", x => x.IdMusicianTrack);
                    table.ForeignKey(
                        name: "FK_Musician_Track_Musician_IdMusician",
                        column: x => x.IdMusician,
                        principalTable: "Musician",
                        principalColumn: "IdMusician",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Musician_Track_Track_IdTrack",
                        column: x => x.IdTrack,
                        principalTable: "Track",
                        principalColumn: "IdTrack",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Musician_Track_IdMusician",
                table: "Musician_Track",
                column: "IdMusician");

            migrationBuilder.CreateIndex(
                name: "IX_Musician_Track_IdTrack",
                table: "Musician_Track",
                column: "IdTrack");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Musician_Track");
        }
    }
}
