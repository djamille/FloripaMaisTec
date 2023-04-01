using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BibliotecaPublica.Model.Configurations
{
    public class LivroAutorConfiguration : IEntityTypeConfiguration<LivroAutor>
    {
        public void Configure(EntityTypeBuilder<LivroAutor> builder)
        {
            builder.HasKey(x => x.Id);


            builder.HasOne(x => x.Autor)
                    .WithMany(p => p.Livros)
                    .HasForeignKey(x => x.AutorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Autor_Livros");

            builder.HasOne(x => x.Livro)
                    .WithMany(p => p.Autores)
                    .HasForeignKey(x => x.LivroId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Autor_Livros");

            builder.ToTable("LivroAutor");
        }
    }
}
