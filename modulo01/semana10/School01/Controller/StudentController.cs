using Microsoft.AspNetCore.Mvc;
using School.Models;
using School01.Context;
using School01.Dtos;

namespace School.Controllers;


//[M1S10] Ex 04 - Crie endpoints da classe Student
[ApiController]
[Route("[controller]")]
public class StudentController : ControllerBase
{
    private readonly School01Context _context;


    public StudentController(School01Context context)
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

        return CreatedAtAction(nameof(StudentController.GetById), new { Id = studentIn.Id }, studentOut);
    }


    //Endpoint LISTAR
    [HttpGet]
    public IActionResult List()
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
    public IActionResult GetById(int id)
    {
        var studentIn = _context.Students.FirstOrDefault(x => x.Id.Equals(id));
        if (studentIn == null)
        {
            return NotFound();
        }

        return Ok(studentIn);
    }


    //Endpoint EXCLUIR
    [HttpDelete]
    public IActionResult Delete(int id)
    {
        var studentIn = _context.Students.FirstOrDefault(x => x.Id.Equals(id));
        if (studentIn == null)
        {
            return NotFound();
        }

        _context.Students.Remove(studentIn);                           //Chamando método
        _context.SaveChanges();                           //Salvando

        return NoContent();
    }
}