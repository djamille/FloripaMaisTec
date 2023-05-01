using Microsoft.AspNetCore.Mvc;
using School.Models;
using School01.Context;
using School01.Dtos;

namespace School.Controllers;


//[M1S10] Ex 08 - Crie endpoints da classe Quiz
[ApiController]
[Route("[controller]")]
public class QuizController : ControllerBase
{
    private readonly School01Context _context;


    public QuizController(School01Context context)
    {
        _context = context;
    }


    //Endpoint CRIAR
    [HttpPost]
    public ActionResult Create([FromBody] CreateQuizDto createQuizDto)
    {
        var quizIn = new Quiz();
        quizIn.DisciplineId = createQuizDto.DisciplineId;
        quizIn.Title = createQuizDto.Title;
        quizIn.DateClose = createQuizDto.DateClose;
        quizIn.DateOpen = createQuizDto.DateOpen;


        _context.Quizzes.Add(quizIn);
        _context.SaveChanges();

        var quizOut = new OutQuizDto();
        quizOut.Id = quizIn.Id;
        quizOut.DisciplineId = quizIn.DisciplineId;
        quizOut.Title = quizIn.Title;
        quizOut.DateClose = quizIn.DateClose;
        quizOut.DateOpen = quizIn.DateOpen;

        return Ok(quizOut);
    }


    //Endpoint ATUALIZAR
    [HttpPut]
    public IActionResult Update(int Id, [FromBody] AlterQuizDto quizAlter)
    {
        var quizIn = _context.Quizzes.FirstOrDefault(x => x.Id.Equals(Id)); ;

        if (quizIn == null)
        {
            return NotFound();
        }

        quizIn.DisciplineId = quizAlter.DisciplineId;
        quizIn.Title = quizAlter.Title;
        quizIn.DateClose = quizAlter.DateClose;
        quizIn.DateOpen = quizAlter.DateOpen;


        _context.Quizzes.Update(quizIn);
        _context.SaveChanges();

        var quizOut = new OutQuizDto();
        quizOut.Id = quizIn.Id;
        quizOut.DisciplineId = quizIn.DisciplineId;
        quizOut.Title = quizIn.Title;
        quizOut.DateClose = quizIn.DateClose;
        quizOut.DateOpen = quizIn.DateOpen;

        return CreatedAtAction(nameof(QuizController.GetById), new { Id = quizIn.Id }, quizOut);
    }


    //Endpoint LISTAR
    [HttpGet]
    public IActionResult List()
    {
        var quiz = _context.Quizzes.ToList();
        if (quiz == null)
        {
            return NotFound();                     //Se for nulo retorna erro
        }
        return Ok(quiz);
    }


    //Endpoint OBTER POR ID
    [HttpGet]
    [Route("{id}")]
    public IActionResult GetById(int id)
    {
        var quiz = _context.Quizzes.FirstOrDefault(x => x.Id.Equals(id));
        if (quiz == null)
        {
            return NotFound();
        }

        return Ok(quiz);
    }


    //Endpoint EXCLUIR
    [HttpDelete]
    public IActionResult Delete(int id)
    {
        var quiz = _context.Quizzes.FirstOrDefault(x => x.Id.Equals(id));
        if (quiz == null)
        {
            return NotFound();
        }

        _context.Quizzes.Remove(quiz);                           //Chamando método
        _context.SaveChanges();                           //Salvando

        return NoContent();
    }
}