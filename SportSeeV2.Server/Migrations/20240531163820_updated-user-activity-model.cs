using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportSeeV2.Server.Migrations
{
    /// <inheritdoc />
    public partial class updateduseractivitymodel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ActivitySessions_UserActivities_UserActivityEntityId",
                table: "ActivitySessions");

            migrationBuilder.DropForeignKey(
                name: "FK_UserActivities_UserMainEntities_UserMainEntityId",
                table: "UserActivities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserActivities",
                table: "UserActivities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ActivitySessions",
                table: "ActivitySessions");

            migrationBuilder.RenameTable(
                name: "UserActivities",
                newName: "UserActivityEntity");

            migrationBuilder.RenameTable(
                name: "ActivitySessions",
                newName: "ActivitySessionEntity");

            migrationBuilder.RenameIndex(
                name: "IX_UserActivities_UserMainEntityId",
                table: "UserActivityEntity",
                newName: "IX_UserActivityEntity_UserMainEntityId");

            migrationBuilder.RenameIndex(
                name: "IX_ActivitySessions_UserActivityEntityId",
                table: "ActivitySessionEntity",
                newName: "IX_ActivitySessionEntity_UserActivityEntityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserActivityEntity",
                table: "UserActivityEntity",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ActivitySessionEntity",
                table: "ActivitySessionEntity",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_ActivitySessionEntity_UserActivityEntity_UserActivityEntityId",
                table: "ActivitySessionEntity",
                column: "UserActivityEntityId",
                principalTable: "UserActivityEntity",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserActivityEntity_UserMainEntities_UserMainEntityId",
                table: "UserActivityEntity",
                column: "UserMainEntityId",
                principalTable: "UserMainEntities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ActivitySessionEntity_UserActivityEntity_UserActivityEntityId",
                table: "ActivitySessionEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_UserActivityEntity_UserMainEntities_UserMainEntityId",
                table: "UserActivityEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserActivityEntity",
                table: "UserActivityEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ActivitySessionEntity",
                table: "ActivitySessionEntity");

            migrationBuilder.RenameTable(
                name: "UserActivityEntity",
                newName: "UserActivities");

            migrationBuilder.RenameTable(
                name: "ActivitySessionEntity",
                newName: "ActivitySessions");

            migrationBuilder.RenameIndex(
                name: "IX_UserActivityEntity_UserMainEntityId",
                table: "UserActivities",
                newName: "IX_UserActivities_UserMainEntityId");

            migrationBuilder.RenameIndex(
                name: "IX_ActivitySessionEntity_UserActivityEntityId",
                table: "ActivitySessions",
                newName: "IX_ActivitySessions_UserActivityEntityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserActivities",
                table: "UserActivities",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ActivitySessions",
                table: "ActivitySessions",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_ActivitySessions_UserActivities_UserActivityEntityId",
                table: "ActivitySessions",
                column: "UserActivityEntityId",
                principalTable: "UserActivities",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserActivities_UserMainEntities_UserMainEntityId",
                table: "UserActivities",
                column: "UserMainEntityId",
                principalTable: "UserMainEntities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
