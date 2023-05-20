using Microsoft.AspNetCore.Mvc;
using School.Models;
using School.Context;
using School.Dtos;

namespace School.Controllers;

//[M1S10] Ex 10 - Crie endpoints da classe Answer
[ApiController]
[Route("[controller]")]
public class AnswerController : ControllerBase
{
    private readonly SchoolContext _context;


    public AnswerController(SchoolContext context)
    {
        _context = context;
    }


    //Endpoint CRIAR
    [HttpPost]
    public ActionResult Create([FromBody] CreateAnswerDto createAnswerDto)
    {
        var answerIn = new Answer();
        answerIn.Answers = createAnswerDto.Answers;
        answerIn.Score = createAnswerDto.Score;
        answerIn.Observation = createAnswerDto.Observation;
        answerIn.StudentId = createAnswerDto.StudentId;
        answerIn.QuestionId = createAnswerDto.QuestionId;

        _context.Answers.Add(answerIn);
        _context.SaveChanges();

        var answerOut = new OutAnswerDto();
        answerOut.Id = answerIn.Id;
        answerOut.Answers = answerIn.Answers;
        answerOut.Score = answerIn.Score;
        answerOut.Observation = answerIn.Observation;
        answerOut.StudentId = answerIn.StudentId;
        answerOut.QuestionId = answerIn.QuestionId;


        return Ok(answerOut);
    }


    //Endpoint ATUALIZAR
    [HttpPut]
    [Route("{id}")]
    public IActionResult Update(int Id, [FromBody] AlterAnswerDto answerAlter)
    {
        var answer = _context.Answers.FirstOrDefault(x => x.Id.Equals(Id)); ;

        if (answer == null)
        {
            return NotFound();
        }

        answer.QuestionId = answerAlter.QuestionId;
        answer.StudentId = answerAlter.StudentId;
        answer.Observation = answerAlter.Observation;

        _context.Answers.Update(answer);
        _context.SaveChanges();

        var answerOut = new OutAnswerDto();
        answerOut.Id = answer.Id;
        answerOut.Answers = answer.Answers;
        answerOut.Score = answer.Score;
        answerOut.Observation = answer.Observation;
        answerOut.StudentId = answer.StudentId;
        answerOut.QuestionId = answer.QuestionId;

        return CreatedAtAction(nameof(AnswerController.Get), new { id = answer.Id }, answerOut);
    }


    //Endpoint LISTAR
    [HttpGet]
    public IActionResult Get()
    {
        var answers = _context.Answers.ToList();
        if (answers == null)
        {
            return NotFound();                     //Se for nulo retorna erro
        }
        return Ok(answers);
    }


    //Endpoint OBTER POR ID
    [HttpGet]
    [Route("{id}")]
    public IActionResult Get(int Id)
    {
        var answer = _context.Answers.FirstOrDefault(x => x.Id.Equals(Id)); ;

        if (answer == null)
        {
            return NotFound();
        }

        return Ok(answer);
    }


    //Endpoint EXCLUIR
    [HttpDelete]
    [Route("{id}")]
    public IActionResult DeleteAnswer(int Id)
    {
        var answer = _context.Answers.FirstOrDefault(x => x.Id.Equals(Id)); ;

        if (answer == null)
        {
            return NotFound();
        }

        _context.Answers.Remove(answer);                           //Chamando método
        _context.SaveChanges();                           //Salvando

        return NoContent();
    }
}