using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DgMission.Migrations
{
    public partial class AbpMy201812 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "publish_time",
                table: "TencentPositions",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "publish_time",
                table: "TencentPositions",
                nullable: true,
                oldClrType: typeof(DateTime));
        }
    }
}
