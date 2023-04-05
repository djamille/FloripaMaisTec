namespace School.Models
{
    public class Discipline
    {
        public int Id { get; set; }
        public int TeacherId { get; set; }
        public string NameDiscipline { get; set; }


        public virtual Teacher Teacher{ get; set; }
        public virtual ICollection<Student_Discipline> Students_Disciplines { get; set; }
        public virtual ICollection<Quiz> Quizzes { get; set; }
    }
}
