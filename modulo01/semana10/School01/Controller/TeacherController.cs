using Microsoft.AspNetCore.Mvc;
using School01.Context;
using School.Models;
using School01.Dtos;

namespace School.Controllers;


//[M1S10] Ex 05 - Crie endpoints da classe Teacher
[ApiController]
[Route("[controller]")]
public class TeacherController : ControllerBase
{
    private readonly School01Context _context;


    public TeacherController(School01Context context)
    {
        _context = context;
    }


    //Endpoint CRIAR
    [HttpPost]
    public ActionResult Create([FromBody] CreateTeacherDto createTeacherDto)
    {
        var teacherIn = new Teacher();
        teacherIn.UserId = createTeacherDto.UserId;
        teacherIn.Department = createTeacherDto.Department;
        
        _context.Teachers.Add(teacherIn);
        _context.SaveChanges();

        var teacherOut = new OutTeacherDto();
        teacherOut.Id = teacherIn.Id;
        teacherOut.UserId = teacherIn.UserId;
        teacherOut.Department = teacherIn.Department;


        return Ok(teacherOut);
    }


    //Endpoint ATUALIZAR
    [HttpPut]
    public IActionResult Update(int Id, [FromBody] AlterTeacherDto alterTeacherDto)
    {
        var teacherIn = _context.Teachers.FirstOrDefault(x => x.Id.Equals(Id));
        if (teacherIn == null)
        {
            return NotFound();
        }

        teacherIn.Department = alterTeacherDto.Department;

        _context.Teachers.Update(teacherIn);
        _context.SaveChanges();

        var teacherOut = new OutTeacherDto();
        teacherOut.Id = teacherIn.Id;
        teacherOut.UserId = teacherIn.UserId;
        teacherOut.Department = teacherIn.Department;
        

        return CreatedAtAction(nameof(TeacherController.GetById), new { Id = teacherIn.Id }, teacherOut);
    }


    //Endpoint LISTAR
    [HttpGet]
    public IActionResult List()
    {
        var teacherIn = _context.Teachers.ToList();
        if (teacherIn == null)
        {
            return NotFound();                     //Se for nulo retorna erro
        }
        return Ok(teacherIn);
    }


    //Endpoint OBTER POR ID
    [HttpGet]
    [Route("{id}")]
    public IActionResult GetById(int id)
    {
        var teacherIn = _context.Teachers.First(x => x.Id.Equals(id));
        if (teacherIn == null)
        {
            return NotFound();
        }

        return Ok(teacherIn);
    }


    //Endpoint EXCLUIR
    [HttpDelete]
    public IActionResult Delete(int id)
    {
        var teacherIn = _context.Teachers.FirstOrDefault(x => x.Id.Equals(id));
        if (teacherIn == null)
        {
            return NotFound();
        }

        _context.Teachers.Remove(teacherIn);                           //Chamando método
        _context.SaveChanges();                           //Salvando

        return NoContent();
    }
}