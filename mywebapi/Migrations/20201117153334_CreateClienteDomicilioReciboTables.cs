using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace mywebapi.Migrations
{
    public partial class CreateClienteDomicilioReciboTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Domcilios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CallePrincipal = table.Column<string>(nullable: true),
                    CalleA = table.Column<string>(nullable: true),
                    CalleB = table.Column<string>(nullable: true),
                    NumeroExterior = table.Column<int>(nullable: false),
                    NumeroInterior = table.Column<string>(nullable: true),
                    CodigoPostal = table.Column<int>(nullable: false),
                    Colonia = table.Column<string>(nullable: true),
                    Localidad = table.Column<string>(nullable: true),
                    Municipio = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Domcilios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Cuenta = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", false),
                    ClaveDeLocalizacion = table.Column<string>(nullable: true),
                    NumeroDeContrato = table.Column<string>(nullable: true),
                    NumeroDeMedidor = table.Column<string>(nullable: true),
                    Nombres = table.Column<string>(nullable: true),
                    Apellidos = table.Column<string>(nullable: true),
                    TipoDeContrato = table.Column<string>(nullable: true),
                    Giro = table.Column<string>(nullable: true),
                    RazonSocial = table.Column<string>(nullable: true),
                    Rfc = table.Column<string>(nullable: true),
                    DomicilioId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Cuenta);
                    table.ForeignKey(
                        name: "FK_Clientes_Domcilios_DomicilioId",
                        column: x => x.DomicilioId,
                        principalTable: "Domcilios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Recibos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ClienteId = table.Column<int>(nullable: false),
                    Periodo = table.Column<string>(nullable: true),
                    LecturaAnterior = table.Column<int>(nullable: false),
                    LecturaActual = table.Column<int>(nullable: false),
                    ConsumoEnM3 = table.Column<int>(nullable: false),
                    FechaDeLectura = table.Column<DateTime>(nullable: false),
                    FechaDelUltimoPago = table.Column<DateTime>(nullable: false),
                    MontoDelUltimoPago = table.Column<double>(nullable: false),
                    Consumo = table.Column<double>(nullable: false),
                    Drenaje = table.Column<double>(nullable: false),
                    Saneamiento = table.Column<double>(nullable: false),
                    Bomberos = table.Column<double>(nullable: false),
                    CruzRoja = table.Column<double>(nullable: false),
                    AdeudoAnterior = table.Column<double>(nullable: false),
                    Multas = table.Column<double>(nullable: false),
                    Recargos = table.Column<double>(nullable: false),
                    SubTotal = table.Column<double>(nullable: false),
                    Iva = table.Column<double>(nullable: false),
                    Total = table.Column<double>(nullable: false),
                    TitularDeTarjeta = table.Column<string>(nullable: true),
                    NumeroDeTarjeta = table.Column<string>(nullable: true),
                    Autorizacion = table.Column<int>(nullable: false),
                    FechaDePago = table.Column<DateTime>(nullable: false),
                    Banco = table.Column<string>(nullable: true),
                    EstaPagado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recibos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recibos_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Cuenta",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_DomicilioId",
                table: "Clientes",
                column: "DomicilioId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Recibos_ClienteId",
                table: "Recibos",
                column: "ClienteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Recibos");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Domcilios");
        }
    }
}
