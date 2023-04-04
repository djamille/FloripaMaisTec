using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace PizzariaM1S09.Models.Configurations
{
    public class SaborConfiguration : IEntityTypeConfiguration<Sabor>
    {
        public void Configure(EntityTypeBuilder<Sabor> builder)
        {
            builder.HasKey(e => e.Id).HasName("PK__Sabor");


            builder.ToTable("Sabor");
        }
    }
}