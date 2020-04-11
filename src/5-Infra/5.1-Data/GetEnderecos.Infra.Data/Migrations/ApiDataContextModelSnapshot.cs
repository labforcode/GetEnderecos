﻿// <auto-generated />
using GetEnderecos.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace GetEnderecos.Infra.Data.Migrations
{
    [DbContext(typeof(ApiDataContext))]
    partial class ApiDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("public")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("GetEnderecos.Domain.Entities.Enderecos.Endereco", b =>
                {
                    b.Property<string>("Cep")
                        .HasColumnName("cep")
                        .HasColumnType("varchar(8)");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnName("bairro")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Complemento")
                        .IsRequired()
                        .HasColumnName("complemento")
                        .HasColumnType("varchar(150)");

                    b.Property<string>("IbgeMunicipio")
                        .IsRequired()
                        .HasColumnName("ibge_municipio")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("IbgeUf")
                        .IsRequired()
                        .HasColumnName("ibge_uf")
                        .HasColumnType("varchar(2)");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnName("logradouro")
                        .HasColumnType("varchar(250)");

                    b.Property<string>("Municipio")
                        .IsRequired()
                        .HasColumnName("municipio")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Uf")
                        .IsRequired()
                        .HasColumnName("uf")
                        .HasColumnType("varchar(2)");

                    b.HasKey("Cep");

                    b.ToTable("enderecos");
                });
#pragma warning restore 612, 618
        }
    }
}