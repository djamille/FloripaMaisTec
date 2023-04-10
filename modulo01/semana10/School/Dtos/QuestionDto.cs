namespace School.Dtos
{
    public class QuestionDto
    {
        public class CreateQuestionDto
        {
            public int QuizId { get; set; }
            public string Enunciation { get; set; }
            public decimal Weight { get; set; }
        }

       
        public class AlterQuestionDto
        {
            public int QuizId { get; set; }
            public string Enunciation { get; set; }
            public decimal Weight{ get; set; }            
        }
    }
}

