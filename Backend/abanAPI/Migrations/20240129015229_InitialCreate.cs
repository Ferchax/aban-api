using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace abanAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
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
                    Nombres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechadeNacimiento = table.Column<DateTime>(name: "Fecha de Nacimiento", type: "datetime2", nullable: true),
                    CUIT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Domicilio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Celular = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Apellidos", "Celular", "CUIT", "Domicilio", "Email", "Fecha de Nacimiento", "Nombres" },
                values: new object[,]
                {
                    { 1, "García Morales", "+54 9 11 1234-5678", "20-12345678-9", "Av. Rivadavia 1234", "sofia.garcia.morales@example.com", new DateTime(1990, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sofia" },
                    { 2, "López Martínez", "+54 9 11 2345-6789", "23-45678901-9", "Calle Independencia 789", "javier.lopez.martinez@example.com", null, "Javier" },
                    { 3, "Rodríguez Navarro", "+54 9 11 9876-5432", "27-87654321-1", "Calle San Martín 567", "valentina.rodriguez.navarro@example.com", new DateTime(1985, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Valentina" },
                    { 4, "González Sánchez", null, null, null, "mateo.gonzalez.sanchez@example.com", null, "Mateo" },
                    { 5, "Pérez Romero", "+54 9 11 8765-4321", "30-98765432-1", "Av. Belgrano 4321", "isabella.perez.romero@example.com", null, "Isabella" },
                    { 6, "Martín Herrera", null, null, null, "lucas.martin.herrera@example.com", new DateTime(2000, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lucas" },
                    { 7, "Fernández Torres", null, null, null, "camila.fernandez.torres@example.com", null, "Camila" },
                    { 8, "Ruiz Castro", "+54 9 11 3456-7890", "24-56789012-3", "Calle Sarmiento 321", "daniel.ruiz.castro@example.com", new DateTime(1995, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Daniel" },
                    { 9, "Díaz González", null, null, null, "valeria.diaz.gonzalez@example.com", null, "Valeria" },
                    { 10, "Gómez Ortega", null, null, null, "juanpablo.gomez.ortega@example.com", new DateTime(1978, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Juan Pablo" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
