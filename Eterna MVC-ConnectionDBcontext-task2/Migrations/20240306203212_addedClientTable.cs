using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eterna_MVC_ConnectionDBcontext_task2.Migrations
{
    /// <inheritdoc />
    public partial class addedClientTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Image1 = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Image2 = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Image3 = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Image4 = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Image5 = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");
        }
    }
}
