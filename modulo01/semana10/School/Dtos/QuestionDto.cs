namespace School.Dtos;

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
    public decimal Weight { get; set; }
}

public class OutQuestionDto
{
    public int Id { get; set; }
    public int QuizId { get; set; }
    public string Enunciation { get; set; }
    public decimal Weight { get; set; }
}
