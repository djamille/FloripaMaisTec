using Microsoft.AspNetCore.Mvc;
using School.Models;
using School.Dtos;
using School.Context;

namespace School.Controllers;


//[M1S10] Ex 08 - Crie endpoints da classe Quiz
[ApiController]
[Route("[controller]")]
public class QuizController : ControllerBase
{
    private readonly SchoolContext _context;


    public QuizController(SchoolContext context)
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
    [Route("{id}")]
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

        return CreatedAtAction(nameof(AnswerController.Get), new { id = quizIn.Id }, quizOut);
    }


    //Endpoint LISTAR
    [HttpGet]
    public IActionResult Get()
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
    public IActionResult Get(int Id)
    {
        var quiz = _context.Quizzes.FirstOrDefault(x => x.Id.Equals(Id));

        if (quiz == null)
        {
            return NotFound();
        }

        return Ok(quiz);
    }


    //Endpoint EXCLUIR
    [HttpDelete]
    [Route("{id}")]
    public IActionResult DeleteDiscipline(int Id)
    {
        var quiz = _context.Quizzes.FirstOrDefault(x => x.Id.Equals(Id));

        if (quiz == null)
        {
            return NotFound();
        }

        _context.Quizzes.Remove(quiz);                           //Chamando método
        _context.SaveChanges();                           //Salvando

        return NoContent();
    }
}
/*private readonly IQuizRepository _quizRepository;


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
*/