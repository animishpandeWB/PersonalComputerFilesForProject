using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Tutorial.Migrations
{
    /// <inheritdoc />
    public partial class JsonDataChanged : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "jsonId",
                table: "JsonData",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "jsonId",
                table: "JsonData");
        }
    }
}
