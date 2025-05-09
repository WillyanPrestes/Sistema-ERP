﻿// <auto-generated />
using System;
using Financeiro.Models.DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Financeiro.Models.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Financeiro.Models.Objetos.Estoque.oCategoriaProduto", b =>
                {
                    b.Property<int>("_IdCategoriaProduto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("_Descricao")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("_IdCategoriaProduto");

                    b.ToTable("dbCategoriaProduto");
                });

            modelBuilder.Entity("Financeiro.Models.Objetos.Estoque.oProduto", b =>
                {
                    b.Property<int?>("_IdProduto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool?>("_Ativo")
                        .IsRequired()
                        .HasColumnType("tinyint(1)");

                    b.Property<decimal?>("_Custo")
                        .IsRequired()
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("_Descricao")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal?>("_EstoqueAtual")
                        .IsRequired()
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("_EstoqueMinimo")
                        .IsRequired()
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("_IdCategoriaProduto")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<decimal?>("_MargemLucro")
                        .IsRequired()
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("_PrecoVenda")
                        .IsRequired()
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("_UnidadeMedida")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("_IdProduto");

                    b.HasIndex("_IdCategoriaProduto");

                    b.ToTable("dbProduto");
                });

            modelBuilder.Entity("Financeiro.Models.Objetos.Estoque.oProduto", b =>
                {
                    b.HasOne("Financeiro.Models.Objetos.Estoque.oCategoriaProduto", "_CategoriaProduto")
                        .WithMany()
                        .HasForeignKey("_IdCategoriaProduto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("_CategoriaProduto");
                });
#pragma warning restore 612, 618
        }
    }
}
