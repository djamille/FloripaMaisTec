using School.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using static School.Dtos.AnswerDto;
using School.Models;

namespace School.Controllers;

//[M1S10] Ex 10 - Crie endpoints da classe Answer
[ApiController]
[Route("[controller]")]
public class AnswerController : ControllerBase
{
    private readonly IAnswerRepository _answerRepository;


    public AnswerController(IAnswerRepository AnswerRepository)
    {
        _answerRepository = AnswerRepository;
    }


    //Endpoint CRIAR
    [HttpPost]
    public ActionResult<Answer> Create(Answer answer)
    {
        _answerRepository.Create(answer);

        return CreatedAtAction(nameof(AnswerController), new { id = answer.Id }, answer);
    }


    //Endpoint ATUALIZAR
    [HttpPut]
    [Route("{id}")]
    public IActionResult Update(int id, [FromBody] AlterAnswerDto AnswerDto)
    {
        var answer = _answerRepository.GetById(id);

        if (answer == null)
            return NotFound();

        answer.Answers = AnswerDto.Answers;
        answer.Score = AnswerDto.Score;
        answer.Observation = AnswerDto.Observation;

        return CreatedAtAction(nameof(AnswerController.Get), new { id = answer.Id }, answer);
    }


    //Endpoint LISTAR
    [HttpGet]
    public IActionResult Get()
    {
        var answers = _answerRepository.List();
        return Ok(answers);
    }


    //Endpoint OBTER POR ID
    [HttpGet]
    [Route("{id}")]
    public IActionResult Get(int id)
    {
        var answer = _answerRepository.GetById(id);

        if (answer == null)
            return NotFound();

        return Ok(answer);
    }


    //Endpoint EXCLUIR
    [HttpDelete]
    [Route("{id}")]
    public IActionResult DeleteAnswer(int id)
    {
        var answer = _answerRepository.GetById(id);
        if (answer == null)
        {
            return NotFound();
        }

        _answerRepository.Delete(id);

        return NoContent();
    }
}