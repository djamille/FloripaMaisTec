using Microsoft.AspNetCore.Mvc;
using School.Repositories.Interfaces;
using static School.Dtos.QuizDto;
using School.Models;
using School.Repositories;

namespace School.Controllers;


//[M1S10] Ex 08 - Crie endpoints da classe Quiz
[ApiController]
[Route("[controller]")]
public class QuizController : ControllerBase
{
    private readonly IQuizRepository _quizRepository;


    public QuizController(IQuizRepository QuizRepository)
    {
        _quizRepository = QuizRepository;
    }


    //Endpoint CRIAR
    [HttpPost]
    public ActionResult<Quiz> Create(Quiz quiz)
    {
        _quizRepository.Create(quiz);

        return CreatedAtAction(nameof(QuizController), new { id = quiz.Id }, quiz);
    }


    //Endpoint ATUALIZAR
    [HttpPut]
    [Route("{id}")]
    public IActionResult Update(int id, [FromBody] AlterQuizDto QuizDto)
    {
        var quiz = _quizRepository.GetById(id);

        if (quiz == null)
            return NotFound();

        quiz.DisciplineId = QuizDto.DisciplineId;
        quiz.Title = QuizDto.Title;

        return CreatedAtAction(nameof(QuizController.Get), new { id = quiz.Id }, quiz);
    }


    //Endpoint LISTAR
    [HttpGet]
    public IActionResult Get()
    {
        var quiz = _quizRepository.List();
        return Ok(quiz);
    }


    //Endpoint OBTER POR ID
    [HttpGet]
    [Route("{id}")]
    public IActionResult Get(int id)
    {
        var quiz = _quizRepository.GetById(id);

        if (quiz == null)
            return NotFound();

        return Ok(quiz);
    }


    //Endpoint EXCLUIR
    [HttpDelete]
    [Route("{id}")]
    public IActionResult DeleteQuiz(int id)
    {
        var quiz = _quizRepository.GetById(id);
        if (quiz == null)
        {
            return NotFound();
        }

        _quizRepository.Delete(id);

        return NoContent();
    }
}
