using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DUE_Complains.Migrations
{
    public partial class updatedatabaseuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "idteacher",
                table: "AppUsers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AppUsers",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("ae59a954-c5f1-419a-a3ff-38a4818ee3a0"),
                column: "ConcurrencyStamp",
                value: "8a56c24d-e507-48a2-85e4-5bfbce037b23");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("40fb70ec-dbe5-46d0-a55a-a63e751e7ad5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "idteacher" },
                values: new object[] { "90d7a869-c4ab-45cf-9353-c659bfd743ee", "AQAAAAEAACcQAAAAEFzh2m1q48CO1a7UO4KAAfT2Fp8GEhEL7paCQH7JlWmmc99V4aVXI3af3dO4bRHPoA==", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "idteacher",
                table: "AppUsers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AppUsers",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("ae59a954-c5f1-419a-a3ff-38a4818ee3a0"),
                column: "ConcurrencyStamp",
                value: "25620d64-d8d1-4be8-b1be-adb8bafeb3b0");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("40fb70ec-dbe5-46d0-a55a-a63e751e7ad5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "idteacher" },
                values: new object[] { "baa9d907-a18a-4be8-bf32-ee415f969685", "AQAAAAEAACcQAAAAEGLIsTo2ttfWGZ964gxrdDeWo04nYbh7rI3suhkZh97mJW1j8Qj/IZXfPGUMZZTHyw==", 0 });
        }
    }
}
