using Microsoft.AspNetCore.Mvc;
using School01.Context;
using School.Models;
using School01.Dtos;

namespace School.Controllers;


//[M1S10] Ex 05 - Crie endpoints da classe Teacher
[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly School01Context _context;


    public UserController(School01Context context)
    {
        _context = context;
    }


    //Endpoint CRIAR
    [HttpPost]
    public ActionResult Create([FromBody] CreateUserDto createUserDto)
    {
        var userIn = new User();
        userIn.Name = createUserDto.Name;
        userIn.Email = createUserDto.Email;
        userIn.CPF = createUserDto.CPF;
        userIn.Password = createUserDto.Password;

        _context.Users.Add(userIn);
        _context.SaveChanges();

        var userOut = new OutUserDto();
        userOut.Id = userIn.Id;
        userOut.Name = userIn.Name;
        userOut.Email = userIn.Email;
        userOut.CPF = userIn.CPF;
        userOut.Password = userIn.Password;

        return Ok(userOut);
    }


    //Endpoint ATUALIZAR
    [HttpPut]
    public IActionResult Update(int Id, [FromBody] AlterUserDto alterUserDto)
    {
        var userIn = _context.Users.FirstOrDefault(x => x.Id.Equals(Id));
        if (userIn == null)
        {
            return NotFound();
        }

        userIn.Email = alterUserDto.Email;
        userIn.Password = alterUserDto.Password;

        _context.Users.Update(userIn);
        _context.SaveChanges();

        var userOut = new OutUserDto();
        userOut.Id = userIn.Id;
        userOut.Name = userIn.Name;
        userOut.Email = userIn.Email;
        userOut.CPF = userIn.CPF;
        userOut.Password = userIn.Password;


        return CreatedAtAction(nameof(UserController.GetById), new { id = userIn.Id }, userOut);
    }


    //Endpoint LISTAR
    [HttpGet]
    public IActionResult List()
    {
        var userIn = _context.Users.ToList();
        if (userIn == null)
        {
            return NotFound();                     //Se for nulo retorna erro
        }
        return Ok(userIn);
    }


    //Endpoint OBTER POR ID
    [HttpGet]
    [Route("{id}")]
    public IActionResult GetById(int id)
    {
        var userIn = _context.Users.FirstOrDefault(x => x.Id.Equals(id));
        if (userIn == null)
        {
            return NotFound();
        }

        return Ok(userIn);
    }


    //Endpoint EXCLUIR
    [HttpDelete]
    public IActionResult Delete(int id)
    {
        var userIn = _context.Users.FirstOrDefault(x => x.Id.Equals(id));
        if (userIn == null)
        {
            return NotFound();
        }

        _context.Users.Remove(userIn);                           //Chamando método
        _context.SaveChanges();                           //Salvando

        return NoContent();
    }
}