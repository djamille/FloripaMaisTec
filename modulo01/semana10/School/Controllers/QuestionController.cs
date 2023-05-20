using Microsoft.AspNetCore.Mvc;
using School.Models;
using School.Context;
using School.Dtos;

namespace School.Controllers;


//[M1S10] Ex 09 - Crie endpoints da classe Question
[ApiController]
[Route("[controller]")]
public class QuestionController : ControllerBase
{
    private readonly SchoolContext _context;


    public QuestionController(SchoolContext context)
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
    [Route("{id}")]
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

        return CreatedAtAction(nameof(AnswerController.Get), new { id = quetionIn.Id }, questionOut);
    }


    //Endpoint LISTAR
    [HttpGet]
    public IActionResult Get()
    {
        var question = _context.Disciplines.ToList();
        if (question == null)
        {
            return NotFound();                     //Se for nulo retorna erro
        }
        return Ok(question);
    }


    //Endpoint OBTER POR ID
    [HttpGet]
    [Route("{id}")]
    public IActionResult Get(int Id)
    {
        var question = _context.Questions.FirstOrDefault(x => x.Id.Equals(Id));

        if (question == null)
        {
            return NotFound();
        }

        return Ok(question);
    }


    //Endpoint EXCLUIR
    [HttpDelete]
    [Route("{id}")]
    public IActionResult DeleteDiscipline(int Id)
    {
        var question = _context.Questions.FirstOrDefault(x => x.Id.Equals(Id));

        if (question == null)
        {
            return NotFound();
        }

        _context.Questions.Remove(question);                           //Chamando método
        _context.SaveChanges();                           //Salvando

        return NoContent();
    }
}
/*
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
}*/

