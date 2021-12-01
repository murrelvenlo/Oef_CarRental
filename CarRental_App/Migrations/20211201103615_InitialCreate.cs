using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRental_App.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorie",
                columns: table => new
                {
                    CategorieID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Beschrijving = table.Column<string>(nullable: true),
                    AantalDeuren = table.Column<int>(nullable: false),
                    AantalZitplaatsen = table.Column<int>(nullable: false),
                    PrijsPerDag = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorie", x => x.CategorieID);
                });

            migrationBuilder.CreateTable(
                name: "Klant",
                columns: table => new
                {
                    KlantID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Voornaam = table.Column<string>(nullable: true),
                    Achternaam = table.Column<string>(nullable: true),
                    Geboortedatum = table.Column<DateTime>(nullable: false),
                    Nationaliteit = table.Column<string>(nullable: true),
                    Telefoonnummer = table.Column<string>(nullable: true),
                    Emailadres = table.Column<string>(nullable: true),
                    Gemeente = table.Column<string>(nullable: true),
                    Postcode = table.Column<string>(nullable: true),
                    Straat = table.Column<string>(nullable: true),
                    Huisnummer = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Klant", x => x.KlantID);
                });

            migrationBuilder.CreateTable(
                name: "Merk",
                columns: table => new
                {
                    MerkID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MerkNaam = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Merk", x => x.MerkID);
                });

            migrationBuilder.CreateTable(
                name: "Reservatie",
                columns: table => new
                {
                    ReservatieID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KlantID = table.Column<int>(nullable: false),
                    Ophaaldatum = table.Column<DateTime>(nullable: false),
                    Afleverdatum = table.Column<DateTime>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    Betaalmethode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservatie", x => x.ReservatieID);
                    table.ForeignKey(
                        name: "FK_Reservatie_Klant_KlantID",
                        column: x => x.KlantID,
                        principalTable: "Klant",
                        principalColumn: "KlantID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Automodel",
                columns: table => new
                {
                    AutomodelID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(nullable: true),
                    MerkID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Automodel", x => x.AutomodelID);
                    table.ForeignKey(
                        name: "FK_Automodel_Merk_MerkID",
                        column: x => x.MerkID,
                        principalTable: "Merk",
                        principalColumn: "MerkID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReservatieCategorieën",
                columns: table => new
                {
                    ReservatieCategorieID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReservatieID = table.Column<int>(nullable: false),
                    CategorieID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservatieCategorieën", x => x.ReservatieCategorieID);
                    table.ForeignKey(
                        name: "FK_ReservatieCategorieën_Categorie_CategorieID",
                        column: x => x.CategorieID,
                        principalTable: "Categorie",
                        principalColumn: "CategorieID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReservatieCategorieën_Reservatie_ReservatieID",
                        column: x => x.ReservatieID,
                        principalTable: "Reservatie",
                        principalColumn: "ReservatieID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Auto",
                columns: table => new
                {
                    AutoID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AutomodelID = table.Column<int>(nullable: false),
                    CategorieID = table.Column<int>(nullable: false),
                    Nummerplaat = table.Column<string>(nullable: true),
                    Kleur = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auto", x => x.AutoID);
                    table.ForeignKey(
                        name: "FK_Auto_Automodel_AutomodelID",
                        column: x => x.AutomodelID,
                        principalTable: "Automodel",
                        principalColumn: "AutomodelID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Auto_Categorie_CategorieID",
                        column: x => x.CategorieID,
                        principalTable: "Categorie",
                        principalColumn: "CategorieID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Auto_AutomodelID",
                table: "Auto",
                column: "AutomodelID");

            migrationBuilder.CreateIndex(
                name: "IX_Auto_CategorieID",
                table: "Auto",
                column: "CategorieID");

            migrationBuilder.CreateIndex(
                name: "IX_Automodel_MerkID",
                table: "Automodel",
                column: "MerkID");

            migrationBuilder.CreateIndex(
                name: "IX_Reservatie_KlantID",
                table: "Reservatie",
                column: "KlantID");

            migrationBuilder.CreateIndex(
                name: "IX_ReservatieCategorieën_CategorieID",
                table: "ReservatieCategorieën",
                column: "CategorieID");

            migrationBuilder.CreateIndex(
                name: "IX_ReservatieCategorieën_ReservatieID",
                table: "ReservatieCategorieën",
                column: "ReservatieID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Auto");

            migrationBuilder.DropTable(
                name: "ReservatieCategorieën");

            migrationBuilder.DropTable(
                name: "Automodel");

            migrationBuilder.DropTable(
                name: "Categorie");

            migrationBuilder.DropTable(
                name: "Reservatie");

            migrationBuilder.DropTable(
                name: "Merk");

            migrationBuilder.DropTable(
                name: "Klant");
        }
    }
}
