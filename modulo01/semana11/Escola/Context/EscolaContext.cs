using Escola.Models;
using Escola.Models.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Escola.Context
{
    public class EscolaContext : DbContext
    {

        public EscolaContext(DbContextOptions<EscolaContext> options) : base(options)
        {

        }


        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Atendimento> Atendimentos { get; set; }
        public DbSet<Professor> Professores { get; set; }
        //public DbSet<Pedagogo> Pedagogos { get; set; }




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=MILLE\\SQLEXPRESS;Database=djamille_escolaUser ID=sa;Password=********;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AlunoConfiguration());
            modelBuilder.ApplyConfiguration(new AtendimentoConfiguration());
            modelBuilder.ApplyConfiguration(new ProfessorConfiguration());
            //modelBuilder.ApplyConfiguration(new PedagogoConfiguration());

        }
    }
}