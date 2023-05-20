namespace School.Dtos;
public class CreateStudent_DisciplineDto
{
    public int StudentId { get; set; }
    public int DisciplineId { get; set; }
}

public class AlterStudent_DisciplineDto
{
    public int StudentId { get; set; }
    public int DisciplineId { get; set; }
}

public class OutStudent_DisciplineDto
{
    public int Id { get; set; }
    public int StudentId { get; set; }
    public int DisciplineId { get; set; }
}