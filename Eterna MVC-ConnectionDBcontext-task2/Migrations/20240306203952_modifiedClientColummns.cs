using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eterna_MVC_ConnectionDBcontext_task2.Migrations
{
    /// <inheritdoc />
    public partial class modifiedClientColummns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image1",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "Image2",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "Image3",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "Image4",
                table: "Clients");

            migrationBuilder.RenameColumn(
                name: "Image5",
                table: "Clients",
                newName: "Image");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Clients",
                newName: "Image5");

            migrationBuilder.AddColumn<string>(
                name: "Image1",
                table: "Clients",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Image2",
                table: "Clients",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Image3",
                table: "Clients",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Image4",
                table: "Clients",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "");
        }
    }
}
