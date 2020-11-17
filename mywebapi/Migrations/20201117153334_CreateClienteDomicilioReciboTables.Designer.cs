﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using mywebapi.DbContexts;

namespace mywebapi.Migrations
{
    [DbContext(typeof(SqliteDbContext))]
    [Migration("20201117153334_CreateClienteDomicilioReciboTables")]
    partial class CreateClienteDomicilioReciboTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10");

            modelBuilder.Entity("mywebapi.Models.Cliente", b =>
                {
                    b.Property<int>("Cuenta")
                        // .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Apellidos")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaveDeLocalizacion")
                        .HasColumnType("TEXT");

                    b.Property<int>("DomicilioId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Giro")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombres")
                        .HasColumnType("TEXT");

                    b.Property<string>("NumeroDeContrato")
                        .HasColumnType("TEXT");

                    b.Property<string>("NumeroDeMedidor")
                        .HasColumnType("TEXT");

                    b.Property<string>("RazonSocial")
                        .HasColumnType("TEXT");

                    b.Property<string>("Rfc")
                        .HasColumnType("TEXT");

                    b.Property<string>("TipoDeContrato")
                        .HasColumnType("TEXT");

                    b.HasKey("Cuenta");

                    b.HasIndex("DomicilioId")
                        .IsUnique();

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("mywebapi.Models.Domicilio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CalleA")
                        .HasColumnType("TEXT");

                    b.Property<string>("CalleB")
                        .HasColumnType("TEXT");

                    b.Property<string>("CallePrincipal")
                        .HasColumnType("TEXT");

                    b.Property<int>("CodigoPostal")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Colonia")
                        .HasColumnType("TEXT");

                    b.Property<string>("Localidad")
                        .HasColumnType("TEXT");

                    b.Property<string>("Municipio")
                        .HasColumnType("TEXT");

                    b.Property<int>("NumeroExterior")
                        .HasColumnType("INTEGER");

                    b.Property<string>("NumeroInterior")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Domcilios");
                });

            modelBuilder.Entity("mywebapi.Models.Recibo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("AdeudoAnterior")
                        .HasColumnType("REAL");

                    b.Property<int>("Autorizacion")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Banco")
                        .HasColumnType("TEXT");

                    b.Property<double>("Bomberos")
                        .HasColumnType("REAL");

                    b.Property<int>("ClienteId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Consumo")
                        .HasColumnType("REAL");

                    b.Property<int>("ConsumoEnM3")
                        .HasColumnType("INTEGER");

                    b.Property<double>("CruzRoja")
                        .HasColumnType("REAL");

                    b.Property<double>("Drenaje")
                        .HasColumnType("REAL");

                    b.Property<bool>("EstaPagado")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("FechaDeLectura")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaDePago")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaDelUltimoPago")
                        .HasColumnType("TEXT");

                    b.Property<double>("Iva")
                        .HasColumnType("REAL");

                    b.Property<int>("LecturaActual")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LecturaAnterior")
                        .HasColumnType("INTEGER");

                    b.Property<double>("MontoDelUltimoPago")
                        .HasColumnType("REAL");

                    b.Property<double>("Multas")
                        .HasColumnType("REAL");

                    b.Property<string>("NumeroDeTarjeta")
                        .HasColumnType("TEXT");

                    b.Property<string>("Periodo")
                        .HasColumnType("TEXT");

                    b.Property<double>("Recargos")
                        .HasColumnType("REAL");

                    b.Property<double>("Saneamiento")
                        .HasColumnType("REAL");

                    b.Property<double>("SubTotal")
                        .HasColumnType("REAL");

                    b.Property<string>("TitularDeTarjeta")
                        .HasColumnType("TEXT");

                    b.Property<double>("Total")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("Recibos");
                });

            modelBuilder.Entity("mywebapi.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(200);

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<DateTime>("LastLogin")
                        .HasColumnType("TEXT");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(20);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(16);

                    b.Property<string>("RememberToken")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("mywebapi.Models.Cliente", b =>
                {
                    b.HasOne("mywebapi.Models.Domicilio", "Domicilio")
                        .WithOne("Cliente")
                        .HasForeignKey("mywebapi.Models.Cliente", "DomicilioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("mywebapi.Models.Recibo", b =>
                {
                    b.HasOne("mywebapi.Models.Cliente", "Cliente")
                        .WithMany("Recibos")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}