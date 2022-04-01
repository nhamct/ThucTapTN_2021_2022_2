using Microsoft.EntityFrameworkCore.Migrations;

namespace DUE_Complains.Migrations
{
    public partial class updatedataseeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Employees",
                type: "varchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "id",
                keyValue: 1,
                column: "Email",
                value: "danle@due.edu.vn");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "id",
                keyValue: 2,
                column: "Email",
                value: "ha.htt@due.edu.vn");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "id",
                keyValue: 3,
                column: "Email",
                value: "nhamct@due.edu.vn");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "id",
                keyValue: 4,
                column: "Email",
                value: "khuethu@due.edu.vn");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "id",
                keyValue: 5,
                column: "Email",
                value: "voquangtri@due.edu.vn");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "id",
                keyValue: 6,
                column: "Email",
                value: "danvn@due.edu.vn");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "id",
                keyValue: 7,
                column: "Email",
                value: "van.ptb@due.edu.vn");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "id",
                keyValue: 8,
                column: "Email",
                value: "thenb@due.edu.vn");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "id",
                keyValue: 9,
                column: "Email",
                value: "thuynt@due.edu.vn");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "studentcode",
                keyValue: "171121521050",
                column: "email",
                value: "171121521050@due.udn.vn");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "studentcode",
                keyValue: "171122225114",
                column: "email",
                value: "171122225114@due.udn.vn");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "studentcode",
                keyValue: "181121521136",
                column: "email",
                value: "181121521136@due.udn.vn");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "studentcode",
                keyValue: "181121521137",
                column: "email",
                value: "181121521137@due.udn.vn");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "studentcode",
                keyValue: "181121521138",
                column: "email",
                value: "181121521138@due.udn.vn");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "studentcode",
                keyValue: "191123659113",
                column: "email",
                value: "191123659113@due.udn.vn");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "studentcode",
                keyValue: "191154833658",
                column: "email",
                value: "191154833658@due.udn.vn");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "studentcode",
                keyValue: "201154896335",
                column: "email",
                value: "201154896335@due.udn.vn");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "studentcode",
                keyValue: "201159871175",
                column: "email",
                value: "201159871175@due.udn.vn");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Employees");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "studentcode",
                keyValue: "171121521050",
                column: "email",
                value: null);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "studentcode",
                keyValue: "171122225114",
                column: "email",
                value: null);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "studentcode",
                keyValue: "181121521136",
                column: "email",
                value: null);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "studentcode",
                keyValue: "181121521137",
                column: "email",
                value: null);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "studentcode",
                keyValue: "181121521138",
                column: "email",
                value: null);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "studentcode",
                keyValue: "191123659113",
                column: "email",
                value: null);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "studentcode",
                keyValue: "191154833658",
                column: "email",
                value: null);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "studentcode",
                keyValue: "201154896335",
                column: "email",
                value: null);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "studentcode",
                keyValue: "201159871175",
                column: "email",
                value: null);
        }
    }
}
