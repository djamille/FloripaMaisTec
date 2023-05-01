using School.Models;
using School.Repositories.Interfaces;
using School01.Context;

namespace School.Repositories;

public class StudentRepository : IStudentRepository
{
    private readonly School01Context _context;

    public StudentRepository(School01Context context)
    {
        _context = context;
    }


    public void Create(Student Student)
    {
        _context.Students.Add(Student);
        _context.SaveChanges();
    }


    public List<Student> List()
    {
        return _context.Students.ToList();
    }


    public Student? GetById(int id)
    {
        return _context.Students.FirstOrDefault(x => x.Id.Equals(id));
    }


    public void Update(Student Student)
    {
        _context.Students.Update(Student);
        _context.SaveChanges();
    }


    public void Delete(int id)
    {
        var Student = GetById(id);
        _context.Students.Remove(Student);
        _context.SaveChanges();

    }
}
