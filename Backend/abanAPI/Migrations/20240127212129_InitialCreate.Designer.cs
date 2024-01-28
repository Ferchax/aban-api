﻿// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace abanAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240127212129_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("abanAPI.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cuit")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CUIT");

                    b.Property<string>("Domicilio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaDeNacimiento")
                        .HasColumnType("datetime2")
                        .HasColumnName("Fecha de Nacimiento");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Apellidos = "García Morales",
                            Celular = "+54 9 11 1234-5678",
                            Cuit = "20-12345678-9",
                            Domicilio = "Av. Rivadavia 1234",
                            Email = "sofia.garcia.morales@example.com",
                            FechaDeNacimiento = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombres = "Sofia"
                        },
                        new
                        {
                            Id = 2,
                            Apellidos = "López Martínez",
                            Celular = "+54 9 11 2345-6789",
                            Cuit = "23-45678901-9",
                            Domicilio = "Calle Independencia 789",
                            Email = "javier.lopez.martinez@example.com",
                            FechaDeNacimiento = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombres = "Javier"
                        },
                        new
                        {
                            Id = 3,
                            Apellidos = "Rodríguez Navarro",
                            Celular = "+54 9 11 9876-5432",
                            Cuit = "27-87654321-1",
                            Domicilio = "Calle San Martín 567",
                            Email = "valentina.rodriguez.navarro@example.com",
                            FechaDeNacimiento = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombres = "Valentina"
                        },
                        new
                        {
                            Id = 4,
                            Apellidos = "González Sánchez",
                            Celular = "",
                            Cuit = "",
                            Domicilio = "",
                            Email = "mateo.gonzalez.sanchez@example.com",
                            FechaDeNacimiento = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombres = "Mateo"
                        },
                        new
                        {
                            Id = 5,
                            Apellidos = "Pérez Romero",
                            Celular = "+54 9 11 8765-4321",
                            Cuit = "30-98765432-1",
                            Domicilio = "Av. Belgrano 4321",
                            Email = "isabella.perez.romero@example.com",
                            FechaDeNacimiento = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombres = "Isabella"
                        },
                        new
                        {
                            Id = 6,
                            Apellidos = "Martín Herrera",
                            Celular = "",
                            Cuit = "",
                            Domicilio = "",
                            Email = "lucas.martin.herrera@example.com",
                            FechaDeNacimiento = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombres = "Lucas"
                        },
                        new
                        {
                            Id = 7,
                            Apellidos = "Fernández Torres",
                            Celular = "",
                            Cuit = "",
                            Domicilio = "",
                            Email = "camila.fernandez.torres@example.com",
                            FechaDeNacimiento = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombres = "Camila"
                        },
                        new
                        {
                            Id = 8,
                            Apellidos = "Ruiz Castro",
                            Celular = "+54 9 11 3456-7890",
                            Cuit = "24-56789012-3",
                            Domicilio = "Calle Sarmiento 321",
                            Email = "daniel.ruiz.castro@example.com",
                            FechaDeNacimiento = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombres = "Daniel"
                        },
                        new
                        {
                            Id = 9,
                            Apellidos = "Díaz González",
                            Celular = "",
                            Cuit = "",
                            Domicilio = "",
                            Email = "valeria.diaz.gonzalez@example.com",
                            FechaDeNacimiento = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombres = "Valeria"
                        },
                        new
                        {
                            Id = 10,
                            Apellidos = "Gómez Ortega",
                            Celular = "",
                            Cuit = "",
                            Domicilio = "",
                            Email = "juanpablo.gomez.ortega@example.com",
                            FechaDeNacimiento = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombres = "Juan Pablo"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
