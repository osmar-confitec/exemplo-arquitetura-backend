﻿// <auto-generated />
using System;
using Contatos.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Contatos.Data.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Contatos.Dominio.Email", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Ativo");

                    b.Property<string>("EnderecoEmail")
                        .IsRequired()
                        .HasColumnType("varchar(300)");

                    b.Property<Guid>("PessoaId");

                    b.HasKey("Id");

                    b.HasIndex("PessoaId");

                    b.ToTable("EmailsT");
                });

            modelBuilder.Entity("Contatos.Dominio.Pessoa", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Ativo");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(300)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(300)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.ToTable("PessoasT");
                });

            modelBuilder.Entity("Contatos.Dominio.Telefone", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Ativo");

                    b.Property<string>("NumeroTelefone")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<Guid>("PessoaId");

                    b.HasKey("Id");

                    b.HasIndex("PessoaId");

                    b.ToTable("TelefonesTel");
                });

            modelBuilder.Entity("Contatos.Dominio.Email", b =>
                {
                    b.HasOne("Contatos.Dominio.Pessoa", "Pessoa")
                        .WithMany("Emails")
                        .HasForeignKey("PessoaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Contatos.Dominio.Telefone", b =>
                {
                    b.HasOne("Contatos.Dominio.Pessoa", "Pessoa")
                        .WithMany("Telefones")
                        .HasForeignKey("PessoaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
