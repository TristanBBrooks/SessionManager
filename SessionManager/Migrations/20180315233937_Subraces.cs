using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SessionManager.Migrations
{
    public partial class Subraces : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Races_RaceId",
                table: "Characters");

            migrationBuilder.DropIndex(
                name: "IX_Characters_RaceId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Playable",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "Speed",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "RaceId",
                table: "Characters");

            migrationBuilder.AddColumn<int>(
                name: "SubraceId",
                table: "Characters",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Subraces",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Playable = table.Column<bool>(type: "bit", nullable: false),
                    RaceId = table.Column<int>(type: "int", nullable: true),
                    Size = table.Column<int>(type: "int", nullable: false),
                    Speed = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subraces", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subraces_Races_RaceId",
                        column: x => x.RaceId,
                        principalTable: "Races",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Characters_SubraceId",
                table: "Characters",
                column: "SubraceId");

            migrationBuilder.CreateIndex(
                name: "IX_Subraces_RaceId",
                table: "Subraces",
                column: "RaceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Subraces_SubraceId",
                table: "Characters",
                column: "SubraceId",
                principalTable: "Subraces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Subraces_SubraceId",
                table: "Characters");

            migrationBuilder.DropTable(
                name: "Subraces");

            migrationBuilder.DropIndex(
                name: "IX_Characters_SubraceId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "SubraceId",
                table: "Characters");

            migrationBuilder.AddColumn<bool>(
                name: "Playable",
                table: "Races",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Size",
                table: "Races",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Speed",
                table: "Races",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RaceId",
                table: "Characters",
                nullable: true);

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
    }
}
