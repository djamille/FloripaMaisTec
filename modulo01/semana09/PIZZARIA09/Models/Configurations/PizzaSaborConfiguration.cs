using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace PIZZARIA09.Models.Configurations
{
    public class PizzaSaborConfiguration : IEntityTypeConfiguration<PizzaSabor>
    {
        public void Configure(EntityTypeBuilder<PizzaSabor> builder)
        {
            builder.HasKey(e => e.Id).HasName("PK__PizzaSabor");

            builder.Property(p => p.PizzaId)
                .HasColumnName("Pizza_Id");

            builder.Property(p => p.SaboresId)
                .HasColumnName("Sabores_Id");
            

            builder.HasOne(x => x.Pizza)
                    .WithMany(p => p.PizzasSabores)
                    .HasForeignKey(x => x.PizzaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Pizza_Sabor");

            builder.HasOne(x => x.Sabores)
                    .WithMany(p => p.PizzasSabores)
                    .HasForeignKey(x => x.SaboresId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Sabor_Pizza");

            builder.ToTable("PizzaSabor");
        }
    }
}
