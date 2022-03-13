using Microsoft.EntityFrameworkCore.Migrations;

namespace DUE_Complains.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "reply",
                table: "complains",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "AppConfigs",
                columns: new[] { "Key", "Value" },
                values: new object[,]
                {
                    { "HomeTitle", "This is homepage of Solution" },
                    { "HomeKeyword", "This is keyword of Solution" }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "name", "phone", "totalemployee", "totalstudent" },
                values: new object[,]
                {
                    { 1, "Kế toán", null, null, null },
                    { 2, "Quản trị kinh doanh", null, null, null },
                    { 3, "Marketing", null, null, null },
                    { 4, "Du lịch", null, null, null },
                    { 5, "Kinh doanh quốc tế", null, null, null },
                    { 6, "Ngân hàng", null, null, null },
                    { 7, "Tài chính", null, null, null },
                    { 8, "Thống kê - Tin học", null, null, null },
                    { 9, "Thương mại điện tử", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "id", "idDepartment", "IdDepartmentNavigationId", "name", "position" },
                values: new object[,]
                {
                    { 1, 1, null, "Lê Dân", null },
                    { 8, 8, null, "Nguyễn Bá Thế", null },
                    { 7, 7, null, "Phan Thị Bích Vân", null },
                    { 6, 6, null, "Văn Ngọc Đàn", null },
                    { 9, 9, null, "Nguyễn Thành Thủy", null },
                    { 4, 4, null, "Võ Quang Trí", null },
                    { 5, 5, null, "Ngô Thị Khuê Thư", null },
                    { 3, 3, null, "Cao Thị Nhâm", null },
                    { 2, 2, null, "Hoàng Thị Thanh Hà", null }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "studentcode", "DepartmentId", "email", "name", "phone", "sclass" },
                values: new object[,]
                {
                    { "181121521136", 4, null, "Nguyễn Quang Thành", null, null },
                    { "181121521138", 5, null, "Nguyễn Duy Thông", null, null },
                    { "171121521050", 2, null, "Lê Linh Phương", null, null },
                    { "191123659113", 6, null, "Nguyễn Minh", null, null },
                    { "201154896335", 7, null, "Lê Hà Phước", null, null },
                    { "181121521137", 1, null, "Nguyễn Quốc Thiện", null, null },
                    { "201159871175", 8, null, "Nguyễn Thành Đô", null, null },
                    { "191154833658", 3, null, "Trần Đức Duy Anh", null, null },
                    { "171122225114", 9, null, "Hồ Tiểu Băng", null, null }
                });

            migrationBuilder.InsertData(
                table: "complains",
                columns: new[] { "IdComplain", "Content", "IdDepartment", "IdDepartmentNavigationId", "IdStudent", "reply", "Title" },
                values: new object[,]
                {
                    { 1, "Cơ sở vật chất nhà đa chức năng xuống cấp, không đảm bảo độ an toàn cho sinh viên khi sử dụng để phục vụ việc học", 1, null, "181121521137", null, "Phàn nàn" },
                    { 2, "Cơ sở vật chất nhà đa chức năng xuống cấp, không đảm bảo độ an toàn cho sinh viên khi sử dụng để phục vụ việc học", 2, null, "171121521050", null, "Phàn nàn" },
                    { 3, "Cơ sở vật chất nhà đa chức năng xuống cấp, không đảm bảo độ an toàn cho sinh viên khi sử dụng để phục vụ việc học", 3, null, "191154833658", null, "Phàn nàn" },
                    { 4, "Cơ sở vật chất nhà đa chức năng xuống cấp, không đảm bảo độ an toàn cho sinh viên khi sử dụng để phục vụ việc học", 4, null, "181121521136", null, "Phàn nàn" },
                    { 5, "Cơ sở vật chất nhà đa chức năng xuống cấp, không đảm bảo độ an toàn cho sinh viên khi sử dụng để phục vụ việc học", 5, null, "181121521138", null, "Phàn nàn" },
                    { 6, "Cơ sở vật chất nhà đa chức năng xuống cấp, không đảm bảo độ an toàn cho sinh viên khi sử dụng để phục vụ việc học", 6, null, "191123659113", null, "Phàn nàn" },
                    { 7, "Cơ sở vật chất nhà đa chức năng xuống cấp, không đảm bảo độ an toàn cho sinh viên khi sử dụng để phục vụ việc học", 7, null, "201154896335", null, "Phàn nàn" },
                    { 8, "Cơ sở vật chất nhà đa chức năng xuống cấp, không đảm bảo độ an toàn cho sinh viên khi sử dụng để phục vụ việc học", 8, null, "201159871175", null, "Phàn nàn" },
                    { 9, "Cơ sở vật chất nhà đa chức năng xuống cấp, không đảm bảo độ an toàn cho sinh viên khi sử dụng để phục vụ việc học", 9, null, "171122225114", null, "Phàn nàn" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppConfigs",
                keyColumn: "Key",
                keyValue: "HomeKeyword");

            migrationBuilder.DeleteData(
                table: "AppConfigs",
                keyColumn: "Key",
                keyValue: "HomeTitle");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "complains",
                keyColumn: "IdComplain",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "complains",
                keyColumn: "IdComplain",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "complains",
                keyColumn: "IdComplain",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "complains",
                keyColumn: "IdComplain",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "complains",
                keyColumn: "IdComplain",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "complains",
                keyColumn: "IdComplain",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "complains",
                keyColumn: "IdComplain",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "complains",
                keyColumn: "IdComplain",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "complains",
                keyColumn: "IdComplain",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "studentcode",
                keyValue: "171121521050");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "studentcode",
                keyValue: "171122225114");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "studentcode",
                keyValue: "181121521136");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "studentcode",
                keyValue: "181121521137");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "studentcode",
                keyValue: "181121521138");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "studentcode",
                keyValue: "191123659113");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "studentcode",
                keyValue: "191154833658");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "studentcode",
                keyValue: "201154896335");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "studentcode",
                keyValue: "201159871175");

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.AlterColumn<string>(
                name: "reply",
                table: "complains",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
