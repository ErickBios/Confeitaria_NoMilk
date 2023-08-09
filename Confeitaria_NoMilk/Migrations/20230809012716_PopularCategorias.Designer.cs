﻿// <auto-generated />
using Confeitaria_NoMilk.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Confeitaria_NoMilk.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230809012716_PopularCategorias")]
    partial class PopularCategorias
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Confeitaria_NoMilk.Models.CATEGORIA", b =>
                {
                    b.Property<int>("CATEGORIAID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CATEGORIAID"));

                    b.Property<string>("CATEGORIA_NOME")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("DESCRICAO")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("CATEGORIAID");

                    b.ToTable("CATEGORIAS");
                });

            modelBuilder.Entity("Confeitaria_NoMilk.Models.LANCHE", b =>
                {
                    b.Property<int>("LANCHEID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LANCHEID"));

                    b.Property<int>("CATEGORIAID")
                        .HasColumnType("int");

                    b.Property<string>("DESCRICAO_CURTA")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("DESCRICAO_DETALHADA")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("EM_ESTOQUE")
                        .HasColumnType("bit");

                    b.Property<string>("IMAGEM_THUMBNAI_URL")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("IMAGEM_URL")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("IS_LANCHE_PREFERIDO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NAME")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<decimal>("PRECO")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("LANCHEID");

                    b.HasIndex("CATEGORIAID");

                    b.ToTable("LANCHES");
                });

            modelBuilder.Entity("Confeitaria_NoMilk.Models.LANCHE", b =>
                {
                    b.HasOne("Confeitaria_NoMilk.Models.CATEGORIA", "CATEGORIA")
                        .WithMany("LANCHEs")
                        .HasForeignKey("CATEGORIAID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CATEGORIA");
                });

            modelBuilder.Entity("Confeitaria_NoMilk.Models.CATEGORIA", b =>
                {
                    b.Navigation("LANCHEs");
                });
#pragma warning restore 612, 618
        }
    }
}
