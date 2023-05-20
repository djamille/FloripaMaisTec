using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Escola.Models.Configurations
{
    public class PedagogoConfiguration : IEntityTypeConfiguration<Pedagogo>
    {
        public void Configure(EntityTypeBuilder<Pedagogo> builder)
        {
            builder.HasKey(e => e.Cod).HasName("PK__Pedagogo");

            builder.Property(e => e.QtdAtendimento)
                .HasColumnType("integer")
                .HasColumnName("Qtd Atendimentos");

            builder.ToTable("Pedagogo");
        }
    }
}
