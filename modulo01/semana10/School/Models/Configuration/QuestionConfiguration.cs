using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace School.Models.Configuration
{
    public class QuestionConfiguration : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.HasKey(e => e.Id).HasName("PK__Question");


            builder.Property(p => p.QuizId)
                .HasColumnName("Quiz_Id");


            builder.HasOne(x => x.Quiz)
                    .WithMany(p => p.Questions)
                    .HasForeignKey(x => x.QuizId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Quiz_Questions");

            builder.ToTable("Question");
        }
    }
}
