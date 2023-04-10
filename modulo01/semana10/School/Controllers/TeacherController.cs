using Microsoft.AspNetCore.Mvc;
using School.Models;
using School.Repositories;
using School.Repositories.Interfaces;
using static School.Dtos.TeacherDto;

namespace School.Controllers;


//[M1S10] Ex 05 - Crie endpoints da classe Teacher
[ApiController]
[Route("[controller]")]
public class TeacherController : ControllerBase
{
    private readonly ITeacherRepository _teacherRepository;


    public TeacherController(ITeacherRepository TeacherRepository)
    {
        _teacherRepository = TeacherRepository;
    }


    //Endpoint CRIAR
    [HttpPost]
    public ActionResult<Teacher> Create(Teacher teacher)
    {
        _teacherRepository.Create(teacher);

        return CreatedAtAction(nameof(TeacherController), new { id = teacher.Id }, teacher);
    }


    //Endpoint ATUALIZAR
    [HttpPut]
    [Route("{id}")]
    public IActionResult Update(int id, [FromBody] AlterTeacherDto TeacherDto)
    {
        var teacher = _teacherRepository.GetById(id);

        if (teacher == null)
            return NotFound();

        teacher.UserId = TeacherDto.UserId;
        teacher.Department = TeacherDto.Department;

        return CreatedAtAction(nameof(TeacherController.Get), new { id = teacher.Id }, teacher);
    }


    //Endpoint LISTAR
    [HttpGet]
    public IActionResult Get()
    {
        var teacher = _teacherRepository.List();
        return Ok(teacher);
    }


    //Endpoint OBTER POR ID
    [HttpGet]
    [Route("{id}")]
    public IActionResult Get(int id)
    {
        var teacher = _teacherRepository.GetById(id);

        if (teacher == null)
            return NotFound();

        return Ok(teacher);
    }


    //Endpoint EXCLUIR
    [HttpDelete]
    [Route("{id}")]
    public IActionResult DeleteATeacher(int id)
    {
        var teacher = _teacherRepository.GetById(id);
        if (teacher == null)
        {
            return NotFound();
        }

        _teacherRepository.Delete(id);

        return NoContent();
    }
}
