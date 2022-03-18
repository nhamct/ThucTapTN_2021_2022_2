using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DUE_Complains.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppConfigs",
                columns: table => new
                {
                    Key = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppConfigs", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "AppRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IdDepartment = table.Column<int>(type: "int", nullable: false),
                    IdStudent = table.Column<string>(type: "nvarchar(225)", maxLength: 225, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(225)", maxLength: 225, nullable: true),
                    totalstudent = table.Column<int>(type: "int", nullable: true),
                    totalemployee = table.Column<int>(type: "int", nullable: true),
                    phone = table.Column<string>(type: "char(11)", unicode: false, fixedLength: true, maxLength: 11, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Departme__3214EC07150FB4F0", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idDepartment = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(225)", maxLength: 225, nullable: true),
                    position = table.Column<string>(type: "nvarchar(225)", maxLength: 225, nullable: true),
                    IdDepartmentNavigationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.id);
                    table.ForeignKey(
                        name: "FK__Employees__idDep__2E1BDC42",
                        column: x => x.idDepartment,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employees_Employees_IdDepartmentNavigationId",
                        column: x => x.IdDepartmentNavigationId,
                        principalTable: "Employees",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    studentcode = table.Column<string>(type: "varchar(225)", unicode: false, maxLength: 225, nullable: false),
                    email = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: true),
                    phone = table.Column<string>(type: "varchar(11)", unicode: false, maxLength: 11, nullable: true),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sclass = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DepartmentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Students__A5703329F248FB09", x => x.studentcode);
                    table.ForeignKey(
                        name: "FK_Students_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "complains",
                columns: table => new
                {
                    IdComplain = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdStudent = table.Column<string>(type: "varchar(225)", unicode: false, maxLength: 225, nullable: true),
                    IdDepartment = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(225)", maxLength: 225, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    reply = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    date = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    IsPublic = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    status = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, defaultValueSql: "N'Bản nháp'"),
                    IdDepartmentNavigationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__complain__DC12E46E98597387", x => x.IdComplain);
                    table.ForeignKey(
                        name: "FK__complains__IdStu__2D27B809",
                        column: x => x.IdStudent,
                        principalTable: "Students",
                        principalColumn: "studentcode",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_complains_Departments_IdDepartment",
                        column: x => x.IdDepartment,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_complains_Employees_IdDepartmentNavigationId",
                        column: x => x.IdDepartmentNavigationId,
                        principalTable: "Employees",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ImageComplain",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    content_image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Path_image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdComplain = table.Column<int>(type: "int", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    filesize = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ImageCom__3213E83F160F617E", x => x.id);
                    table.ForeignKey(
                        name: "FK__ImageComp__IdCom__73BA3083",
                        column: x => x.IdComplain,
                        principalTable: "complains",
                        principalColumn: "IdComplain",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_complains_IdDepartment",
                table: "complains",
                column: "IdDepartment");

            migrationBuilder.CreateIndex(
                name: "IX_complains_IdDepartmentNavigationId",
                table: "complains",
                column: "IdDepartmentNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_complains_IdStudent",
                table: "complains",
                column: "IdStudent");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_idDepartment",
                table: "Employees",
                column: "idDepartment");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_IdDepartmentNavigationId",
                table: "Employees",
                column: "IdDepartmentNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_ImageComplain_IdComplain",
                table: "ImageComplain",
                column: "IdComplain");

            migrationBuilder.CreateIndex(
                name: "IX_Students_DepartmentId",
                table: "Students",
                column: "DepartmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppConfigs");

            migrationBuilder.DropTable(
                name: "AppRoles");

            migrationBuilder.DropTable(
                name: "AppUsers");

            migrationBuilder.DropTable(
                name: "ImageComplain");

            migrationBuilder.DropTable(
                name: "complains");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
