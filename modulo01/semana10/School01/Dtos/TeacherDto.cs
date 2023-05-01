using System.ComponentModel.DataAnnotations;

namespace School01.Dtos;

public class CreateTeacherDto
{
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public int UserId { get; set; }

    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public string Department { get; set; }
}

public class AlterTeacherDto
{ 
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
public string Department { get; set; }
}
public class OutTeacherDto
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public string Department { get; set; }
}
