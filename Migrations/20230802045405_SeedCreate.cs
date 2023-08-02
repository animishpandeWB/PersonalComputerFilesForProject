using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EF_Tutorial.Migrations
{
    /// <inheritdoc />
    public partial class SeedCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                table: "Users",
                columns: new[] { "Id", "Email", "Password", "Username" },
                values: new object[] { 1, "test1@123.com", "test1", "test1" });

            migrationBuilder.InsertData(
                table: "Pumps",
                columns: new[] { "Id", "Name", "Status", "Type", "UserId" },
                values: new object[,]
                {
                    { 1, "Pump 1", true, "Centrifugal Pump", 1 },
                    { 2, "Pump 2", false, "Jet Pump", 1 },
                    { 3, "Pump 3", false, "Piston Pump", 1 },
                    { 4, "Pump 4", false, "Centrifugal Pump", 1 },
                    { 5, "Pump 5", true, "Jet Pump", 1 },
                    { 6, "Pump 6", true, "Jet Pump", 1 },
                    { 7, "Pump 7", false, "Piston Pump", 1 },
                    { 8, "Pump 8", true, "Piston Pump", 1 },
                    { 9, "Pump 9", false, "Centrifugal Pump", 1 },
                    { 10, "Pump 10", true, "Jet Pump", 1 },
                    { 11, "Pump 11", false, "Jet Pump", 1 },
                    { 12, "Pump 12", true, "Centrifugal Pump", 1 },
                    { 13, "Pump 13", true, "Piston Pump", 1 },
                    { 14, "Pump 14", false, "Piston Pump", 1 },
                    { 15, "Pump 15", true, "Centrifugal Pump", 1 }
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
                name: "Pumps");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
