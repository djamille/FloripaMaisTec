using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace PizzariaM1S09.Models.Configurations
{
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(e => e.Id).HasName("PK__Pedido");

            builder.Property(p => p.PizzaId)
                .HasColumnName("Pizza_Id");

            builder.Property(p => p.StatusId)
                .HasColumnName("Status_Id");


            builder.HasOne(x => x.Pizza)
                    .WithMany(p => p.Pedidos)
                    .HasForeignKey(x => x.PizzaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Pizza_Pedido");

            builder.HasOne(x => x.Status)
                    .WithMany(p => p.Pedidos)
                    .HasForeignKey(x => x.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Status_Pizza");


            builder.ToTable("Pedido");
        }
    }
}
