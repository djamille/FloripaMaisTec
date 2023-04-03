using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Maternidade.Models.Configurations
{
    public class BebeConfiguration : IEntityTypeConfiguration<Bebe>
    {
        public void Configure(EntityTypeBuilder<Bebe> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(p => p.PartoId)
                .HasColumnName("Parto_Id");

            builder.Property(p => p.MaeId)
                .HasColumnName("Mae_Id");


            builder.HasOne(x => x.Mae)
                    .WithMany(p => p.Bebes)
                    .HasForeignKey(x => x.MaeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Mae_Bebe");

            builder.HasOne(x => x.Parto)
                    .WithMany(p => p.Bebes)
                    .HasForeignKey(x => x.PartoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Parto_Bebe");

            builder.ToTable("Bebe");
        }
    }
}
