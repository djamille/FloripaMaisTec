using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Escola.Models.Configurations
{
    public class ProfessorConfiguration : IEntityTypeConfiguration<Professor>
    {
        public void Configure(EntityTypeBuilder<Professor> builder)
        {
            builder.HasKey(e => e.Cod).HasName("PK__Professor");


            builder.Property(e => e.Estado)
                .HasColumnType("enum")
                .HasColumnName("Estado");


            builder.Property(e => e.Experiencia)
                .HasColumnType("enum")
                .HasColumnName("Experiência");


            builder.Property(e => e.Formacao)
                .HasColumnType("enum")
                .HasColumnName("Formação Acadêmica");


            builder.ToTable("Professor");
        }
    }
}
