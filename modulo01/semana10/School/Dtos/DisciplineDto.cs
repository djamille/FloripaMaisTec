namespace School.Dtos;
public class CreateDisciplineDto
{
    public int TeacherId { get; set; }
    public string NameDiscipline { get; set; }
}


public class AlterDisciplineDto
{
    public int TeacherId { get; set; }
}

public class OutDisciplineDto
{
    public int Id { get; set; }
    public int TeacherId { get; set; }
    public string NameDiscipline { get; set; }
}