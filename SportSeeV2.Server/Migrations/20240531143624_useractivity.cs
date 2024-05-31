using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SportSeeV2.Server.Migrations
{
    /// <inheritdoc />
    public partial class useractivity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserActivities",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserMainEntityId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserActivities", x => x.id);
                    table.ForeignKey(
                        name: "FK_UserActivities_UserMainEntities_UserMainEntityId",
                        column: x => x.UserMainEntityId,
                        principalTable: "UserMainEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ActivitySessions",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    day = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    kilogram = table.Column<int>(type: "INTEGER", nullable: false),
                    calories = table.Column<int>(type: "INTEGER", nullable: false),
                    UserActivityEntityId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivitySessions", x => x.id);
                    table.ForeignKey(
                        name: "FK_ActivitySessions_UserActivities_UserActivityEntityId",
                        column: x => x.UserActivityEntityId,
                        principalTable: "UserActivities",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "UserActivities",
                columns: new[] { "id", "UserMainEntityId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "ActivitySessions",
                columns: new[] { "id", "UserActivityEntityId", "calories", "day", "kilogram" },
                values: new object[,]
                {
                    { 1, 1, 240, new DateOnly(2020, 7, 1), 80 },
                    { 2, 1, 220, new DateOnly(2020, 7, 2), 80 },
                    { 3, 1, 280, new DateOnly(2020, 7, 3), 81 },
                    { 4, 1, 290, new DateOnly(2020, 7, 4), 81 },
                    { 5, 1, 160, new DateOnly(2020, 7, 5), 80 },
                    { 6, 1, 162, new DateOnly(2020, 7, 6), 78 },
                    { 7, 1, 390, new DateOnly(2020, 7, 7), 76 },
                    { 8, 2, 240, new DateOnly(2020, 7, 1), 70 },
                    { 9, 2, 220, new DateOnly(2020, 7, 2), 69 },
                    { 10, 2, 280, new DateOnly(2020, 7, 3), 70 },
                    { 11, 2, 500, new DateOnly(2020, 7, 4), 70 },
                    { 12, 2, 160, new DateOnly(2020, 7, 5), 69 },
                    { 13, 2, 162, new DateOnly(2020, 7, 6), 69 },
                    { 14, 2, 390, new DateOnly(2020, 7, 7), 69 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActivitySessions_UserActivityEntityId",
                table: "ActivitySessions",
                column: "UserActivityEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_UserActivities_UserMainEntityId",
                table: "UserActivities",
                column: "UserMainEntityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActivitySessions");

            migrationBuilder.DropTable(
                name: "UserActivities");
        }
    }
}
