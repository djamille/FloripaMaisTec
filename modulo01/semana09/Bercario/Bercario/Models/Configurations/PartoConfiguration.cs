using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bercario.Models.Configurations
{
    public class PartoConfiguration : IEntityTypeConfiguration<Parto>
    {
        public void Configure(EntityTypeBuilder<Parto> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(p => p.MedicoId)
                .HasColumnName("Medico_Id");

            builder.HasOne(x => x.Medico)
                    .WithMany(p => p.Partos)
                    .HasForeignKey(x => x.MedicoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Medico_Parto");

            builder.ToTable("Parto");
        }
    }
}

