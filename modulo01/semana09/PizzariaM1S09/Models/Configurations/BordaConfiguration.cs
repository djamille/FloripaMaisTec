using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace PizzariaM1S09.Models.Configurations
{
    public class BordaConfiguration : IEntityTypeConfiguration<Borda>
    {
        public void Configure(EntityTypeBuilder<Borda> builder)
        {
            builder.HasKey(e => e.Id).HasName("PK__Borda");


            builder.ToTable("Borda");
        }
    }
}
