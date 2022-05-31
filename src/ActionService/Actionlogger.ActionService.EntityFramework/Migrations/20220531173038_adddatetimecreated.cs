using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Actionlogger.ActionService.EntityFramework.Migrations
{
    public partial class adddatetimecreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateTimeCreated",
                table: "Meetings",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateTimeCreated",
                table: "MeetingMembers",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateTimeCreated",
                table: "Actions",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateTimeCreated",
                table: "Meetings");

            migrationBuilder.DropColumn(
                name: "DateTimeCreated",
                table: "MeetingMembers");

            migrationBuilder.DropColumn(
                name: "DateTimeCreated",
                table: "Actions");
        }
    }
}
