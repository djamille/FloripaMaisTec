using Escola.Models;
using Escola.Context;
using Escola.Models;
using Escola.Repositories.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Escola.Controllers;

[ApiController]
[Route("[controller]")]
public class AlunoController : ControllerBase
{
    private readonly EscolaContext _context;


    public AlunoController(EscolaContext context)            //Injeção de dependencia
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult Get()
    {
        var alunos = _context.Alunos.ToList();
        return Ok(alunos);
    }


    //Endpoint CRIAR
    [HttpPost]
    public IActionResult Create([FromBody] Aluno Aluno)
    {
        _context.Alunos.Add(Aluno);
        _context.SaveChanges();

        return CreatedAtAction(nameof(AlunoController.Get), new { Cod = Aluno.Cod }, Aluno);
    }
}
