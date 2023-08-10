using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Tutorial.Migrations
{
    /// <inheritdoc />
    public partial class AddedJsonDataNew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "JsonData",
                columns: new[] { "id", "date", "jsonId", "value1", "value2" },
                values: new object[] { 1, "2022-03-07", 15, 116, 141 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "JsonData",
                keyColumn: "id",
                keyValue: 1);
        }
    }
}
