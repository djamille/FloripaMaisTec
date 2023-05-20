namespace School.Dtos;
public class CreateQuizDto
{
    public int DisciplineId { get; set; }
    public string Title { get; set; }
    public DateTime DateOpen { get; set; }
    public DateTime DateClose { get; set; }
}


public class AlterQuizDto
{
    public int DisciplineId { get; set; }
    public string Title { get; set; }
    public DateTime DateOpen { get; set; }
    public DateTime DateClose { get; set; }
}

public class OutQuizDto
{
    public int Id { get; set; }
    public int DisciplineId { get; set; }
    public string Title { get; set; }
    public DateTime DateOpen { get; set; }
    public DateTime DateClose { get; set; }
}