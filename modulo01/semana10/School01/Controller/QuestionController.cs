using Microsoft.AspNetCore.Mvc;
using School.Models;
using School01.Context;
using School01.Dtos;

namespace School.Controllers;


//[M1S10] Ex 09 - Crie endpoints da classe Question
[ApiController]
[Route("[controller]")]
public class QuestionController : ControllerBase
{
    private readonly School01Context _context;


    public QuestionController(School01Context context)
    {
        _context = context;
    }


    //Endpoint CRIAR
    [HttpPost]
    public ActionResult Create([FromBody] CreateQuestionDto createQuestionDto)
    {
        var quetionIn = new Question();
        quetionIn.QuizId = createQuestionDto.QuizId;
        quetionIn.Enunciation = createQuestionDto.Enunciation;
        quetionIn.Weight = createQuestionDto.Weight;


        _context.Questions.Add(quetionIn);
        _context.SaveChanges();

        var questionOut = new OutQuestionDto();
        questionOut.Id = quetionIn.Id;
        questionOut.QuizId = quetionIn.QuizId;
        questionOut.Enunciation = questionOut.Enunciation;
        questionOut.Weight = questionOut.Weight;

        return Ok(questionOut);
    }


    //Endpoint ATUALIZAR
    [HttpPut]
    public IActionResult Update(int Id, [FromBody] AlterQuestionDto questionAlter)
    {
        var quetionIn = _context.Questions.FirstOrDefault(x => x.Id.Equals(Id)); ;

        if (quetionIn == null)
        {
            return NotFound();
        }

        quetionIn.QuizId = questionAlter.QuizId;
        quetionIn.Enunciation = questionAlter.Enunciation;
        quetionIn.Weight = questionAlter.Weight;


        _context.Questions.Update(quetionIn);
        _context.SaveChanges();

        var questionOut = new OutQuestionDto();
        questionOut.Id = quetionIn.Id;
        questionOut.QuizId = quetionIn.QuizId;
        questionOut.Enunciation = questionOut.Enunciation;
        questionOut.Weight = questionOut.Weight;

        return CreatedAtAction(nameof(QuestionController.GetById), new { Id = quetionIn.Id }, questionOut);
    }


    //Endpoint LISTAR
    [HttpGet]
    public IActionResult List()
    {
        var question = _context.Questions.ToList();
        if (question == null)
        {
            return NotFound();                     //Se for nulo retorna erro
        }
        return Ok(question);
    }


    //Endpoint OBTER POR ID
    [HttpGet]
    [Route("{id}")]
    public IActionResult GetById(int id)
    {
        var question = _context.Questions.FirstOrDefault(x => x.Id.Equals(id));
        if (question == null)
        {
            return NotFound();
        }

        return Ok(question);
    }


    //Endpoint EXCLUIR
    [HttpDelete]
    public IActionResult Delete(int id)
    {
        var question = _context.Questions.FirstOrDefault(x => x.Id.Equals(id));
        if (question == null)
        {
            return NotFound();
        }

        _context.Questions.Remove(question);                           //Chamando método
        _context.SaveChanges();                           //Salvando

        return NoContent();
    }
}

