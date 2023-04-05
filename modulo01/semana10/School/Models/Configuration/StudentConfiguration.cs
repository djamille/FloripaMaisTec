using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace School.Models.Configuration
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(e => e.Id).HasName("PK__Student");


            builder.Property(p => p.UserId)
                .HasColumnName("User_Id");


            builder.HasOne(x => x.User)
                    .WithMany(p => p.Students)
                    .HasForeignKey(x => x.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__User_Students");

            builder.ToTable("Student");
        }
    }
}
