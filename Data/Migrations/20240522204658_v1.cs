using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CsharpCRUD.Data.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Premiuns_Premiuns_PremiumId",
                table: "Premiuns");

            migrationBuilder.DropForeignKey(
                name: "FK_Premiuns_Students_StudentId",
                table: "Premiuns");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Premiuns",
                table: "Premiuns");

            migrationBuilder.RenameTable(
                name: "Premiuns",
                newName: "Premiums");

            migrationBuilder.RenameIndex(
                name: "IX_Premiuns_StudentId",
                table: "Premiums",
                newName: "IX_Premiums_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_Premiuns_PremiumId",
                table: "Premiums",
                newName: "IX_Premiums_PremiumId");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Students",
                type: "TEXT",
                maxLength: 32,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Premiums",
                table: "Premiums",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Premiums_Premiums_PremiumId",
                table: "Premiums",
                column: "PremiumId",
                principalTable: "Premiums",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Premiums_Students_StudentId",
                table: "Premiums",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Premiums_Premiums_PremiumId",
                table: "Premiums");

            migrationBuilder.DropForeignKey(
                name: "FK_Premiums_Students_StudentId",
                table: "Premiums");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Premiums",
                table: "Premiums");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Students");

            migrationBuilder.RenameTable(
                name: "Premiums",
                newName: "Premiuns");

            migrationBuilder.RenameIndex(
                name: "IX_Premiums_StudentId",
                table: "Premiuns",
                newName: "IX_Premiuns_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_Premiums_PremiumId",
                table: "Premiuns",
                newName: "IX_Premiuns_PremiumId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Premiuns",
                table: "Premiuns",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Premiuns_Premiuns_PremiumId",
                table: "Premiuns",
                column: "PremiumId",
                principalTable: "Premiuns",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Premiuns_Students_StudentId",
                table: "Premiuns",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
