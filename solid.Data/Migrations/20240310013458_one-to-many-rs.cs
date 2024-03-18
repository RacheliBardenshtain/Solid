using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace solid.Data.Migrations
{
    public partial class onetomanyrs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Interviews_Jobs_CurrentJobId",
                table: "Interviews");

            migrationBuilder.RenameColumn(
                name: "CurrentJobId",
                table: "Interviews",
                newName: "JobId");

            migrationBuilder.RenameIndex(
                name: "IX_Interviews_CurrentJobId",
                table: "Interviews",
                newName: "IX_Interviews_JobId");

            migrationBuilder.AddForeignKey(
                name: "FK_Interviews_Jobs_JobId",
                table: "Interviews",
                column: "JobId",
                principalTable: "Jobs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Interviews_Jobs_JobId",
                table: "Interviews");

            migrationBuilder.RenameColumn(
                name: "JobId",
                table: "Interviews",
                newName: "CurrentJobId");

            migrationBuilder.RenameIndex(
                name: "IX_Interviews_JobId",
                table: "Interviews",
                newName: "IX_Interviews_CurrentJobId");

            migrationBuilder.AddForeignKey(
                name: "FK_Interviews_Jobs_CurrentJobId",
                table: "Interviews",
                column: "CurrentJobId",
                principalTable: "Jobs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
