using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EF_Tutorial.Migrations
{
    /// <inheritdoc />
    public partial class jsonDataSeeded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "date", "jsonId", "value1", "value2" },
                values: new object[] { "2022-03-01", 1, 101, 105 });

            migrationBuilder.InsertData(
                table: "JsonData",
                columns: new[] { "id", "date", "jsonId", "value1", "value2" },
                values: new object[,]
                {
                    { 2, "2022-03-02", 1, 110, 117 },
                    { 3, "2022-03-03", 1, 102, 120 },
                    { 4, "2022-03-04", 1, 105, 104 },
                    { 5, "2022-03-05", 1, 120, 102 },
                    { 6, "2022-03-06", 1, 117, 110 },
                    { 7, "2022-03-07", 1, 105, 101 },
                    { 8, "2022-03-01", 2, 148, 103 },
                    { 9, "2022-03-02", 2, 135, 136 },
                    { 10, "2022-03-03", 2, 136, 109 },
                    { 11, "2022-03-04", 2, 123, 109 },
                    { 12, "2022-03-05", 2, 150, 128 },
                    { 13, "2022-03-06", 2, 145, 110 },
                    { 14, "2022-03-07", 2, 109, 138 },
                    { 15, "2022-03-01", 3, 150, 104 },
                    { 16, "2022-03-02", 3, 126, 114 },
                    { 17, "2022-03-03", 3, 135, 109 },
                    { 18, "2022-03-04", 3, 101, 149 },
                    { 19, "2022-03-05", 3, 111, 123 },
                    { 20, "2022-03-06", 3, 145, 118 },
                    { 21, "2022-03-07", 3, 139, 145 },
                    { 22, "2022-03-01", 4, 120, 141 },
                    { 23, "2022-03-02", 4, 132, 109 },
                    { 24, "2022-03-03", 4, 142, 150 },
                    { 25, "2022-03-04", 4, 115, 110 },
                    { 26, "2022-03-05", 4, 148, 145 },
                    { 27, "2022-03-06", 4, 146, 132 },
                    { 28, "2022-03-07", 4, 125, 118 },
                    { 29, "2022-03-01", 5, 135, 128 },
                    { 30, "2022-03-02", 5, 130, 123 },
                    { 31, "2022-03-03", 5, 145, 128 },
                    { 32, "2022-03-04", 5, 141, 125 },
                    { 33, "2022-03-05", 5, 119, 109 },
                    { 34, "2022-03-06", 5, 126, 148 },
                    { 35, "2022-03-07", 5, 128, 105 },
                    { 36, "2022-03-01", 6, 132, 132 },
                    { 37, "2022-03-02", 6, 108, 148 },
                    { 38, "2022-03-03", 6, 127, 140 },
                    { 39, "2022-03-04", 6, 139, 135 },
                    { 40, "2022-03-05", 6, 101, 110 },
                    { 41, "2022-03-06", 6, 134, 121 },
                    { 42, "2022-03-07", 6, 115, 149 },
                    { 43, "2022-03-01", 7, 137, 147 },
                    { 44, "2022-03-02", 7, 124, 127 },
                    { 45, "2022-03-03", 7, 147, 130 },
                    { 46, "2022-03-04", 7, 124, 130 },
                    { 47, "2022-03-05", 7, 116, 110 },
                    { 48, "2022-03-06", 7, 127, 122 },
                    { 49, "2022-03-07", 7, 150, 104 },
                    { 50, "2022-03-01", 8, 120, 119 },
                    { 51, "2022-03-02", 8, 131, 122 },
                    { 52, "2022-03-03", 8, 139, 115 },
                    { 53, "2022-03-04", 8, 118, 150 },
                    { 54, "2022-03-05", 8, 129, 142 },
                    { 55, "2022-03-06", 8, 102, 104 },
                    { 56, "2022-03-07", 8, 150, 133 },
                    { 57, "2022-03-01", 9, 133, 110 },
                    { 58, "2022-03-02", 9, 128, 135 },
                    { 59, "2022-03-03", 9, 138, 122 },
                    { 60, "2022-03-04", 9, 114, 143 },
                    { 61, "2022-03-05", 9, 140, 119 },
                    { 62, "2022-03-06", 9, 147, 140 },
                    { 63, "2022-03-07", 9, 119, 103 },
                    { 64, "2022-03-01", 10, 105, 141 },
                    { 65, "2022-03-02", 10, 122, 134 },
                    { 66, "2022-03-03", 10, 110, 127 },
                    { 67, "2022-03-04", 10, 147, 116 },
                    { 68, "2022-03-05", 10, 104, 119 },
                    { 69, "2022-03-06", 10, 116, 130 },
                    { 70, "2022-03-07", 10, 117, 131 },
                    { 71, "2022-03-01", 11, 121, 125 },
                    { 72, "2022-03-02", 11, 135, 146 },
                    { 73, "2022-03-03", 11, 129, 132 },
                    { 74, "2022-03-04", 11, 133, 123 },
                    { 75, "2022-03-05", 11, 146, 131 },
                    { 76, "2022-03-06", 11, 146, 141 },
                    { 77, "2022-03-07", 11, 108, 116 },
                    { 78, "2022-03-01", 12, 113, 125 },
                    { 79, "2022-03-02", 12, 114, 130 },
                    { 80, "2022-03-03", 12, 124, 145 },
                    { 81, "2022-03-04", 12, 128, 112 },
                    { 82, "2022-03-05", 12, 128, 141 },
                    { 83, "2022-03-06", 12, 100, 108 },
                    { 84, "2022-03-07", 12, 120, 123 },
                    { 85, "2022-03-01", 13, 136, 124 },
                    { 86, "2022-03-02", 13, 145, 122 },
                    { 87, "2022-03-03", 13, 102, 106 },
                    { 88, "2022-03-04", 13, 127, 149 },
                    { 89, "2022-03-05", 13, 118, 113 },
                    { 90, "2022-03-06", 13, 140, 132 },
                    { 91, "2022-03-07", 13, 108, 110 },
                    { 92, "2022-03-01", 14, 115, 117 },
                    { 93, "2022-03-02", 14, 144, 112 },
                    { 94, "2022-03-03", 14, 129, 148 },
                    { 95, "2022-03-04", 14, 119, 121 },
                    { 96, "2022-03-05", 14, 118, 113 },
                    { 97, "2022-03-06", 14, 112, 120 },
                    { 98, "2022-03-07", 14, 150, 149 },
                    { 99, "2022-03-01", 15, 121, 126 },
                    { 100, "2022-03-02", 15, 107, 100 },
                    { 101, "2022-03-03", 15, 119, 119 },
                    { 102, "2022-03-04", 15, 128, 147 },
                    { 103, "2022-03-05", 15, 114, 137 },
                    { 104, "2022-03-06", 15, 133, 100 },
                    { 105, "2022-03-07", 15, 116, 141 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 105);

            migrationBuilder.UpdateData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "date", "jsonId", "value1", "value2" },
                values: new object[] { "2022-03-07", 15, 116, 141 });
        }
    }
}
