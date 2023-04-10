using School.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using static School.Dtos.DisciplineDto;
using School.Models;
using School.Repositories;

namespace School.Controllers;


//[M1S10] Ex 06 - Crie endpoints da classe Discipline
[ApiController]
[Route("[controller]")]
public class DisciplineController : ControllerBase
{
    private readonly IDisciplineRepository _disciplineRepository;


    public DisciplineController(IDisciplineRepository DisciplineRepository)
    {
        _disciplineRepository = DisciplineRepository;
    }


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
}
