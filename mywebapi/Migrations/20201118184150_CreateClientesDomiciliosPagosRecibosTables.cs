using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace mywebapi.Migrations
{
    public partial class CreateClientesDomiciliosPagosRecibosTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Domcilios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                        // .Annotation("Sqlite:Autoincrement", true),
                    CallePrincipal = table.Column<string>(maxLength: 100, nullable: false),
                    CalleA = table.Column<string>(maxLength: 100, nullable: false),
                    CalleB = table.Column<string>(maxLength: 100, nullable: false),
                    NumeroExterior = table.Column<int>(nullable: false),
                    NumeroInterior = table.Column<string>(nullable: false),
                    CodigoPostal = table.Column<int>(nullable: false),
                    Colonia = table.Column<string>(maxLength: 100, nullable: false),
                    Localidad = table.Column<string>(maxLength: 100, nullable: false),
                    Municipio = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Domcilios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Cuenta = table.Column<int>(nullable: false),
                        // .Annotation("Sqlite:Autoincrement", true),
                    ClaveDeLocalizacion = table.Column<string>(nullable: false),
                    NumeroDeContrato = table.Column<string>(nullable: false),
                    NumeroDeMedidor = table.Column<string>(nullable: false),
                    Nombres = table.Column<string>(maxLength: 50, nullable: false),
                    Apellidos = table.Column<string>(maxLength: 50, nullable: false),
                    TipoDeContrato = table.Column<string>(maxLength: 30, nullable: false),
                    Giro = table.Column<string>(maxLength: 200, nullable: false),
                    RazonSocial = table.Column<string>(maxLength: 200, nullable: false),
                    Rfc = table.Column<string>(maxLength: 13, nullable: false),
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
                    Id = table.Column<int>(nullable: false),
                        // .Annotation("Sqlite:Autoincrement", true),
                    ClienteCuenta = table.Column<int>(nullable: false),
                    Periodo = table.Column<string>(maxLength: 30, nullable: false),
                    LecturaAnterior = table.Column<int>(nullable: false),
                    LecturaActual = table.Column<int>(nullable: false),
                    ConsumoEnM3 = table.Column<int>(nullable: false),
                    FechaDeLectura = table.Column<DateTime>(nullable: false),
                    FechaDelUltimoPago = table.Column<DateTime>(nullable: false),
                    MontoDelUltimoPago = table.Column<double>(nullable: false),
                    Agua = table.Column<double>(nullable: false),
                    Drenaje = table.Column<double>(nullable: false),
                    Saneamiento = table.Column<double>(nullable: false),
                    Bomberos = table.Column<double>(nullable: false),
                    CruzRoja = table.Column<double>(nullable: false),
                    AdeudoAnterior = table.Column<double>(nullable: false),
                    Multas = table.Column<double>(nullable: false),
                    Recargos = table.Column<double>(nullable: false),
                    Otros = table.Column<double>(nullable: false),
                    SubTotal = table.Column<double>(nullable: false),
                    Iva = table.Column<double>(nullable: false),
                    Total = table.Column<double>(nullable: false),
                    EstaPagado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recibos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recibos_Clientes_ClienteCuenta",
                        column: x => x.ClienteCuenta,
                        principalTable: "Clientes",
                        principalColumn: "Cuenta",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pagos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TitularDeTarjeta = table.Column<string>(nullable: false),
                    NumeroDeTarjeta = table.Column<string>(nullable: false),
                    Autorizacion = table.Column<int>(nullable: false),
                    FechaDePago = table.Column<DateTime>(nullable: false),
                    Banco = table.Column<string>(nullable: false),
                    ReciboId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pagos_Recibos_ReciboId",
                        column: x => x.ReciboId,
                        principalTable: "Recibos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_DomicilioId",
                table: "Clientes",
                column: "DomicilioId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_ReciboId",
                table: "Pagos",
                column: "ReciboId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Recibos_ClienteCuenta",
                table: "Recibos",
                column: "ClienteCuenta");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pagos");

            migrationBuilder.DropTable(
                name: "Recibos");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Domcilios");
        }
    }
}
