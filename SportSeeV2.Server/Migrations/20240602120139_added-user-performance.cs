using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SportSeeV2.Server.Migrations
{
    /// <inheritdoc />
    public partial class addeduserperformance : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserPerformanceEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserMainEntityId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPerformanceEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserPerformanceEntity_UserMainEntities_UserMainEntityId",
                        column: x => x.UserMainEntityId,
                        principalTable: "UserMainEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PerformanceDataEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Value = table.Column<int>(type: "INTEGER", nullable: false),
                    Kind = table.Column<int>(type: "INTEGER", nullable: false),
                    UserPerformanceEntityId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerformanceDataEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PerformanceDataEntity_UserPerformanceEntity_UserPerformanceEntityId",
                        column: x => x.UserPerformanceEntityId,
                        principalTable: "UserPerformanceEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "UserPerformanceEntity",
                columns: new[] { "Id", "UserMainEntityId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "PerformanceDataEntity",
                columns: new[] { "Id", "Kind", "UserPerformanceEntityId", "Value" },
                values: new object[,]
                {
                    { 1, 1, 1, 80 },
                    { 2, 2, 1, 120 },
                    { 3, 3, 1, 140 },
                    { 4, 4, 1, 50 },
                    { 5, 5, 1, 200 },
                    { 6, 6, 1, 90 },
                    { 7, 1, 2, 200 },
                    { 8, 2, 2, 240 },
                    { 9, 3, 2, 80 },
                    { 10, 4, 2, 80 },
                    { 11, 5, 2, 220 },
                    { 12, 6, 2, 110 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PerformanceDataEntity_UserPerformanceEntityId",
                table: "PerformanceDataEntity",
                column: "UserPerformanceEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPerformanceEntity_UserMainEntityId",
                table: "UserPerformanceEntity",
                column: "UserMainEntityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PerformanceDataEntity");

            migrationBuilder.DropTable(
                name: "UserPerformanceEntity");
        }
    }
}
