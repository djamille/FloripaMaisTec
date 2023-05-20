using Microsoft.AspNetCore.Mvc;
using School.Models;
using School.Context;
using School.Dtos;

namespace School.Controllers;


//[M1S10] Ex 06 - Crie endpoints da classe Discipline
[ApiController]
[Route("[controller]")]
public class DisciplineController : ControllerBase
{
    private readonly SchoolContext _context;


    public DisciplineController(SchoolContext context)
    {
        _context = context;
    }


    //Endpoint CRIAR
    [HttpPost]
    public ActionResult Create([FromBody] CreateDisciplineDto createDisciplineDto)
    {
        var disciplineIn = new Discipline();
        disciplineIn.TeacherId = createDisciplineDto.TeacherId;
        disciplineIn.NameDiscipline = createDisciplineDto.NameDiscipline;
        

        _context.Disciplines.Add(disciplineIn);
        _context.SaveChanges();

        var disciplineOut = new OutDisciplineDto();
        disciplineOut.Id = disciplineIn.Id;
        disciplineOut.TeacherId = disciplineIn.TeacherId;
        disciplineOut.NameDiscipline = disciplineIn.NameDiscipline;
        
        return Ok(disciplineOut);
    }


    //Endpoint ATUALIZAR
    [HttpPut]
    [Route("{id}")]
    public IActionResult Update(int Id, [FromBody] AlterDisciplineDto disciplineAlter)
    {
        var disciplineIn = _context.Disciplines.FirstOrDefault(x => x.Id.Equals(Id)); ;

        if (disciplineIn == null)
        {
            return NotFound();
        }

        disciplineIn.TeacherId = disciplineAlter.TeacherId;
        

        _context.Disciplines.Update(disciplineIn);
        _context.SaveChanges();

        var disciplineOut = new OutDisciplineDto();
        disciplineOut.Id = disciplineIn.Id;
        disciplineOut.TeacherId = disciplineIn.TeacherId;
        disciplineOut.NameDiscipline = disciplineIn.NameDiscipline;

        return CreatedAtAction(nameof(AnswerController.Get), new { id = disciplineIn.Id }, disciplineOut);
    }


    //Endpoint LISTAR
    [HttpGet]
    public IActionResult Get()
    {
        var discipline = _context.Disciplines.ToList();
        if (discipline == null)
        {
            return NotFound();                     //Se for nulo retorna erro
        }
        return Ok(discipline);
    }


    //Endpoint OBTER POR ID
    [HttpGet]
    [Route("{id}")]
    public IActionResult Get(int Id)
    {
        var discipline = _context.Disciplines.FirstOrDefault(x => x.Id.Equals(Id));

        if (discipline == null)
        {
            return NotFound();
        }

        return Ok(discipline);
    }


    //Endpoint EXCLUIR
    [HttpDelete]
    [Route("{id}")]
    public IActionResult DeleteDiscipline(int Id)
    {
        var discipline = _context.Disciplines.FirstOrDefault(x => x.Id.Equals(Id));

        if (discipline == null)
        {
            return NotFound();
        }

        _context.Disciplines.Remove(discipline);                           //Chamando método
        _context.SaveChanges();                           //Salvando

        return NoContent();
    }
}

    /*
    //Endpoint CRIAR
    [HttpPost]
    public ActionResult<Discipline> Create(Discipline discipline)
    {
        _disciplineRepository.Create(discipline);

        return CreatedAtAction(nameof(DisciplineController), new { id = discipline.Id }, discipline);
    }


    //Endpoint ATUALIZAR
    [HttpPut]
    [Route("{id}")]
    public IActionResult Update(int id, [FromBody] AlterDisciplineDto DisciplineDto)
    {
        var discipline = _disciplineRepository.GetById(id);

        if (discipline == null)
            return NotFound();

        discipline.TeacherId = DisciplineDto.TeacherId;
        discipline.NameDiscipline = DisciplineDto.NameDiscipline;

        return CreatedAtAction(nameof(DisciplineController.Get), new { id = discipline.Id }, discipline);
    }


    //Endpoint LISTAR
    [HttpGet]
    public IActionResult Get()
    {
        var discipline = _disciplineRepository.List();
        return Ok(discipline);
    }


    //Endpoint OBTER POR ID
    [HttpGet]
    [Route("{id}")]
    public IActionResult Get(int id)
    {
        var discipline = _disciplineRepository.GetById(id);

        if (discipline == null)
            return NotFound();

        return Ok(discipline);
    }

        
    //Endpoint EXCLUIR
    [HttpDelete]
    [Route("{id}")]
    public IActionResult DeleteAnswer(int id)
    {
        var answer = _disciplineRepository.GetById(id);
        if (answer == null)
        {
            return NotFound();
        }

        _disciplineRepository.Delete(id);

        return NoContent();
    }
    */

