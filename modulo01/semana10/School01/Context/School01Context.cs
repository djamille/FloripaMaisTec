using Microsoft.EntityFrameworkCore;
using School.Models;
using School.Models.Configuration;

namespace School01.Context;

public class School01Context : DbContext
{
    public School01Context(DbContextOptions<School01Context> options) : base(options)
    {

    }

    public DbSet<Answer> Answers { get; set; }
    public DbSet<Discipline> Disciplines { get; set; }
    public DbSet<Question> Questions { get; set; }
    public DbSet<Quiz> Quizzes { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Student_Discipline> Students_Disciplines { get; set; }
    public DbSet<Teacher> Teachers { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)                          //Adicionando ("puxando" das classes Configurations) minhas configuraçoes
    {
        modelBuilder.ApplyConfiguration(new AnswerConfiguration());
        modelBuilder.ApplyConfiguration(new DisciplineConfiguration());
        modelBuilder.ApplyConfiguration(new QuestionConfiguration());
        modelBuilder.ApplyConfiguration(new QuizConfiguration());
        modelBuilder.ApplyConfiguration(new StudentConfiguration());
        modelBuilder.ApplyConfiguration(new Student_DisciplineConfiguration());
        modelBuilder.ApplyConfiguration(new TeacherConfiguration());
        modelBuilder.ApplyConfiguration(new UserConfiguration());

        modelBuilder.Entity<Answer>().HasData(
            new Answer { Id = 1, QuestionId = 1, StudentId = 1, Answers = "Segunda-feira", Score = 1, Observation = "" },
            new Answer { Id = 2, QuestionId = 2, StudentId = 1, Answers = "Ler e montar quebra-cabeças", Score = 2, Observation = "" },
            new Answer { Id = 3, QuestionId = 3, StudentId = 1, Answers = "Biologia", Score = 1, Observation = "" });

        modelBuilder.Entity<Discipline>().HasData(
            new Discipline { Id = 1, TeacherId = 1, NameDiscipline = "Biologia" },
            new Discipline { Id = 2, TeacherId = 2, NameDiscipline = "Português" },
            new Discipline { Id = 3, TeacherId = 3, NameDiscipline = "Matemática" });

        modelBuilder.Entity<Question>().HasData(
            new Question { Id = 1, QuizId = 1, Enunciation = "Qual o dia da semana que você mais gosta?", Weight = 1 },
            new Question { Id = 2, QuizId = 1, Enunciation = "Qual seu hobbie?", Weight = 2 },
            new Question { Id = 3, QuizId = 1, Enunciation = "Qual a sua matéria favorita?", Weight = 1 });

        modelBuilder.Entity<Quiz>().HasData(
            new Quiz { Id = 1, DisciplineId = 1, Title = "Conhecendo o aluno?" });

        modelBuilder.Entity<Student>().HasData(
            new Student { Id = 1, UserId = 1, Period = 1, RA = 11548 },
            new Student { Id = 2, UserId = 2, Period = 1, RA = 14999 },
            new Student { Id = 3, UserId = 3, Period = 2, RA = 15129 });

        modelBuilder.Entity<Student_Discipline>().HasData(
            new Student_Discipline { Id = 1, DisciplineId = 1, StudentId = 1 },
            new Student_Discipline { Id = 2, DisciplineId = 1, StudentId = 2 },
            new Student_Discipline { Id = 3, DisciplineId = 1, StudentId = 3 });

        modelBuilder.Entity<Teacher>().HasData(
            new Teacher { Id = 1, UserId = 1, Department = "" },
            new Teacher { Id = 2, UserId = 2, Department = "" },
            new Teacher { Id = 3, UserId = 3, Department = "" });

        modelBuilder.Entity<User>().HasData(
            new User { Id = 1, Name = "Bart Simpson", Email = "bart@hotmail.com", CPF = 118397500, Password = "aabbcc" },
            new User { Id = 2, Name = "Meggie Simpson", Email = "meggie@hotmail.com", CPF = 171589470, Password = "123456" },
            new User { Id = 3, Name = "Lisa Simpson", Email = "lisa@hotmail.com", CPF = 637012100, Password = "a1b2c3" });
    }
}