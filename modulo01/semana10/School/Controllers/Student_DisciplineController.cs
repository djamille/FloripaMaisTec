using Microsoft.AspNetCore.Mvc;
using School.Context;
using School.Dtos;
using School.Models;

namespace School.Controllers;

//[M1S10] Ex 07 - Crie endpoints da classe Answer
[ApiController]
[Route("[controller]")]
public class Student_DisciplineController : ControllerBase
{
    private readonly SchoolContext _context;


    public Student_DisciplineController(SchoolContext context)
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
    [Route("{id}")]
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

        return CreatedAtAction(nameof(AnswerController.Get), new { id = studentDisc.Id }, studentDiscOut);
    }


    //Endpoint LISTAR
    [HttpGet]
    public IActionResult Get()
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
    public IActionResult Get(int Id)
    {
        var studentDisc = _context.Students_Disciplines.FirstOrDefault(x => x.Id.Equals(Id));

        if (studentDisc == null)
        {
            return NotFound();
        }

        return Ok(studentDisc);
    }


    //Endpoint EXCLUIR
    [HttpDelete]
    [Route("{id}")]
    public IActionResult DeleteDiscipline(int Id)
    {
        var studentDisc = _context.Students_Disciplines.FirstOrDefault(x => x.Id.Equals(Id));

        if (studentDisc == null)
        {
            return NotFound();
        }

        _context.Students_Disciplines.Remove(studentDisc);                           //Chamando método
        _context.SaveChanges();                           //Salvando

        return NoContent();
    }
}
/*private readonly IStudent_DisciplineRepository _student_DisciplineRepository;


public Student_DisciplineController(IStudent_DisciplineRepository Student_DisciplineRepository)
{
    _student_DisciplineRepository = Student_DisciplineRepository;
}


//Endpoint CRIAR
[HttpPost]
public ActionResult<Student_Discipline> Create(Student_Discipline student_discipline)
{
    _student_DisciplineRepository.Create(student_discipline);

    return CreatedAtAction(nameof(Student_DisciplineController), new { id = student_discipline.Id }, student_discipline);
}


//Endpoint LISTAR
[HttpGet]
public IActionResult Get()
{
    var student_Discipline = _student_DisciplineRepository.List();
    return Ok(student_Discipline);
}


//Endpoint OBTER POR ID
[HttpGet]
[Route("{id}")]
public IActionResult Get(int id)
{
    var student_Discipline = _student_DisciplineRepository.GetById(id);

    if (student_Discipline == null)
        return NotFound();

    return Ok(student_Discipline);
}


//Endpoint ATUALIZAR
[HttpPut]
[Route("{id}")]
public IActionResult Update(int id, [FromBody] AlterStudent_DisciplineDto Student_DisciplineDto)
{
    var student_Discipline = _student_DisciplineRepository.GetById(id);

    if (student_Discipline == null)
        return NotFound();

    student_Discipline.StudentId = Student_DisciplineDto.StudentId;
    student_Discipline.DisciplineId = Student_DisciplineDto.DisciplineId;

    return CreatedAtAction(nameof(Student_DisciplineController.Get), new { id = student_Discipline.Id }, student_Discipline);
}


//Endpoint EXCLUIR
[HttpDelete]
[Route("{id}")]
public IActionResult DeleteStudent_Discipline(int id)
{
    var student_Discipline = _student_DisciplineRepository.GetById(id);
    if (student_Discipline == null)
    {
        return NotFound();
    }

    _student_DisciplineRepository.Delete(id);

    return NoContent();
}
*/
