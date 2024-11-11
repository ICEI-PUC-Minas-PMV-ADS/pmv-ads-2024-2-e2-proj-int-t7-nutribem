using Microsoft.EntityFrameworkCore;
using NutriBem.Models;

namespace NutriBem.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Receita> Receitas { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Nutricionista> Nutricionistas { get; set; }
        public DbSet<PlanoAlimentar> PlanosAlimentares { get; set; }
        public DbSet<Refeicao> Refeicoes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PlanoAlimentar>()
           .HasMany(p => p.Refeicoes)
           .WithOne(r => r.PlanoAlimentar)
           .OnDelete(DeleteBehavior.Cascade); // Exclusão em cascata

            modelBuilder.Entity<Refeicao>()
           .HasOne(r => r.Receita)
           .WithMany() // Receitas podem ser referenciadas por várias refeições
           .HasForeignKey(r => r.ReceitaId) // Chave estrangeira
           .OnDelete(DeleteBehavior.Restrict); // A receita não deve ser excluída ao remover a refeição
        }
        public DbSet<NutriBem.Models.Refeicao> Refeicao { get; set; }

        public DbSet<Comentario> Comentarios { get; set; }

    }
}
