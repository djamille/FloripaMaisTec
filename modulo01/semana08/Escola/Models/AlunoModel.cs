namespace Escola.Models;

//[M1S08] Exercicio 4- Criar classe AlunoModels herdando da classe BaseModel

public class AlunoModels : BaseModel {
    public string Nome { get; set; }
    public DateTime DataNascimento { get; set; }
}