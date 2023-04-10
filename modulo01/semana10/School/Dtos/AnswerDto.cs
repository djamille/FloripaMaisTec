namespace School.Dtos
{
    public class AnswerDto
    {

        public class CreateAnswerDto
        {
            public string Answers { get; set; }
            public float Score { get; set; }
            public string Observation { get; set; }
        }

        public class AlterAnswerDto
        {
            public string Answers { get; set; }
            public float Score { get; set; }
            public string Observation { get; set; }
        }
    }
}
