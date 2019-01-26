using Microsoft.EntityFrameworkCore.Migrations;

namespace DgMission.Migrations
{
    public partial class AbpMy201809 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameIndex(
                name: "IX_AbpUserLoginUserNameOrEmailAddress_Result",
                table: "AbpUserLoginAttempts",
                newName: "IX_AbpUserLoginUserNameOrEmailAddress_Result");

            migrationBuilder.RenameIndex(
                name: "IX_AbpNotification_Notification_EntityId_UserId",
                table: "AbpNotificationSubscriptions",
                newName: "IX_AbpNotificationSubscriptions_TenantIdEntityId_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpNotification_NotificationName_EntityId_UserId",
                table: "AbpNotificationSubscriptions",
                newName: "IX_AbpNotificationSubscriptions_NotificationName_UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameIndex(
                name: "IX_AbpUserLoginUserNameOrEmailAddress_Result",
                table: "AbpUserLoginAttempts",
                newName: "IX_AbpUserLoginUserNameOrEmailAddress_Result");

            migrationBuilder.RenameIndex(
                name: "IX_AbpNotification_Notification_EntityId_UserId",
                table: "AbpNotificationSubscriptions",
                newName: "IX_AbpNotificationSubscriptions_TenantIdEntityId_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpNotification_NotificationName_EntityId_UserId",
                table: "AbpNotificationSubscriptions",
                newName: "IX_AbpNotificationSubscriptions_NotificationName_UserId");
        }
    }
}
