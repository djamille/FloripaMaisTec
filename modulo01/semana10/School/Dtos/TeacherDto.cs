namespace School.Dtos;

public class CreateTeacherDto
{
    public int UserId { get; set; }
    public string Department { get; set; }
}

public class AlterTeacherDto
{
    public string Department { get; set; }
}
public class OutTeacherDto
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public string Department { get; set; }
}
