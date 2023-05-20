using Microsoft.AspNetCore.Mvc;
using School.Context;
using School.Dtos;
using School.Models;

namespace School.Controllers;


//[M1S10] Ex 05 - Crie endpoints da classe Teacher
[ApiController]
[Route("[controller]")]
public class TeacherController : ControllerBase
{
    private readonly SchoolContext _context;


    public TeacherController(SchoolContext context)
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
    [Route("{id}")]
    public IActionResult Update(int Id, [FromBody] AlterTeacherDto alterTeacherDto)
    {
        var teacherIn = _context.Teachers.FirstOrDefault(x => x.Id.Equals(Id)); ;

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
        

        return CreatedAtAction(nameof(AnswerController.Get), new { id = teacherIn.Id }, teacherOut);
    }


    //Endpoint LISTAR
    [HttpGet]
    public IActionResult Get()
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
    public IActionResult Get(int Id)
    {
        var teacherIn = _context.Teachers.FirstOrDefault(x => x.Id.Equals(Id)); ;

        if (teacherIn == null)
        {
            return NotFound();
        }

        return Ok(teacherIn);
    }


    //Endpoint EXCLUIR
    [HttpDelete]
    [Route("{id}")]
    public IActionResult DeleteAnswer(int Id)
    {
        var teacherIn = _context.Teachers.FirstOrDefault(x => x.Id.Equals(Id)); ;

        if (teacherIn == null)
        {
            return NotFound();
        }

        _context.Teachers.Remove(teacherIn);                           //Chamando método
        _context.SaveChanges();                           //Salvando

        return NoContent();
    }
}
/*private readonly ITeacherRepository _teacherRepository;


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
*/