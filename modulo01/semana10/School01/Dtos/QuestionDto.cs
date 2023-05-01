using System.ComponentModel.DataAnnotations;

namespace School01.Dtos;

public class CreateQuestionDto
{
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public int QuizId { get; set; }

    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public string Enunciation { get; set; }
    
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public decimal Weight { get; set; }
}


public class AlterQuestionDto
{
    public int QuizId { get; set; }
    public string Enunciation { get; set; }
    public decimal Weight { get; set; }
}

public class OutQuestionDto
{
    public int Id { get; set; }
    public int QuizId { get; set; }
    public string Enunciation { get; set; }
    public decimal Weight { get; set; }
}
