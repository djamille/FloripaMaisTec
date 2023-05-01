using System.ComponentModel.DataAnnotations;

namespace School01.Dtos;
public class CreateQuizDto
{
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public int DisciplineId { get; set; }

    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public string Title { get; set; }

    public DateTime DateOpen { get; set; }

    public DateTime DateClose { get; set; }
}


public class AlterQuizDto
{
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public int DisciplineId { get; set; }

    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
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