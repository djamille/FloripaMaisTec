using Microsoft.AspNetCore.Mvc;
using School.Models;
using School01.Context;
using School01.Dtos;

namespace School.Controllers;


//[M1S10] Ex 06 - Crie endpoints da classe Discipline
[ApiController]
[Route("[controller]")]
public class DisciplineController : ControllerBase
{
    private readonly School01Context _context;


    public DisciplineController(School01Context context)
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
    public IActionResult Update(int Id, [FromBody] AlterDisciplineDto disciplineAlter)
    {
        var disciplineIn = _context.Disciplines.FirstOrDefault(x => x.Id.Equals(Id));
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

        return CreatedAtAction(nameof(DisciplineController.List), new { Id = disciplineIn.Id }, disciplineOut);
    }


    //Endpoint LISTAR
    [HttpGet]
    public IActionResult List()
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
    public IActionResult GetById(int id)
    {
        var discipline = _context.Disciplines.FirstOrDefault(x => x.Id.Equals(id));
        if (discipline == null)
        {
            return NotFound();
        }

        return Ok(discipline);
    }


    //Endpoint EXCLUIR
    [HttpDelete]
    public IActionResult Delete(int id)
    {
        var discipline = _context.Disciplines.FirstOrDefault(x => x.Id.Equals(id));
        if (discipline == null)
        {
            return NotFound();
        }

        _context.Disciplines.Remove(discipline);                           //Chamando método
        _context.SaveChanges();                           //Salvando

        return NoContent();
    }
}