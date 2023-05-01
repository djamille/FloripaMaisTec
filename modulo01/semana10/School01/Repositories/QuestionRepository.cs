using School01.Context;
using School.Models;
using School.Repositories.Interfaces;


namespace School.Repositories;

public class QuestionRepository : IQuestionRepository
{
    private readonly School01Context _context;

    public QuestionRepository(School01Context context)
    {
        _context = context;
    }


    public void Create(Question Question)
    {
        _context.Questions.Add(Question);
        _context.SaveChanges();
    }


    public List<Question> List()
    {
        return _context.Questions.ToList();
    }


    public Question? GetById(int id)
    {
        return _context.Questions.FirstOrDefault(x => x.Id.Equals(id));
    }


    public void Update(Question Question)
    {
        _context.Questions.Update(Question);
        _context.SaveChanges();
    }


    public void Delete(int id)
    {
        var question = GetById(id);
        _context.Questions.Remove(question);
        _context.SaveChanges();

    }

}
