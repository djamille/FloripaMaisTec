using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace M1S09.Models.Configuracoes
{   
    public class ProdutoPromocaoConfiguration : IEntityTypeConfiguration<ProdutoPromocao>
    {
        public void Configure(EntityTypeBuilder<ProdutoPromocao> builder) 
        {
            builder.HasKey(x => x.Id);

            builder.Property(p => p.PromocaoId)
                .HasColumnName("Promocao_Id");

            builder.Property(p => p.ProdutoId)
                .HasColumnName("Produto_Id");

            builder.HasOne(x => x.Promocao)
                .WithMany(p => p.Produtos)
                .HasForeignKey(x => x.PromocaoId)
                .HasConstraintName("FK__Promocao_Produto");

            builder.HasOne(x => x.Produto)
                .WithMany(p => p.Promocoes)
                .HasForeignKey(x => x.ProdutoId)
                .HasConstraintName("FK__Produto_Promocao");

        }
    
    }
}
