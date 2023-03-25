using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project_List_Object.Migrations
{
    public partial class migration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_User_UserId",
                table: "Jobs");

            migrationBuilder.DropIndex(
                name: "IX_Jobs_UserId",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Jobs");

            migrationBuilder.AddColumn<int>(
                name: "JobId",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_User_JobId",
                table: "User",
                column: "JobId");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Jobs_JobId",
                table: "User",
                column: "JobId",
                principalTable: "Jobs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Jobs_JobId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_JobId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "JobId",
                table: "User");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Jobs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_UserId",
                table: "Jobs",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_User_UserId",
                table: "Jobs",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
