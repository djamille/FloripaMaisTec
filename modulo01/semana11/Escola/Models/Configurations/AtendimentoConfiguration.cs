using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Escola.Models.Configurations
{
    public class AtendimentoConfiguration : IEntityTypeConfiguration<Atendimento>
    {
        public void Configure(EntityTypeBuilder<Atendimento> builder)
        {
            builder.HasKey(e => e.Cod).HasName("PK__Atendimento");



            builder.HasOne(x => x.Aluno)
                    .WithMany(p => p.Atendimentos)
                    .HasForeignKey(x => x.Cod)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Aluno_Atendimento");




            builder.HasOne(x => x.Pedagogo)
                    .WithMany(p => p.Atendimentos)
                    .HasForeignKey(x => x.PedagogoCod)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Pedagogo_Atendimento");

            builder.ToTable("Atendimento");
        }
    }
}
