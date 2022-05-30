using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Actionlogger.ActionService.EntityFramework.Migrations
{
    public partial class meetings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "MeetingId",
                table: "Actions",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.CreateTable(
                name: "Meetings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Creator = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meetings", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MeetingMembers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    ProfileId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Role = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MeetingId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeetingMembers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MeetingMembers_Meetings_MeetingId",
                        column: x => x.MeetingId,
                        principalTable: "Meetings",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Actions_MeetingId",
                table: "Actions",
                column: "MeetingId");

            migrationBuilder.CreateIndex(
                name: "IX_MeetingMembers_MeetingId",
                table: "MeetingMembers",
                column: "MeetingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Actions_Meetings_MeetingId",
                table: "Actions",
                column: "MeetingId",
                principalTable: "Meetings",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actions_Meetings_MeetingId",
                table: "Actions");

            migrationBuilder.DropTable(
                name: "MeetingMembers");

            migrationBuilder.DropTable(
                name: "Meetings");

            migrationBuilder.DropIndex(
                name: "IX_Actions_MeetingId",
                table: "Actions");

            migrationBuilder.DropColumn(
                name: "MeetingId",
                table: "Actions");
        }
    }
}
