namespace School.Models
{
    public class Question             //Exercicio 2 M1S10 - Crie classes de model
    {
        public int Id { get; set; }
        public int QuizId { get; set; }
        public string Enunciation { get; set; }
        public decimal Weight { get; set; }


        public virtual Quiz Quiz { get; set; }
        public virtual ICollection<Answer> Answers { get; set; }
    }
}
