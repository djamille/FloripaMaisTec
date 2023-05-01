using Microsoft.AspNetCore.Mvc;
using School01.Context;
using School.Models;
using School01.Dtos;

namespace School.Controllers;

//[M1S10] Ex 07 - Crie endpoints da classe Answer
[ApiController]
[Route("[controller]")]
public class Student_DisciplineController : ControllerBase
{
    private readonly School01Context _context;


    public Student_DisciplineController(School01Context context)
    {
        _context = context;
    }


    //Endpoint CRIAR
    [HttpPost]
    public ActionResult Create([FromBody] CreateStudent_DisciplineDto createStudent_DisciplineDto)
    {
        var studentDisc = new Student_Discipline();
        studentDisc.DisciplineId = createStudent_DisciplineDto.DisciplineId;
        studentDisc.StudentId = createStudent_DisciplineDto.StudentId;
        
        _context.Students_Disciplines.Add(studentDisc);
        _context.SaveChanges();

        var studentDiscOut = new OutStudent_DisciplineDto();
        studentDiscOut.Id = studentDisc.Id;
        studentDiscOut.DisciplineId = studentDisc.DisciplineId;
        studentDiscOut.StudentId = studentDisc.StudentId;
        

        return Ok(studentDiscOut);
    }


    //Endpoint ATUALIZAR
    [HttpPut]
    public IActionResult Update(int Id, [FromBody] AlterStudent_DisciplineDto alterStudent_DisciplineDto)
    {
        var studentDisc = _context.Students_Disciplines.FirstOrDefault(x => x.Id.Equals(Id)); ;

        if (studentDisc == null)
        {
            return NotFound();
        }

        studentDisc.DisciplineId = alterStudent_DisciplineDto.DisciplineId;
        studentDisc.StudentId = alterStudent_DisciplineDto.StudentId;


        _context.Students_Disciplines.Update(studentDisc);
        _context.SaveChanges();

        var studentDiscOut = new OutStudent_DisciplineDto();
        studentDiscOut.Id = studentDisc.Id;
        studentDiscOut.DisciplineId = studentDisc.DisciplineId;
        studentDiscOut.StudentId = studentDisc.StudentId;

        return CreatedAtAction(nameof(Student_DisciplineController.GetById), new { Id = studentDisc.Id }, studentDiscOut);
    }


    //Endpoint LISTAR
    [HttpGet]
    public IActionResult List()
    {
        var studentDisc = _context.Students_Disciplines.ToList();
        if (studentDisc == null)
        {
            return NotFound();                     //Se for nulo retorna erro
        }
        return Ok(studentDisc);
    }


    //Endpoint OBTER POR ID
    [HttpGet]
    [Route("{id}")]
    public IActionResult GetById(int id)
    {
        var studentDisc = _context.Students_Disciplines.FirstOrDefault(x => x.Id.Equals(id));
        if (studentDisc == null)
        {
            return NotFound();
        }

        return Ok(studentDisc);
    }


    //Endpoint EXCLUIR
    [HttpDelete]
    public IActionResult Delete(int id)
    {
        var studentDisc = _context.Students_Disciplines.FirstOrDefault(x => x.Id.Equals(id));
        if (studentDisc == null)
        {
            return NotFound();
        }

        _context.Students_Disciplines.Remove(studentDisc);                           //Chamando método
        _context.SaveChanges();                           //Salvando

        return NoContent();
    }
}