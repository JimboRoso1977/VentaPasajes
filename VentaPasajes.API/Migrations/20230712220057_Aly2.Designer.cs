﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VentaPasajes.API.Data;

#nullable disable

namespace VentaPasajes.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230712220057_Aly2")]
    partial class Aly2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("VentaPasajes.Shared.Entities.Cliente", b =>
                {
                    b.Property<int>("Id_Cliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Cliente"));

                    b.Property<string>("Celular")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre_Cliente")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.HasKey("Id_Cliente");

                    b.HasIndex("Nombre_Cliente")
                        .IsUnique();

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("VentaPasajes.Shared.Entities.Cooperativa", b =>
                {
                    b.Property<int>("Id_Cooperativa")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Cooperativa"));

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha_Registro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nit")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_Cooperativa");

                    b.ToTable("Cooperativas");
                });

            modelBuilder.Entity("VentaPasajes.Shared.Entities.Detalle_Encomienda", b =>
                {
                    b.Property<int>("ID_Detalle_Encomienda")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID_Detalle_Encomienda"));

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<string>("Detalle")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<int>("ID_Encomienda")
                        .HasColumnType("int");

                    b.Property<float>("Monto")
                        .HasColumnType("real");

                    b.HasKey("ID_Detalle_Encomienda");

                    b.HasIndex("ID_Encomienda");

                    b.ToTable("Detalle_Encomienda");
                });

            modelBuilder.Entity("VentaPasajes.Shared.Entities.Detalle_Pasaje", b =>
                {
                    b.Property<int>("Id_Detalle")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Detalle"));

                    b.Property<string>("Destino")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha_Hora")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id_Cliente")
                        .HasColumnType("int");

                    b.Property<int>("Id_Pasaje")
                        .HasColumnType("int");

                    b.Property<string>("Origen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Precio")
                        .HasColumnType("real");

                    b.HasKey("Id_Detalle");

                    b.HasIndex("Id_Cliente");

                    b.HasIndex("Id_Pasaje");

                    b.ToTable("Detalle_Pasaje");
                });

            modelBuilder.Entity("VentaPasajes.Shared.Entities.Encomienda", b =>
                {
                    b.Property<int>("Id_Encomienda")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Encomienda"));

                    b.Property<string>("Aclaracion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ClienteId_Cliente")
                        .HasColumnType("int");

                    b.Property<string>("Destino")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha_Registro")
                        .HasColumnType("datetime2");

                    b.Property<int>("ID_Cliente")
                        .HasColumnType("int");

                    b.Property<int>("Id_Usuario")
                        .HasColumnType("int");

                    b.Property<float>("Monto_Total")
                        .HasColumnType("real");

                    b.Property<string>("Movil")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MovilId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre_Cliente_Destino")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre_Cliente_Origen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Origen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_Encomienda");

                    b.HasIndex("ClienteId_Cliente");

                    b.HasIndex("Id_Usuario");

                    b.HasIndex("MovilId");

                    b.ToTable("Encomienda");
                });

            modelBuilder.Entity("VentaPasajes.Shared.Entities.Movil", b =>
                {
                    b.Property<int>("Id_Movil")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Movil"));

                    b.Property<string>("Celular_Chofer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Codigo_Movil")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre_Chofer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_Movil");

                    b.ToTable("Movil");
                });

            modelBuilder.Entity("VentaPasajes.Shared.Entities.Oficina", b =>
                {
                    b.Property<int>("Id_Oficina")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Oficina"));

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id_Cooperativa")
                        .HasColumnType("int");

                    b.Property<string>("Nombre_Oficina")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_Oficina");

                    b.HasIndex("Id_Cooperativa");

                    b.ToTable("Oficina");
                });

            modelBuilder.Entity("VentaPasajes.Shared.Entities.Pasaje", b =>
                {
                    b.Property<int>("Id_Pasaje")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Pasaje"));

                    b.Property<int>("Cantidad_Pasajes")
                        .HasColumnType("int");

                    b.Property<string>("Destino")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha_Registro")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id_Movil")
                        .HasColumnType("int");

                    b.Property<int>("Id_Usuario")
                        .HasColumnType("int");

                    b.Property<float>("Monto_Total")
                        .HasColumnType("real");

                    b.Property<string>("Movil")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Origen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_Pasaje");

                    b.HasIndex("Id_Movil");

                    b.HasIndex("Id_Usuario");

                    b.ToTable("Pasaje");
                });

            modelBuilder.Entity("VentaPasajes.Shared.Entities.Usuario", b =>
                {
                    b.Property<int>("Id_Usuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Usuario"));

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contrasena")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha_Registro")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id_Oficina")
                        .HasColumnType("int");

                    b.Property<string>("Nombre_Completo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre_Usuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_Usuario");

                    b.HasIndex("Id_Oficina");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("VentaPasajes.Shared.Entities.Detalle_Encomienda", b =>
                {
                    b.HasOne("VentaPasajes.Shared.Entities.Encomienda", "Enco")
                        .WithMany("Detalle_Encomiendas")
                        .HasForeignKey("ID_Encomienda")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Enco");
                });

            modelBuilder.Entity("VentaPasajes.Shared.Entities.Detalle_Pasaje", b =>
                {
                    b.HasOne("VentaPasajes.Shared.Entities.Cliente", "Clie")
                        .WithMany("Detalle_Pasajes")
                        .HasForeignKey("Id_Cliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VentaPasajes.Shared.Entities.Pasaje", "Pasj")
                        .WithMany("Detalle_Pasajes")
                        .HasForeignKey("Id_Pasaje")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Clie");

                    b.Navigation("Pasj");
                });

            modelBuilder.Entity("VentaPasajes.Shared.Entities.Encomienda", b =>
                {
                    b.HasOne("VentaPasajes.Shared.Entities.Cliente", null)
                        .WithMany("Encomiendas")
                        .HasForeignKey("ClienteId_Cliente");

                    b.HasOne("VentaPasajes.Shared.Entities.Usuario", "Usu")
                        .WithMany()
                        .HasForeignKey("Id_Usuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VentaPasajes.Shared.Entities.Movil", "Mov")
                        .WithMany("Encomiendas")
                        .HasForeignKey("MovilId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Mov");

                    b.Navigation("Usu");
                });

            modelBuilder.Entity("VentaPasajes.Shared.Entities.Oficina", b =>
                {
                    b.HasOne("VentaPasajes.Shared.Entities.Cooperativa", "Coop")
                        .WithMany("Oficinas")
                        .HasForeignKey("Id_Cooperativa")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Coop");
                });

            modelBuilder.Entity("VentaPasajes.Shared.Entities.Pasaje", b =>
                {
                    b.HasOne("VentaPasajes.Shared.Entities.Movil", "Mov")
                        .WithMany("Pasajes")
                        .HasForeignKey("Id_Movil")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VentaPasajes.Shared.Entities.Usuario", "Usu")
                        .WithMany()
                        .HasForeignKey("Id_Usuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Mov");

                    b.Navigation("Usu");
                });

            modelBuilder.Entity("VentaPasajes.Shared.Entities.Usuario", b =>
                {
                    b.HasOne("VentaPasajes.Shared.Entities.Oficina", "Ofi")
                        .WithMany()
                        .HasForeignKey("Id_Oficina")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ofi");
                });

            modelBuilder.Entity("VentaPasajes.Shared.Entities.Cliente", b =>
                {
                    b.Navigation("Detalle_Pasajes");

                    b.Navigation("Encomiendas");
                });

            modelBuilder.Entity("VentaPasajes.Shared.Entities.Cooperativa", b =>
                {
                    b.Navigation("Oficinas");
                });

            modelBuilder.Entity("VentaPasajes.Shared.Entities.Encomienda", b =>
                {
                    b.Navigation("Detalle_Encomiendas");
                });

            modelBuilder.Entity("VentaPasajes.Shared.Entities.Movil", b =>
                {
                    b.Navigation("Encomiendas");

                    b.Navigation("Pasajes");
                });

            modelBuilder.Entity("VentaPasajes.Shared.Entities.Pasaje", b =>
                {
                    b.Navigation("Detalle_Pasajes");
                });
#pragma warning restore 612, 618
        }
    }
}