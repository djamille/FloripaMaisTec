using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace School.Models.Configuration
{
    public class QuizConfiguration : IEntityTypeConfiguration<Quiz>
    {
        public void Configure(EntityTypeBuilder<Quiz> builder)
        {
            builder.HasKey(e => e.Id).HasName("PK__Quiz");


            builder.Property(p => p.DisciplineId)
                .HasColumnName("Discipline_Id");


            builder.HasOne(x => x.Discipline)
                    .WithMany(p => p.Quizzes)
                    .HasForeignKey(x => x.DisciplineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Discipline_Quizzes");

            builder.ToTable("Quiz");
        }
    }
}
