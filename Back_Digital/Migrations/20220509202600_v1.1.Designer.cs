﻿// <auto-generated />
using Back_Digital;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Back_Digital.Migrations
{
    [DbContext(typeof(ContextConecction))]
    [Migration("20220509202600_v1.1")]
    partial class v11
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Back_Digital.Models.Clientes_BkModels", b =>
                {
                    b.Property<int>("Clientes_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Clientes_Id"), 1L, 1);

                    b.Property<int>("Clientes_Edad")
                        .HasColumnType("int");

                    b.Property<string>("Clientes_Identificacion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Clientes_Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Clientes_Id");

                    b.ToTable("Clientes_Bk");
                });

            modelBuilder.Entity("Back_Digital.Models.Productos_BkModels", b =>
                {
                    b.Property<int>("Producto_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Producto_Id"), 1L, 1);

                    b.Property<int>("Producto_Cantidad")
                        .HasColumnType("int");

                    b.Property<string>("Producto_Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Producto_Precio")
                        .HasColumnType("int");

                    b.HasKey("Producto_Id");

                    b.ToTable("Productos_Bk");
                });

            modelBuilder.Entity("Back_Digital.Models.Ventas_Productos_BkModels", b =>
                {
                    b.Property<int>("VentasP_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VentasP_Id"), 1L, 1);

                    b.Property<int>("VentasP_Cantidad")
                        .HasColumnType("int");

                    b.Property<string>("VentasP_Comprador")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VentasP_Fecha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VentasP_Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VentasP_PrecioF")
                        .HasColumnType("int");

                    b.HasKey("VentasP_Id");

                    b.ToTable("Ventas_Productos_Bk");
                });
#pragma warning restore 612, 618
        }
    }
}
