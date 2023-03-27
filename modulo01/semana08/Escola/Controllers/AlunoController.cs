using Escola.Repositories;
using Escola.Dtos;
using Microsoft.AspNetCore.Mvc;

//[M1S08] Exercício 7- Criar classe AlunoController
namespace Escola.Controllers;


[ApiController]         //Indicativo de que a classe é uma controller
[Route("[controller]")]         //Customização de url
public class AlunoController : ControllerBase
{


    //[M1S08] Exercício 8- Criar endpoint na controller de alunos para listar os alunos por nome  
    [HttpGet]                      //Busca dados
    public IActionResult Listar(string? Nome)                             //Criando EndPoint. 'IActionResult' é utilizado pois varios podem ser o tipo de retorno válido             
    {
        var repository = new AlunosRepository();                    //Nomeando variável e criando objeto
        var alunos = repository.ListarAlunos(Nome);                     //Nomeando variável e chamando método

        return Ok(alunos);                  //O 'OK' deve retornar o 'ObjectResult' que deve ser o status code 200 - Sucesso
    }


    //[M1S08] Exercício 9- Criar endpoint na controller de alunos para obter um aluno por Id
    [HttpGet]                    //Busca dados
    [Route("{id}")]                    //Define rota url
    public IActionResult Obter(int id)                             //Criando EndPoint.
    {
        if (id <= 0)                        //Condição que Id seja maior que zero, senão retorna frase abaixo
            return BadRequest("Id deve ser maior que zero");                    //Retorna mensagem por conta de erro do cliente/usuário

        var repository = new AlunosRepository();                    //Nomeando variável e criando objeto
        var alunos = repository.ObterAlunos(id);                     //Nomeando variável e chamando método

        if (alunos == null)                           //Se o resultado for null, retorna erro 404
            return NotFound();

        return Ok(alunos);                          //O 'OK' deve retornar o 'ObjectResult' que deve ser o status code 200 - Sucesso
    }


    //[M1S08] Exercício 10 - Crie um endpoint na controller de alunos para criar um novo aluno
    [HttpPost]                      //Envia dados
    public IActionResult Criar([FromBody] AlunoDto dto)
    {                                //Criando EndPoint.

        var repository = new AlunosRepository();                    //Nomeando variável e criando objeto
        var alunos = repository.CriarAluno(dto);                     //Nomeando variável e chamando método
        return CreatedAtAction(nameof(AlunoController.Obter), new { id = alunos.Id }, alunos);                      //Se a requisição solicitada retornar 201, a mesma foi realizada com sucesso
    }



    [HttpPatch]                     //Atualiza dados
    [Route("{id}")]                    //Define rota url
    public IActionResult Atualizar(int id, [FromBody] AlunoDto dto)                                //Criando EndPoint.
    {
        var repository = new AlunosRepository();                    //Nomeando variável e criando objeto
        var Alunos = repository.AtualizarAlunos(id, dto);                     //Nomeando variável e chamando método
        return Ok(Alunos);                        //O 'OK' deve retornar o 'ObjectResult' que deve ser o status code 200 - Sucesso
    }



    //[M1S08] Exercício 11 - Crie um endpoint na controller de alunos para excluir um aluno
    [HttpDelete]                       //Exclui dados
    [Route("{id}")]                    //Define rota url
    public IActionResult Excluir(int id)                                //Criando EndPoint.
    {
        var repository = new AlunosRepository();                     //Nomeando variável e criando objeto
        repository.ExcluirAluno(id);                           //Chamando método

        return NoContent();
    }
}