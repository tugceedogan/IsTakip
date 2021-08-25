﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Proje.ToDo.DataAccess.Migrations
{
    public partial class CreateTableAciliyet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AciliyetId",
                table: "Works",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Aciliyetler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tanim = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aciliyetler", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Works_AciliyetId",
                table: "Works",
                column: "AciliyetId");

            migrationBuilder.AddForeignKey(
                name: "FK_Works_Aciliyetler_AciliyetId",
                table: "Works",
                column: "AciliyetId",
                principalTable: "Aciliyetler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Works_Aciliyetler_AciliyetId",
                table: "Works");

            migrationBuilder.DropTable(
                name: "Aciliyetler");

            migrationBuilder.DropIndex(
                name: "IX_Works_AciliyetId",
                table: "Works");

            migrationBuilder.DropColumn(
                name: "AciliyetId",
                table: "Works");
        }
    }
}
