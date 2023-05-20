using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Escola.Models.Configurations
{
    public class AlunoConfiguration : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> builder)
        {
            builder.HasKey(e => e.Cod).HasName("PK__Aluno");



            builder.Property(e => e.Situacao)
                .HasColumnType("enum")
                .HasColumnName("Situação da Matrícula");


            builder.Property(e => e.Nota)
                .HasColumnType("float")
                .HasColumnName("Nota");


            builder.Property(e => e.QtdAtendimento)
                .HasColumnType("integer")
                .HasColumnName("Qtd Atendimentos");


            builder.ToTable("Aluno");
        }
    }
}