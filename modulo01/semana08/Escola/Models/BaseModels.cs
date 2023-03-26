namespace Escola.Models;

//[M1S08] Exercicio 3- Criar classe abstrata BaseModel

public abstract class BaseModel {

    public int Id { get; set; }
    public DateTime DataDeInclusao { get; set; }
    public DateTime DataDeAlteracao { get; set; }    
}