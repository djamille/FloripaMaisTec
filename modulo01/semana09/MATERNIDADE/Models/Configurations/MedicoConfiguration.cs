using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Maternidade.Models.Configurations
{
    public class MedicoConfiguration : IEntityTypeConfiguration<Medico>
    {
        public void Configure(EntityTypeBuilder<Medico> builder)
        {
            builder.HasKey(e => e.Id).HasName("PK__Medico");

            builder.Property(e => e.Nome)
                    .HasMaxLength(150);


            builder.ToTable("Medico");
        }
    }
}



