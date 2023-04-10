using FluentValidation;
using System.Reflection.Metadata;
using School.Context;
using School.Models;
using School.Repositories.Interfaces;
using School.Dtos;
using SchoolContext = School.Context.SchoolContext;

namespace School.Repositories;

public class AnswerRepository : IAnswerRepository
{
    private readonly SchoolContext _context;

    public AnswerRepository(SchoolContext context)
    {
        _context = context;
    }


    public void Create(Answer Answer)
    {
        _context.Answers.Add(Answer);
        _context.SaveChanges();
    }


    public List<Answer> List()
    {
        return _context.Answers.ToList();
    }


    public Answer? GetById(int id)
    {
        return _context.Answers.FirstOrDefault(x => x.Id.Equals(id));
    }


    public void Update(Answer Answer)
    {
        _context.Answers.Update(Answer);
        _context.SaveChanges();
    }


    public void Delete(int id)
    {
        var answer = GetById(id);
        _context.Answers.Remove(answer);
        _context.SaveChanges();

    }

}
