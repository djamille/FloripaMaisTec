namespace School.Dtos;

public class CreateAnswerDto
{
    public string Answers { get; set; }
    public float Score { get; set; }
    public string Observation { get; set; }
    public int QuestionId { get; set; }
    public int StudentId { get; set; }
}

public class AlterAnswerDto
{
    public string Observation { get; set; }
    public int QuestionId { get; set; }
    public int StudentId { get; set; }
}

public class OutAnswerDto
{
    public int Id { get; set; }
    public string Answers { get; set; }
    public float Score { get; set; }
    public string Observation { get; set; }
    public int QuestionId { get; set; }
    public int StudentId { get; set; }
}

