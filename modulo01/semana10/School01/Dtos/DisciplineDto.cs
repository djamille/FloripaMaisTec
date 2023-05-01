using System.ComponentModel.DataAnnotations;

namespace School01.Dtos;
public class CreateDisciplineDto
{
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public int TeacherId { get; set; }

    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public string NameDiscipline { get; set; }
}


public class AlterDisciplineDto
{
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public int TeacherId { get; set; }
}

public class OutDisciplineDto
{
    public int Id { get; set; }
    public int TeacherId { get; set; }
    public string NameDiscipline { get; set; }
}