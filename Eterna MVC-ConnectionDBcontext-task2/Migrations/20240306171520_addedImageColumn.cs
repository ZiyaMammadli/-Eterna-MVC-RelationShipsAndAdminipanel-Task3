using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eterna_MVC_ConnectionDBcontext_task2.Migrations
{
    /// <inheritdoc />
    public partial class addedImageColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Desc",
                table: "Sliders",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(140)",
                oldMaxLength: 140);

            migrationBuilder.AddColumn<string>(
                name: "image",
                table: "Sliders",
                type: "nvarchar(140)",
                maxLength: 140,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "image",
                table: "Sliders");

            migrationBuilder.AlterColumn<string>(
                name: "Desc",
                table: "Sliders",
                type: "nvarchar(140)",
                maxLength: 140,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
