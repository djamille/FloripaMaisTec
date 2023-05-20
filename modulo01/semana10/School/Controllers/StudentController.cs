using Microsoft.AspNetCore.Mvc;
using School.Repositories.Interfaces;
using School.Models;
using School.Context;
using School.Dtos;

namespace School.Controllers;


//[M1S10] Ex 04 - Crie endpoints da classe Student
[ApiController]
[Route("[controller]")]
public class StudentController : ControllerBase
{
    private readonly SchoolContext _context;


    public StudentController(SchoolContext context)
    {
        _context = context;
    }


    //Endpoint CRIAR
    [HttpPost]
    public ActionResult Create([FromBody] CreateStudentDto createStudentDto)
    {
        var studentIn = new Student();
        studentIn.UserId = createStudentDto.UserId;
        studentIn.Period = createStudentDto.Period;
        studentIn.RA = createStudentDto.RA;
      


        _context.Students.Add(studentIn);
        _context.SaveChanges();

        var studentOut = new OutStudentDto();
        studentOut.Id = studentIn.Id;
        studentOut.UserId = studentIn.UserId;
        studentOut.Period = studentIn.Period;
        studentOut.RA = studentIn.RA;
        
        return Ok(studentOut);
    }


    //Endpoint ATUALIZAR
    [HttpPut]
    [Route("{id}")]
    public IActionResult Update(int Id, [FromBody] AlterStudentDto alterStudentDto)
    {
        var studentIn = _context.Students.FirstOrDefault(x => x.Id.Equals(Id)); ;

        if (studentIn == null)
        {
            return NotFound();
        }

        studentIn.Period = alterStudentDto.Period;
        studentIn.RA = alterStudentDto.RA;


        _context.Students.Update(studentIn);
        _context.SaveChanges();

        var studentOut = new OutStudentDto();
        studentOut.Id = studentIn.Id;
        studentOut.UserId = studentIn.UserId;
        studentOut.Period = studentIn.Period;
        studentOut.RA = studentIn.RA;

        return CreatedAtAction(nameof(AnswerController.Get), new { id = studentIn.Id }, studentOut);
    }


    //Endpoint LISTAR
    [HttpGet]
    public IActionResult Get()
    {
        var studentIn = _context.Students.ToList();
        if (studentIn == null)
        {
            return NotFound();                     //Se for nulo retorna erro
        }
        return Ok(studentIn);
    }


    //Endpoint OBTER POR ID
    [HttpGet]
    [Route("{id}")]
    public IActionResult Get(int Id)
    {
        var studentIn = _context.Students.FirstOrDefault(x => x.Id.Equals(Id));

        if (studentIn == null)
        {
            return NotFound();
        }

        return Ok(studentIn);
    }


    //Endpoint EXCLUIR
    [HttpDelete]
    [Route("{id}")]
    public IActionResult DeleteDiscipline(int Id)
    {
        var studentIn = _context.Students.FirstOrDefault(x => x.Id.Equals(Id));

        if (studentIn == null)
        {
            return NotFound();
        }

        _context.Students.Remove(studentIn);                           //Chamando método
        _context.SaveChanges();                           //Salvando

        return NoContent();
    }
}
/*
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
}*/
