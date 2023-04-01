using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaPublica.Model.Configurations
{
    public class LivroConfiguration : IEntityTypeConfiguration<Livro>
    {
        public void Configure(EntityTypeBuilder<Livro> builder)
        {
            builder.HasKey(x => x.Id);


            builder.HasOne(x => x.Categoria)
                    .WithMany(p => p.Livros)
                    .HasForeignKey(x => x.CategoriaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Medico_Parto");
            
            builder.ToTable("Livro");
        }
    }
    
}
