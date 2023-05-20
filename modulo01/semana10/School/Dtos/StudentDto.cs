namespace School.Dtos;

public class CreateStudentDto
{
    public int UserId { get; set; }
    public int Period { get; set; }
    public int RA { get; set; }
}


public class AlterStudentDto
{
    public int Period { get; set; }
    public int RA { get; set; }
}

public class OutStudentDto
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int Period { get; set; }
    public int RA { get; set; }
}