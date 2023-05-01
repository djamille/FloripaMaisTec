using System.ComponentModel.DataAnnotations;

namespace School01.Dtos;

public class CreateUserDto
{
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public string Name { get; set; }

    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public string Email { get; set; }

    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public int CPF { get; set; }

    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public string Password { get; set; }
}


public class AlterUserDto
{
    public string Email { get; set; }
    public string Password { get; set; }

}

public class OutUserDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public int CPF { get; set; }
    public string Password { get; set; }
}