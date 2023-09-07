using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WeighIns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Date = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    Weight = table.Column<decimal>(type: "TEXT", nullable: false),
                    Bmi = table.Column<decimal>(type: "TEXT", nullable: false),
                    BodyFatPercent = table.Column<decimal>(type: "TEXT", nullable: false),
                    MusclePercent = table.Column<decimal>(type: "TEXT", nullable: false),
                    RestingMetabolismCalories = table.Column<int>(type: "INTEGER", nullable: false),
                    BodyAge = table.Column<int>(type: "INTEGER", nullable: false),
                    VisceralFat = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeighIns", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WeighIns");
        }
    }
}
