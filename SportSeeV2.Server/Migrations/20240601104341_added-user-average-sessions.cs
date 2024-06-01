using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SportSeeV2.Server.Migrations
{
    /// <inheritdoc />
    public partial class addeduseraveragesessions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserAverageSessionsEntity",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserMainEntityId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAverageSessionsEntity", x => x.id);
                    table.ForeignKey(
                        name: "FK_UserAverageSessionsEntity_UserMainEntities_UserMainEntityId",
                        column: x => x.UserMainEntityId,
                        principalTable: "UserMainEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SessionsEntity",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    day = table.Column<int>(type: "INTEGER", nullable: false),
                    sessionLength = table.Column<int>(type: "INTEGER", nullable: false),
                    UserAverageSessionsEntityId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SessionsEntity", x => x.id);
                    table.ForeignKey(
                        name: "FK_SessionsEntity_UserAverageSessionsEntity_UserAverageSessionsEntityId",
                        column: x => x.UserAverageSessionsEntityId,
                        principalTable: "UserAverageSessionsEntity",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "UserAverageSessionsEntity",
                columns: new[] { "id", "UserMainEntityId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "SessionsEntity",
                columns: new[] { "id", "UserAverageSessionsEntityId", "day", "sessionLength" },
                values: new object[,]
                {
                    { 1, 1, 1, 30 },
                    { 2, 1, 2, 23 },
                    { 3, 1, 3, 45 },
                    { 4, 1, 4, 50 },
                    { 5, 1, 5, 0 },
                    { 6, 1, 6, 0 },
                    { 7, 1, 7, 60 },
                    { 8, 2, 1, 30 },
                    { 9, 2, 2, 40 },
                    { 10, 2, 3, 50 },
                    { 11, 2, 4, 30 },
                    { 12, 2, 5, 30 },
                    { 13, 2, 6, 50 },
                    { 14, 2, 7, 50 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SessionsEntity_UserAverageSessionsEntityId",
                table: "SessionsEntity",
                column: "UserAverageSessionsEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAverageSessionsEntity_UserMainEntityId",
                table: "UserAverageSessionsEntity",
                column: "UserMainEntityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SessionsEntity");

            migrationBuilder.DropTable(
                name: "UserAverageSessionsEntity");
        }
    }
}
