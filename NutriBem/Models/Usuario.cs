﻿using FluentNHibernate.Conventions.Helpers;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NutriBem.Models
{

    public abstract class Usuario
    {
        [Required(ErrorMessage = "Obrigatório informar o nome")]
        public required string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o email")]
        public required string Email { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a data de nascimento")]
        [Display(Name = "Data de Nascimento")]
        public required DateOnly DataNascimento { get; set; }

        public string Senha { get; set; }

        [Key] 
        [Required(ErrorMessage = "Obrigatório informar o CPF")]
        [StringLength(11, ErrorMessage = "O CPF deve ter 11 caracteres.")]
        [RegularExpression(@"^\d{11}$", ErrorMessage = "O CPF deve ser composto por 11 dígitos numéricos.")]
        public string Cpf { get; set; }

        [StringLength(11, ErrorMessage = "O telefone deve ter 11 dígitos.")]
        [RegularExpression(@"^\d{11}$", ErrorMessage = "O CPF deve ser composto por 11 dígitos numéricos.")]
        [Required(ErrorMessage = "Obrigatório informar o telefone")]
        public string Telefone { get; set; }

        public Usuario() { }

        public Usuario(
            string nome,
            string email,
            DateOnly dataNascimento,
            string senha,
            string cpf, 
            string telefone
        )
        {
            Nome = nome;
            Email = email;
            DataNascimento = dataNascimento;
            Senha = senha;
            Cpf = cpf; 
            Telefone = telefone;
        }
    }

    [Table("Paciente")]
    public class Paciente : Usuario
    {
        [Required(ErrorMessage = "Obrigatório informar a altura")]
        public required double Altura { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o peso")]
        public required double Peso { get; set; }

        public bool Pagante { get; set; }

        [ForeignKey("CpfNutricionista")]
        public string CpfNutricionista { get; set; }

        public Nutricionista Nutricionista { get; set; }

        public Paciente() { }

        public Paciente(
            double altura, double peso, string nome, string email,
            DateOnly dataNascimento, string senha, string cpf, string telefone, string cpfNutricionista
        ) : base(nome, email, dataNascimento, senha, cpf, telefone)
        {
            Altura = altura;
            Peso = peso;
        }
    }

    [Table("Nutricionista")]
    public class Nutricionista : Usuario
    {
        [Required(ErrorMessage = "Obrigatório informar o CRM")]
        public int Crn { get; set; }

        public ICollection<Paciente> Pacientes { get; set; }

        public Nutricionista() { }

        public Nutricionista(
            int crn, string nome, string email, DateOnly dataNascimento, string senha, string cpf, string telefone
        ) : base(nome, email, dataNascimento, senha, cpf, telefone)
        {
            Crn = crn;
        }
    }

}
