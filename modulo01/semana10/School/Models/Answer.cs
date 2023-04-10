namespace School.Models
{
    public class Answer             //Exercicio 2 M1S10 - Crie classes de model
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public int StudentId { get; set; }
        public string Answers { get; set; }
        public float Score { get; set; }
        public string Observation { get; set; }


        public virtual Question Question { get; set; }
        public virtual Student Student { get; set; }

    }
}
