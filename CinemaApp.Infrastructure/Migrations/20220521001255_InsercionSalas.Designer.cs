﻿// <auto-generated />
using System;
using CinemaApp.Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CinemaApp.Infrastructure.Migrations
{
    [DbContext(typeof(CinemaContext))]
    [Migration("20220521001255_InsercionSalas")]
    partial class InsercionSalas
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CinemaApp.Domain.Entities.Cliente", b =>
                {
                    b.Property<string>("IdCliente")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("IdCliente");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("CinemaApp.Domain.Entities.DetalleFactura", b =>
                {
                    b.Property<int>("IdDetalleFactura")
                        .HasColumnType("int");

                    b.Property<DateTime?>("FechaUso")
                        .HasColumnType("datetime");

                    b.Property<int>("IdFactura")
                        .HasColumnType("int");

                    b.Property<Guid>("IdentificadorBoleta")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Redimida")
                        .HasColumnType("bit");

                    b.HasKey("IdDetalleFactura");

                    b.HasIndex("IdFactura");

                    b.ToTable("DetalleFactura");
                });

            modelBuilder.Entity("CinemaApp.Domain.Entities.Factura", b =>
                {
                    b.Property<int>("IdFactura")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime");

                    b.Property<string>("IdCliente")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<int>("IdFuncion")
                        .HasColumnType("int");

                    b.Property<decimal>("ValorBruto")
                        .HasColumnType("decimal(18, 0)");

                    b.Property<decimal>("ValorIva")
                        .HasColumnType("decimal(18, 0)");

                    b.Property<decimal>("ValorNeto")
                        .HasColumnType("decimal(18, 0)");

                    b.Property<decimal>("ValorServicio")
                        .HasColumnType("decimal(18, 0)");

                    b.HasKey("IdFactura");

                    b.HasIndex("IdCliente");

                    b.HasIndex("IdFuncion");

                    b.ToTable("Factura");
                });

            modelBuilder.Entity("CinemaApp.Domain.Entities.Funcion", b =>
                {
                    b.Property<int>("IdFuncion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AsientosDisponibles")
                        .HasColumnType("int");

                    b.Property<int>("CapacidadMaxima")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("date");

                    b.Property<TimeSpan>("HoraFin")
                        .HasColumnType("time");

                    b.Property<TimeSpan>("HoraInicio")
                        .HasColumnType("time");

                    b.Property<int>("IdPelicula")
                        .HasColumnType("int");

                    b.Property<int>("IdSala")
                        .HasColumnType("int");

                    b.Property<decimal>("PrecioBoleta")
                        .HasColumnType("decimal(18, 0)");

                    b.HasKey("IdFuncion");

                    b.HasIndex("IdPelicula");

                    b.HasIndex("IdSala");

                    b.ToTable("Funcion");
                });

            modelBuilder.Entity("CinemaApp.Domain.Entities.Pelicula", b =>
                {
                    b.Property<int>("IdPelicula")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ActorPrincipal")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<bool>("Disponible")
                        .HasColumnType("bit");

                    b.Property<int>("Duracion")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("Sinopsis")
                        .IsRequired()
                        .HasColumnType("varchar(500)")
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.HasKey("IdPelicula");

                    b.ToTable("Pelicula");
                });

            modelBuilder.Entity("CinemaApp.Domain.Entities.Sala", b =>
                {
                    b.Property<int>("IdSala")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Activa")
                        .HasColumnType("bit");

                    b.Property<int>("Capacidad")
                        .HasColumnType("int");

                    b.Property<bool>("EsDinamix")
                        .HasColumnType("bit");

                    b.Property<string>("Nomenclatura")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("IdSala");

                    b.ToTable("Sala");

                    b.HasData(
                        new
                        {
                            IdSala = 1,
                            Activa = true,
                            Capacidad = 20,
                            EsDinamix = false,
                            Nomenclatura = "S1"
                        },
                        new
                        {
                            IdSala = 2,
                            Activa = true,
                            Capacidad = 30,
                            EsDinamix = true,
                            Nomenclatura = "S2"
                        },
                        new
                        {
                            IdSala = 3,
                            Activa = false,
                            Capacidad = 50,
                            EsDinamix = false,
                            Nomenclatura = "S3"
                        },
                        new
                        {
                            IdSala = 4,
                            Activa = true,
                            Capacidad = 40,
                            EsDinamix = true,
                            Nomenclatura = "S4"
                        });
                });

            modelBuilder.Entity("CinemaApp.Domain.Entities.DetalleFactura", b =>
                {
                    b.HasOne("CinemaApp.Domain.Entities.Factura", "IdFacturaNavigation")
                        .WithMany("DetalleFactura")
                        .HasForeignKey("IdFactura")
                        .HasConstraintName("FK_DetalleFactura_Factura")
                        .IsRequired();
                });

            modelBuilder.Entity("CinemaApp.Domain.Entities.Factura", b =>
                {
                    b.HasOne("CinemaApp.Domain.Entities.Cliente", "IdClienteNavigation")
                        .WithMany("Factura")
                        .HasForeignKey("IdCliente")
                        .HasConstraintName("FK_Factura_Cliente");

                    b.HasOne("CinemaApp.Domain.Entities.Funcion", "IdFuncionNavigation")
                        .WithMany("Factura")
                        .HasForeignKey("IdFuncion")
                        .HasConstraintName("FK_Factura_Funcion")
                        .IsRequired();
                });

            modelBuilder.Entity("CinemaApp.Domain.Entities.Funcion", b =>
                {
                    b.HasOne("CinemaApp.Domain.Entities.Pelicula", "IdPeliculaNavigation")
                        .WithMany("Funcion")
                        .HasForeignKey("IdPelicula")
                        .HasConstraintName("FK_Funcion_Pelicula")
                        .IsRequired();

                    b.HasOne("CinemaApp.Domain.Entities.Sala", "IdSalaNavigation")
                        .WithMany("Funcion")
                        .HasForeignKey("IdSala")
                        .HasConstraintName("FK_Funcion_Sala")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
