using System.ComponentModel.DataAnnotations;

namespace School01.Dtos;
public class CreateStudent_DisciplineDto
{
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public int StudentId { get; set; }

    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public int DisciplineId { get; set; }
}

public class AlterStudent_DisciplineDto
{
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public int StudentId { get; set; }

    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public int DisciplineId { get; set; }
}

public class OutStudent_DisciplineDto
{
    public int Id { get; set; }
    public int StudentId { get; set; }
    public int DisciplineId { get; set; }
}