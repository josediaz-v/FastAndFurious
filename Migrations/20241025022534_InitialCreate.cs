using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FastAndFurious.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    vin = table.Column<string>(type: "TEXT", nullable: false),
                    plate = table.Column<string>(type: "TEXT", nullable: false),
                    make = table.Column<string>(type: "TEXT", nullable: false),
                    model = table.Column<string>(type: "TEXT", nullable: false),
                    @class = table.Column<string>(name: "class", type: "TEXT", nullable: true),
                    year = table.Column<int>(type: "INTEGER", nullable: true),
                    transmission = table.Column<string>(type: "TEXT", nullable: false),
                    drive = table.Column<string>(type: "TEXT", nullable: true),
                    cylinders = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.vin);
                });

            migrationBuilder.CreateTable(
                name: "Costumers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    Phone = table.Column<int>(type: "INTEGER", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Permission = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Costumers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    Phone = table.Column<int>(type: "INTEGER", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Costumers");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
