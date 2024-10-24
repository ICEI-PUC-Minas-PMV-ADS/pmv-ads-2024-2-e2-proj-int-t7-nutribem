﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NutriBem.Migrations
{
    /// <inheritdoc />
    public partial class Teste : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Nutricionista",
                columns: table => new
                {
                    Cpf = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataNascimento = table.Column<DateOnly>(type: "date", nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefone = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nutricionista", x => x.Cpf);
                });

            migrationBuilder.CreateTable(
                name: "PlanosAlimentares",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nomepaciente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Objetivo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanosAlimentares", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Paciente",
                columns: table => new
                {
                    Cpf = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Altura = table.Column<double>(type: "float", nullable: false),
                    Peso = table.Column<double>(type: "float", nullable: false),
                    Pagante = table.Column<bool>(type: "bit", nullable: false),
                    CpfNutricionista = table.Column<int>(type: "int", nullable: false),
                    NutricionistaCpf = table.Column<int>(type: "int", nullable: true),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataNascimento = table.Column<DateOnly>(type: "date", nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefone = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paciente", x => x.Cpf);
                    table.ForeignKey(
                        name: "FK_Paciente_Nutricionista_NutricionistaCpf",
                        column: x => x.NutricionistaCpf,
                        principalTable: "Nutricionista",
                        principalColumn: "Cpf");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Paciente_NutricionistaCpf",
                table: "Paciente",
                column: "NutricionistaCpf");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Paciente");

            migrationBuilder.DropTable(
                name: "PlanosAlimentares");

            migrationBuilder.DropTable(
                name: "Nutricionista");
        }
    }
}
