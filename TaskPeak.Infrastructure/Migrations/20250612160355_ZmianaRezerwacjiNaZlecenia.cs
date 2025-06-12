using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskPeak.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ZmianaRezerwacjiNaZlecenia : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Zadania_Rezerwacje_IdRezerwacji",
                table: "Zadania");

            migrationBuilder.DropTable(
                name: "Rezerwacje");

            migrationBuilder.CreateTable(
                name: "Zlecenia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataZlecenia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    IdUslugi = table.Column<int>(type: "int", nullable: false),
                    IdKlienta = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zlecenia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Zlecenia_Klienci_IdKlienta",
                        column: x => x.IdKlienta,
                        principalTable: "Klienci",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Zlecenia_Uslugi_IdUslugi",
                        column: x => x.IdUslugi,
                        principalTable: "Uslugi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Zlecenia_IdKlienta",
                table: "Zlecenia",
                column: "IdKlienta");

            migrationBuilder.CreateIndex(
                name: "IX_Zlecenia_IdUslugi",
                table: "Zlecenia",
                column: "IdUslugi");

            migrationBuilder.AddForeignKey(
                name: "FK_Zadania_Zlecenia_IdRezerwacji",
                table: "Zadania",
                column: "IdRezerwacji",
                principalTable: "Zlecenia",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Zadania_Zlecenia_IdRezerwacji",
                table: "Zadania");

            migrationBuilder.DropTable(
                name: "Zlecenia");

            migrationBuilder.CreateTable(
                name: "Rezerwacje",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdKlienta = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    IdUslugi = table.Column<int>(type: "int", nullable: false),
                    DataRezerwacji = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rezerwacje", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rezerwacje_Klienci_IdKlienta",
                        column: x => x.IdKlienta,
                        principalTable: "Klienci",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rezerwacje_Uslugi_IdUslugi",
                        column: x => x.IdUslugi,
                        principalTable: "Uslugi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Rezerwacje_IdKlienta",
                table: "Rezerwacje",
                column: "IdKlienta");

            migrationBuilder.CreateIndex(
                name: "IX_Rezerwacje_IdUslugi",
                table: "Rezerwacje",
                column: "IdUslugi");

            migrationBuilder.AddForeignKey(
                name: "FK_Zadania_Rezerwacje_IdRezerwacji",
                table: "Zadania",
                column: "IdRezerwacji",
                principalTable: "Rezerwacje",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
