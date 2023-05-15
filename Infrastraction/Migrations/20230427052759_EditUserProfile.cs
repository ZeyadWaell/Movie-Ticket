using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastraction.Migrations
{
    public partial class EditUserProfile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BestMovie",
                table: "Profiles");

            migrationBuilder.AddColumn<int>(
                name: "UserProfileId",
                table: "Movies",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Movies_UserProfileId",
                table: "Movies",
                column: "UserProfileId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Profiles_UserProfileId",
                table: "Movies",
                column: "UserProfileId",
                principalTable: "Profiles",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Profiles_UserProfileId",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Movies_UserProfileId",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "UserProfileId",
                table: "Movies");

            migrationBuilder.AddColumn<string>(
                name: "BestMovie",
                table: "Profiles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
