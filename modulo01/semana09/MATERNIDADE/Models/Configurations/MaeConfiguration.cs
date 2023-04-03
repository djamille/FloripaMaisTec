using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Maternidade.Models.Configurations
{
    public class MaeConfiguration : IEntityTypeConfiguration<Mae>
    {
        public void Configure(EntityTypeBuilder<Mae> builder)
        {
            builder.HasKey(e => e.Id).HasName("PK__Mae");

            builder.Property(e => e.Nome)
                    .HasMaxLength(150);

            builder.Property(e => e.Endereco)
                    .HasMaxLength(150);


            builder.ToTable("Mae");
        }
    }
}
