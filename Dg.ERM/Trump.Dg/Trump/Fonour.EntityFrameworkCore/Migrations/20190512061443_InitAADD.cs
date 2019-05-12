using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Fonour.EntityFrameworkCore.Migrations
{
    public partial class InitAADD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    EMail = table.Column<string>(nullable: true),
                    MobileNumber = table.Column<string>(nullable: true),
                    Remarks = table.Column<string>(nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: true),
                    LastLoginTime = table.Column<DateTime>(nullable: false),
                    LoginTimes = table.Column<int>(nullable: false),
                    DeptmentId = table.Column<Guid>(nullable: false),
                    IsDeleted = table.Column<int>(nullable: false),
                    DepartmentID = table.Column<long>(nullable: false),
                    CreateUser = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
