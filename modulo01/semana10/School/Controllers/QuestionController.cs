using School.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using static School.Dtos.QuestionDto;
using School.Repositories;
using School.Models;

namespace School.Controllers;


//[M1S10] Ex 09 - Crie endpoints da classe Question
[ApiController]
[Route("[controller]")]
public class QuestionController : ControllerBase
{
    private readonly IQuestionRepository _questionRepository;


    public QuestionController(IQuestionRepository QuestionRepository)
    {
        _questionRepository = QuestionRepository;
    }


    //Endpoint CRIAR
    [HttpPost]
    public ActionResult<Question> Create(Question question)
    {
        _questionRepository.Create(question);

        return CreatedAtAction(nameof(QuestionController), new { id = question.Id }, question);
    }


    //Endpoint ATUALIZAR
    [HttpPut]
    [Route("{id}")]
    public IActionResult Update(int id, [FromBody] AlterQuestionDto QuestionDto)
    {
        var question = _questionRepository.GetById(id);

        if (question == null)
            return NotFound();

        question.QuizId = QuestionDto.QuizId;
        question.Enunciation = QuestionDto.Enunciation;
        question.Weight = QuestionDto.Weight;

        return CreatedAtAction(nameof(QuestionController.Get), new { id = question.Id }, question);
    }


    //Endpoint LISTAR
    [HttpGet]
    public IActionResult Get()
    {
        var question = _questionRepository.List();
        return Ok(question);
    }


    //Endpoint OBTER POR ID
    [HttpGet]
    [Route("{id}")]
    public IActionResult Get(int id)
    {
        var question = _questionRepository.GetById(id);

        if (question == null)
            return NotFound();

        return Ok(question);
    }


    //Endpoint EXCLUIR
    [HttpDelete]
    [Route("{id}")]
    public IActionResult DeleteQuestion(int id)
    {
        var question = _questionRepository.GetById(id);
        if (question == null)
        {
            return NotFound();
        }

        _questionRepository.Delete(id);

        return NoContent();
    }
}

