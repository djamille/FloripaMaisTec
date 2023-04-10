namespace School.Models
{
    public class Quiz             //Exercicio 2 M1S10 - Crie classes de model
    {
        public int Id { get; set; }
        public int DisciplineId { get; set; }
        public string Title { get; set; }
        public DateTime DateOpen { get; set; }
        public DateTime DateClose { get; set;}


        public virtual Discipline Discipline { get; set; }
        public virtual ICollection<Question> Questions { get; set; }

    }
}
