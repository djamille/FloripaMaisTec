using School.Models;

namespace School.Repositories.Interfaces
{
    public interface IStudentRepository
    {
        void Create(Student Student);
        List<Student> List();
        Student? GetById(int id);
        void Update(Student Student);
        void Delete(int id);
    }    
}
