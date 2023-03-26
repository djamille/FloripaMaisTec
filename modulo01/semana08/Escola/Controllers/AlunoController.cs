using Escola.Repositories;
using Escola.Dtos;
using Microsoft.AspNetCore.Mvc;

//[M1S08] Exercicio 5- Criar classe AlunoRepository, contenco uma lista estática
namespace Escola.Controllers;

[ApiController]
[Route("[controller]")]
public class AlunoController : ControllerBase{
    
 //[M1S08] Exercicio 8- Criar endpoint na controller de alunos para listar os alunos da API   
    [HttpGet]
    public IActionResult Listar(string? Nome)
    {
        var repository = new AlunosRepository();
        var alunos = repository.ListarAlunos(Nome);

        return Ok(alunos);
    }
 //[M1S08] Exercicio 9- Criar endpoint na controller de alunos para obter um aluno por Id

 [HttpGet]
    [Route("{id}")]
    public IActionResult Obter(int id)
    {

        if (id <= 0)
            return BadRequest("Id deve ser maior que zero");

        var repository = new AlunosRepository();
        var alunos = repository.ObterAlunos(id);

        if (alunos == null)
            return NotFound();

        return Ok(alunos);
    }

     //[M1S08] Exercicio 10 - Crie um endpoint na controller de alunos para criar um novo aluno

     [HttpPost]
    public IActionResult Criar([FromBody] AlunoDto dto){
       
       var repository = new AlunosRepository();
       var alunos = repository.CriarAluno(dto);
       return CreatedAtAction(nameof(AlunoController.Obter),  new { id = alunos.Id }, alunos);
    }

    [HttpPatch]
    [Route("{id}")]
    public IActionResult Atualizar(int id, [FromBody] AlunoDto dto)
    {
        var repository = new AlunosRepository();
        var Alunos = repository.AtualizarAlunos(id, dto);
        return Ok(Alunos);
    }


 //[M1S08] Exercicio 11 - Crie um endpoint na controller de alunos para excluir um aluno
    [HttpDelete]
    [Route("{id}")]
    public IActionResult Excluir(int id){
       
       var repository = new AlunosRepository();
       repository.ExcluirAluno(id);

       return NoContent();
    }
}