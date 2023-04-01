using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace M1S09.Models.Configuracoes
{
    public class CompraConfiguration : IEntityTypeConfiguration<Compra>
    {
        public void Configure(EntityTypeBuilder<Compra>builder) 
        {
            builder.HasOne(x => x.ProdutoCompra)
                .WithMany(x => x.Compras)
                .HasForeignKey(x => x.ProdutoId)
                .HasConstraintName("FK_Compra_Produto");

            builder.HasOne(x => x.ClienteCompra)
                .WithMany(x => x.Compras)
                .HasForeignKey(x => x.ClienteId)
                .HasConstraintName("FK_Compra_Cliente");
        }
    }
}
