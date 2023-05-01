using School01.Context;
using School.Models;
using School.Repositories.Interfaces;

namespace School.Repositories;

public class DisciplineRepository : IDisciplineRepository
{
    private readonly School01Context _context;

    public DisciplineRepository(School01Context context)
    {
        _context = context;
    }


    public void Create(Discipline Discipline)
    {
        _context.Disciplines.Add(Discipline);
        _context.SaveChanges();
    }


    public List<Discipline> List()
    {
        return _context.Disciplines.ToList();
    }


    public Discipline? GetById(int id)
    {
        return _context.Disciplines.FirstOrDefault(x => x.Id.Equals(id));
    }


    public void Update(Discipline Discipline)
    {
        _context.Disciplines.Update(Discipline);
        _context.SaveChanges();
    }


    public void Delete(int id)
    {
        var discipline = GetById(id);
        _context.Disciplines.Remove(discipline);
        _context.SaveChanges();

    }

}
