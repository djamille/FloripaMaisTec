using Microsoft.AspNetCore.Mvc;
using School.Repositories;
using School.Repositories.Interfaces;
using static School.Dtos.StudentDto;
using School.Models;

namespace School.Controllers;


//[M1S10] Ex 04 - Crie endpoints da classe Student
[ApiController]
[Route("[controller]")]
public class StudentController : ControllerBase
{
    private readonly IStudentRepository _studentRepository;


    public StudentController(IStudentRepository StudentRepository)
    {
        _studentRepository = StudentRepository;
    }


    //Endpoint CRIAR
    [HttpPost]
    public ActionResult<Student> Create(Student student)
    {
        _studentRepository.Create(student);

        return CreatedAtAction(nameof(StudentController), new { id = student.Id }, student);
    }


    //Endpoint ATUALIZAR
    [HttpPut]
    [Route("{id}")]
    public IActionResult Update(int id, [FromBody] AlterStudentDto StudentDto)
    {
        var student = _studentRepository.GetById(id);

        if (student == null)
            return NotFound();

        student.UserId = StudentDto.UserId;
        student.Period = StudentDto.Period;
        student.RA = StudentDto.RA;

        return CreatedAtAction(nameof(StudentController.Get), new { id = student.Id }, student);
    }


    //Endpoint LISTAR
    [HttpGet]
    public IActionResult Get()
    {
        var student = _studentRepository.List();
        return Ok(student);
    }


    //Endpoint OBTER POR ID
    [HttpGet]
    [Route("{id}")]
    public IActionResult Get(int id)
    {
        var student = _studentRepository.GetById(id);

        if (student == null)
            return NotFound();

        return Ok(student);
    }


    //Endpoint EXCLUIR
    [HttpDelete]
    [Route("{id}")]
    public IActionResult DeleteStudent(int id)
    {
        var student = _studentRepository.GetById(id);
        if (student == null)
        {
            return NotFound();
        }

        _studentRepository.Delete(id);

        return NoContent();
    }
}
