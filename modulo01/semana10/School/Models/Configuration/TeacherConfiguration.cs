using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace School.Models.Configuration
{
    public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.HasKey(e => e.Id).HasName("PK__Teacher");


            builder.Property(p => p.UserId)
                .HasColumnName("User_Id");


            builder.HasOne(x => x.User)
                    .WithMany(p => p.Teachers)
                    .HasForeignKey(x => x.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__User_Teachers");

            builder.ToTable("Teacher");
        }
    }
}
