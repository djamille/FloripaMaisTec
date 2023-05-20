using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace School.Models.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(e => e.Id).HasName("PK__User");

            builder.Property(p => p.Name)                       //Define propriedade de uma entidade
            .IsRequired()                                   //"Obrigatório"
            .HasMaxLength(80);

            builder.Property(p => p.Email)                       //Define propriedade de uma entidade
            .IsRequired()                                   //"Obrigatório"
            .HasMaxLength(80);

            builder.Property(P => P.CPF)
            .HasMaxLength(11)
            .IsRequired();

            builder.Property(P => P.Password)
            .IsRequired();

            builder.ToTable("User");
        }
    }
}
