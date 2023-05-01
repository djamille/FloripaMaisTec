using System.ComponentModel.DataAnnotations;

namespace School01.Dtos;

public class CreateStudentDto
{
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
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