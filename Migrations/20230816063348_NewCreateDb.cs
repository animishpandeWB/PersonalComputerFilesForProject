using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EF_Tutorial.Migrations
{
    /// <inheritdoc />
    public partial class NewCreateDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JsonData",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    jsonId = table.Column<int>(type: "int", nullable: false),
                    date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    value1 = table.Column<int>(type: "int", nullable: false),
                    value2 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JsonData", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pumps",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PumpId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pumps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pumps_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "JsonData",
                columns: new[] { "id", "date", "jsonId", "value1", "value2" },
                values: new object[,]
                {
                    { 1, "2022-03-01", 1, 101, 105 },
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

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Password", "UserId", "Username" },
                values: new object[] { 1, "test1@123.com", "test1", 1, "test1" });

            migrationBuilder.InsertData(
                table: "Pumps",
                columns: new[] { "Id", "Name", "PumpId", "Status", "Type", "UserId" },
                values: new object[,]
                {
                    { 1, "Pump 1", 1, true, "Centrifugal Pump", 1 },
                    { 2, "Pump 2", 2, false, "Jet Pump", 1 },
                    { 3, "Pump 3", 3, false, "Piston Pump", 1 },
                    { 4, "Pump 4", 4, false, "Centrifugal Pump", 1 },
                    { 5, "Pump 5", 5, true, "Jet Pump", 1 },
                    { 6, "Pump 6", 6, true, "Jet Pump", 1 },
                    { 7, "Pump 7", 7, false, "Piston Pump", 1 },
                    { 8, "Pump 8", 8, true, "Piston Pump", 1 },
                    { 9, "Pump 9", 9, false, "Centrifugal Pump", 1 },
                    { 10, "Pump 10", 10, true, "Jet Pump", 1 },
                    { 11, "Pump 11", 11, false, "Jet Pump", 1 },
                    { 12, "Pump 12", 12, true, "Centrifugal Pump", 1 },
                    { 13, "Pump 13", 13, true, "Piston Pump", 1 },
                    { 14, "Pump 14", 14, false, "Piston Pump", 1 },
                    { 15, "Pump 15", 15, true, "Centrifugal Pump", 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pumps_UserId",
                table: "Pumps",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JsonData");

            migrationBuilder.DropTable(
                name: "Pumps");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
