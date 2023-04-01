using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaPublica.Model.Configurations
{
    public class CategoriaConfiguration : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.HasKey(x => x.Id);

                    /*builder.HasOne(x => x.Livro)
                    .WithMany(p => p.Categorias)
                    .HasForeignKey(x => x.MedicoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Medico_Parto");
                    */
            builder.ToTable("Categoria");
        }
    }
    
}
