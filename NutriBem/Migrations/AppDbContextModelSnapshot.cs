﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace NutriBem.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("NutriBem.Models.Nutricionista", b =>
                {
                    b.Property<string>("Cpf")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<int>("Crn")
                        .HasColumnType("int");

                    b.Property<DateOnly>("DataNascimento")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Telefone")
                        .HasColumnType("int");

                    b.HasKey("Cpf");

                    b.ToTable("Nutricionista");
                });

            modelBuilder.Entity("NutriBem.Models.Paciente", b =>
                {
                    b.Property<string>("Cpf")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<double>("Altura")
                        .HasColumnType("float");

                    b.Property<int>("CpfNutricionista")
                        .HasColumnType("int");

                    b.Property<DateOnly>("DataNascimento")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NutricionistaCpf")
                        .HasColumnType("nvarchar(11)");

                    b.Property<bool>("Pagante")
                        .HasColumnType("bit");

                    b.Property<double>("Peso")
                        .HasColumnType("float");

                    b.Property<string>("Senha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Telefone")
                        .HasColumnType("int");

                    b.HasKey("Cpf");

                    b.HasIndex("NutricionistaCpf");

                    b.ToTable("Paciente");
                });

            modelBuilder.Entity("NutriBem.Models.PlanoAlimentar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nomepaciente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Objetivo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observacao")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PlanosAlimentares");
                });

            modelBuilder.Entity("NutriBem.Models.Receita", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Calorias")
                        .HasColumnType("int");

                    b.Property<int>("Curtidas")
                        .HasColumnType("int");

                    b.Property<string>("IngredienteQuantidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MododePreparo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observacoes")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Receitas");
                });

            modelBuilder.Entity("NutriBem.Models.Refeicao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<TimeOnly>("Hora")
                        .HasColumnType("time");

                    b.Property<int>("PlanoAlimentarId")
                        .HasColumnType("int");

                    b.Property<int>("ReceitaId")
                        .HasColumnType("int");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PlanoAlimentarId");

                    b.HasIndex("ReceitaId");

                    b.ToTable("Refeicoes");
                });

            modelBuilder.Entity("NutriBem.Models.Paciente", b =>
                {
                    b.HasOne("NutriBem.Models.Nutricionista", "Nutricionista")
                        .WithMany("Pacientes")
                        .HasForeignKey("NutricionistaCpf");

                    b.Navigation("Nutricionista");
                });

            modelBuilder.Entity("NutriBem.Models.Refeicao", b =>
                {
                    b.HasOne("NutriBem.Models.PlanoAlimentar", "PlanoAlimentar")
                        .WithMany("Refeicoes")
                        .HasForeignKey("PlanoAlimentarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NutriBem.Models.Receita", "Receita")
                        .WithMany()
                        .HasForeignKey("ReceitaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("PlanoAlimentar");

                    b.Navigation("Receita");
                });

            modelBuilder.Entity("NutriBem.Models.Nutricionista", b =>
                {
                    b.Navigation("Pacientes");
                });

            modelBuilder.Entity("NutriBem.Models.PlanoAlimentar", b =>
                {
                    b.Navigation("Refeicoes");
                });
#pragma warning restore 612, 618
        }
    }
}
