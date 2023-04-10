namespace School.Models
{
    public class Discipline             //Exercicio 2 M1S10 - Crie classes de model
    {
        public int Id { get; set; }
        public int TeacherId { get; set; }
        public string NameDiscipline { get; set; }


        public virtual Teacher Teacher{ get; set; }
        public virtual ICollection<Student_Discipline> Students_Disciplines { get; set; }
        public virtual ICollection<Quiz> Quizzes { get; set; }
    }
}
