using Escola.Repositories;
using Microsoft.AspNetCore.Mvc;

//[M1S08] Exercicio 5- Criar classe AlunoRepository, contenco uma lista estática
namespace Escola.Controller;

[ApiController]
[Route("[controller]")]
public class AlunosController{
    
 //[M1S08] Exercicio 8- Criar endpoint na controller de alunos para listar os alunos da API   
    [HttpGet]
    public IActionResult Listar(string? nome)
    {
        var repository = new AlunosRepository();
        var Alunos = repository.ListarAlunos(nome);

        return Ok(Alunos);
    }
 //[M1S08] Exercicio 9- Criar endpoint na controller de alunos para obter um aluno por Id

 [HttpGet]
    [Route("{id}")]
    public IActionResult Obter(int id)
    {

        if (id <= 0)
            return BadRequest("Id deve ser maior que zero");

        var repository = new AlunosRepository();
        var Alunos = repository.ObterAlunos(id);

        if (Alunos == null)
            return NotFound();

        return Ok(Alunos);
    }

     //[M1S08] Exercicio 10 - Crie um endpoint na controller de alunos para criar um novo aluno

     [HttpPost]
    public IActionResult Criar([FromBody] AlunoDto dto){
       
       var repository = new AlunosRepository();
       var Alunos = repository.CriarAluno(dto);
       return CreatedAtAction(nameof(AlunoController.Obter),  new { id = aluno.Id }, Alunos);
    }

    [HttpPatch]
    [Route("{id}")]
    public IActionResult Atualizar(int id, [FromBody] AlunoDto dto)
    {
        var repository = new AlunosRepository();
        var Alunos = repository.AtualizarAluno(id, dto);
        return Ok(Alunos);
    }


 //[M1S08] Exercicio 11 - Crie um endpoint na controller de alunos para excluir um aluno
    [HttpDelete]
    [Route("{id}")]
    public IActionResult Excluir(int id){
       
       var repository = new AlunosRepository();
       repository.ExcluirAlunos(id);

       return NoContent();
    }
}