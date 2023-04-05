using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace School.Models.Configuration
{
    public class AnswerConfiguration : IEntityTypeConfiguration<Answer>
    {
        public void Configure(EntityTypeBuilder<Answer> builder)
        {
            builder.HasKey(e => e.Id).HasName("PK__Answer");


            builder.Property(p => p.QuestionId)
                .HasColumnName("Question_Id");

            builder.Property(p => p.StudentId)
                .HasColumnName("Student_Id");


            builder.HasOne(x => x.Question)
                    .WithMany(p => p.Answers)
                    .HasForeignKey(x => x.QuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Question_Answers");

            builder.HasOne(x => x.Student)
                    .WithMany(p => p.Answers)
                    .HasForeignKey(x => x.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Student_Answers");

            builder.ToTable("Answer");
        }
    }
}
