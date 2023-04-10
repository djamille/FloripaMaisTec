using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace School.Models.Configuration
{
    public class Student_DisciplineConfiguration : IEntityTypeConfiguration<Student_Discipline>
    {
        public void Configure(EntityTypeBuilder<Student_Discipline> builder)
        {
            builder.HasKey(e => e.Id).HasName("PK__Student_Discipline");

            builder.Property(p => p.StudentId)
                .HasColumnName("Student_Id");

            builder.Property(p => p.DisciplineId)
                .HasColumnName("Discipline_Id");

            builder.HasOne(x => x.Student)
                    .WithMany(p => p.Students_Disciplines)
                    .HasForeignKey(x => x.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Student_Student_Discipline");

            builder.HasOne(x => x.Discipline)
                    .WithMany(p => p.Students_Disciplines)
                    .HasForeignKey(x => x.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Discipline_Student_Discipline");

            builder.ToTable("Student_Discipline");
        }
    }
}