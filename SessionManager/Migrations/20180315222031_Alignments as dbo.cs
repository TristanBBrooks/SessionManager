using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SessionManager.Migrations
{
    public partial class Alignmentsasdbo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Alignment",
                table: "Characters");

            migrationBuilder.AddColumn<int>(
                name: "AlignmentId",
                table: "Characters",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Alignments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alignments", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Characters_AlignmentId",
                table: "Characters",
                column: "AlignmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Alignments_AlignmentId",
                table: "Characters",
                column: "AlignmentId",
                principalTable: "Alignments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Alignments_AlignmentId",
                table: "Characters");

            migrationBuilder.DropTable(
                name: "Alignments");

            migrationBuilder.DropIndex(
                name: "IX_Characters_AlignmentId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "AlignmentId",
                table: "Characters");

            migrationBuilder.AddColumn<int>(
                name: "Alignment",
                table: "Characters",
                nullable: false,
                defaultValue: 0);
        }
    }
}
