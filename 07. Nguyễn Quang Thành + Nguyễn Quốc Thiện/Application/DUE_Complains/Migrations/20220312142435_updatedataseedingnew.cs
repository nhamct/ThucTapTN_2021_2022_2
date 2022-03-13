using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DUE_Complains.Migrations
{
    public partial class updatedataseedingnew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "IdStudent",
                table: "AppUsers",
                type: "nvarchar(225)",
                maxLength: 225,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(225)",
                oldMaxLength: 225);

            migrationBuilder.AddColumn<int>(
                name: "idteacher",
                table: "AppUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("ae59a954-c5f1-419a-a3ff-38a4818ee3a0"), "25620d64-d8d1-4be8-b1be-adb8bafeb3b0", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("ae59a954-c5f1-419a-a3ff-38a4818ee3a0"), new Guid("40fb70ec-dbe5-46d0-a55a-a63e751e7ad5") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "IdDepartment", "IdStudent", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "idteacher" },
                values: new object[] { new Guid("40fb70ec-dbe5-46d0-a55a-a63e751e7ad5"), 0, "baa9d907-a18a-4be8-bf32-ee415f969685", "ngquthien3520@gmail.com", true, 0, null, false, null, "Thien", "ngquthien3520@gmail.com", "admin", "AQAAAAEAACcQAAAAEGLIsTo2ttfWGZ964gxrdDeWo04nYbh7rI3suhkZh97mJW1j8Qj/IZXfPGUMZZTHyw==", null, false, "", false, "admin", 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("ae59a954-c5f1-419a-a3ff-38a4818ee3a0"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("ae59a954-c5f1-419a-a3ff-38a4818ee3a0"), new Guid("40fb70ec-dbe5-46d0-a55a-a63e751e7ad5") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("40fb70ec-dbe5-46d0-a55a-a63e751e7ad5"));

            migrationBuilder.DropColumn(
                name: "idteacher",
                table: "AppUsers");

            migrationBuilder.AlterColumn<string>(
                name: "IdStudent",
                table: "AppUsers",
                type: "nvarchar(225)",
                maxLength: 225,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(225)",
                oldMaxLength: 225,
                oldNullable: true);
        }
    }
}
