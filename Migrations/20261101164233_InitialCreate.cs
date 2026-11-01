using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DailyHilfy.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DailyEntries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Date = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    WorkMinutes = table.Column<int>(type: "INTEGER", nullable: false),
                    WorkDescription = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true),
                    ExerciseMinutes = table.Column<int>(type: "INTEGER", nullable: false),
                    ExerciseDescription = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true),
                    FinanceAmount = table.Column<decimal>(type: "TEXT", nullable: true),
                    FinanceType = table.Column<string>(type: "TEXT", nullable: true),
                    FinanceDescription = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true),
                    Notes = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyEntries", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DailyEntries");
        }
    }
}
