using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExpenseReportV2.Migrations
{
    public partial class AddMinistryAndTeeam : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppTeam_AppMinistry_MinistryId1",
                table: "AppTeam");

            migrationBuilder.DropIndex(
                name: "IX_AppTeam_MinistryId1",
                table: "AppTeam");

            migrationBuilder.DropColumn(
                name: "MinistryId1",
                table: "AppTeam");

            migrationBuilder.AlterColumn<Guid>(
                name: "MinistryId",
                table: "AppTeam",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_AppTeam_MinistryId",
                table: "AppTeam",
                column: "MinistryId");

            migrationBuilder.AddForeignKey(
                name: "FK_AppTeam_AppMinistry_MinistryId",
                table: "AppTeam",
                column: "MinistryId",
                principalTable: "AppMinistry",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppTeam_AppMinistry_MinistryId",
                table: "AppTeam");

            migrationBuilder.DropIndex(
                name: "IX_AppTeam_MinistryId",
                table: "AppTeam");

            migrationBuilder.AlterColumn<int>(
                name: "MinistryId",
                table: "AppTeam",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "MinistryId1",
                table: "AppTeam",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppTeam_MinistryId1",
                table: "AppTeam",
                column: "MinistryId1");

            migrationBuilder.AddForeignKey(
                name: "FK_AppTeam_AppMinistry_MinistryId1",
                table: "AppTeam",
                column: "MinistryId1",
                principalTable: "AppMinistry",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
