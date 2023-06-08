using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace M2W5Assessment.Migrations
{
    public partial class AddedPerformerDBset : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_concert_performer_performer_performers_id",
                table: "concert_performer");

            migrationBuilder.DropPrimaryKey(
                name: "pk_performer",
                table: "performer");

            migrationBuilder.RenameTable(
                name: "performer",
                newName: "performers");

            migrationBuilder.AddPrimaryKey(
                name: "pk_performers",
                table: "performers",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_concert_performer_performers_performers_id",
                table: "concert_performer",
                column: "performers_id",
                principalTable: "performers",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_concert_performer_performers_performers_id",
                table: "concert_performer");

            migrationBuilder.DropPrimaryKey(
                name: "pk_performers",
                table: "performers");

            migrationBuilder.RenameTable(
                name: "performers",
                newName: "performer");

            migrationBuilder.AddPrimaryKey(
                name: "pk_performer",
                table: "performer",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_concert_performer_performer_performers_id",
                table: "concert_performer",
                column: "performers_id",
                principalTable: "performer",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
