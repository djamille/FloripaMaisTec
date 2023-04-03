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
                .HasColumnName("PizzaId");

            builder.Property(p => p.SaboresId)
                .HasColumnName("SaboresId");


            builder.HasOne(x => x.Pizza)
                    .WithMany(p => p.PizzaSabor)
                    .HasForeignKey(x => x.PizzaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Mae_Bebe");

            builder.HasOne(x => x.Sabores)
                    .WithMany(p => p.Pizzas_Sabores)
                    .HasForeignKey(x => x.SaboresId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Parto_Bebe");

            builder.ToTable("PizzaSabor");
        }
    }
}
