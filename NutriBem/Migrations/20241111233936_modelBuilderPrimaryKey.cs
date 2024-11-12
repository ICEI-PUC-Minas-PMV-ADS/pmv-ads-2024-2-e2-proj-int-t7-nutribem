using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NutriBem.Migrations
{
    /// <inheritdoc />
    public partial class modelBuilderPrimaryKey : Migration
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
                    Crn = table.Column<int>(type: "int", nullable: false),
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
                    Objetivo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Observacao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanosAlimentares", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Receitas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IngredienteQuantidade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MododePreparo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Observacoes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Calorias = table.Column<int>(type: "int", nullable: false),
                    Curtidas = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receitas", x => x.Id);
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
                    CpfNutricionista = table.Column<int>(type: "int", nullable: true),
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

            migrationBuilder.CreateTable(
                name: "Refeicoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hora = table.Column<TimeOnly>(type: "time", nullable: false),
                    PlanoAlimentarId = table.Column<int>(type: "int", nullable: false),
                    ReceitaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Refeicoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Refeicoes_PlanosAlimentares_PlanoAlimentarId",
                        column: x => x.PlanoAlimentarId,
                        principalTable: "PlanosAlimentares",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Refeicoes_Receitas_ReceitaId",
                        column: x => x.ReceitaId,
                        principalTable: "Receitas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Paciente_NutricionistaCpf",
                table: "Paciente",
                column: "NutricionistaCpf");

            migrationBuilder.CreateIndex(
                name: "IX_Refeicoes_PlanoAlimentarId",
                table: "Refeicoes",
                column: "PlanoAlimentarId");

            migrationBuilder.CreateIndex(
                name: "IX_Refeicoes_ReceitaId",
                table: "Refeicoes",
                column: "ReceitaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Paciente");

            migrationBuilder.DropTable(
                name: "Refeicoes");

            migrationBuilder.DropTable(
                name: "Nutricionista");

            migrationBuilder.DropTable(
                name: "PlanosAlimentares");

            migrationBuilder.DropTable(
                name: "Receitas");
        }
    }
}
