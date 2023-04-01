using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace M1S09.Models.Configuracoes
{   
    public class ProdutoPromocaoConfiguration : IEntityTypeConfiguration<ProdutoPromocao>
    {
        public void Configure(EntityTypeBuilder<ProdutoPromocao> builder) 
        {
            builder.HasOne(x => x.Promocao)
                .WithMany(p => p.Produto)
                .HasForeignKey(x => x.PromocaoId)
                .HasConstraintName("FK__Promocao_Produto");

            builder.HasOne(x => x.Produto)
                .WithMany(p => p.Promocao)
                .HasForeignKey(x => x.ProdutoId)
                .HasConstraintName("FK__Produto_Promocao");

        }
    
    }
}
