using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SportSeeV2.Server.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserMainEntities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TodayScore = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserMainEntities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KeyDataEntities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CalorieCount = table.Column<int>(type: "INTEGER", nullable: false),
                    ProteinCount = table.Column<int>(type: "INTEGER", nullable: false),
                    CarbohydrateCount = table.Column<int>(type: "INTEGER", nullable: false),
                    LipidCount = table.Column<int>(type: "INTEGER", nullable: false),
                    UserMainEntityId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KeyDataEntities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KeyDataEntities_UserMainEntities_UserMainEntityId",
                        column: x => x.UserMainEntityId,
                        principalTable: "UserMainEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserInfosEntities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    Age = table.Column<int>(type: "INTEGER", nullable: false),
                    UserMainEntityId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInfosEntities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserInfosEntities_UserMainEntities_UserMainEntityId",
                        column: x => x.UserMainEntityId,
                        principalTable: "UserMainEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "UserMainEntities",
                columns: new[] { "Id", "TodayScore" },
                values: new object[,]
                {
                    { 1, 0.12f },
                    { 2, 0.3f }
                });

            migrationBuilder.InsertData(
                table: "KeyDataEntities",
                columns: new[] { "Id", "CalorieCount", "CarbohydrateCount", "LipidCount", "ProteinCount", "UserMainEntityId" },
                values: new object[,]
                {
                    { 1, 1930, 290, 50, 155, 1 },
                    { 2, 2500, 150, 120, 90, 2 }
                });

            migrationBuilder.InsertData(
                table: "UserInfosEntities",
                columns: new[] { "Id", "Age", "FirstName", "LastName", "UserMainEntityId" },
                values: new object[,]
                {
                    { 1, 31, "Karl", "Dovineau", 1 },
                    { 2, 34, "Cecilia", "Ratorez", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_KeyDataEntities_UserMainEntityId",
                table: "KeyDataEntities",
                column: "UserMainEntityId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserInfosEntities_UserMainEntityId",
                table: "UserInfosEntities",
                column: "UserMainEntityId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KeyDataEntities");

            migrationBuilder.DropTable(
                name: "UserInfosEntities");

            migrationBuilder.DropTable(
                name: "UserMainEntities");
        }
    }
}
