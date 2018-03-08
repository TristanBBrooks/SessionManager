using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SessionManager.Migrations
{
    public partial class UpdateCharacteraddRace : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Race",
                table: "Characters");

            migrationBuilder.AddColumn<int>(
                name: "RaceId",
                table: "Characters",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Races",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Size = table.Column<int>(type: "int", nullable: false),
                    Speed = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Races", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Characters_RaceId",
                table: "Characters",
                column: "RaceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Races_RaceId",
                table: "Characters",
                column: "RaceId",
                principalTable: "Races",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Races_RaceId",
                table: "Characters");

            migrationBuilder.DropTable(
                name: "Races");

            migrationBuilder.DropIndex(
                name: "IX_Characters_RaceId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "RaceId",
                table: "Characters");

            migrationBuilder.AddColumn<int>(
                name: "Race",
                table: "Characters",
                nullable: false,
                defaultValue: 0);
        }
    }
}
