using Microsoft.EntityFrameworkCore;
using Sistema_escolar.Models;

namespace Sistema_escolar.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Disciplinas> Disciplinas { get; set; }
        public DbSet<Nota> Notas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aluno>()
                .HasMany(p => p.Disciplinas) 
                .WithOne(t => t.Aluno) 
                .HasForeignKey(t => t.AlunoId); 
            
            modelBuilder.Entity<Disciplinas>()
                .HasKey(t => t.DisciplinaId);

            modelBuilder.Entity<Disciplinas>()
           .HasMany(d => d.Notas)
           .WithOne(n => n.Disciplina)
           .HasForeignKey(n => n.DisciplinaId);

        }


    }
}
