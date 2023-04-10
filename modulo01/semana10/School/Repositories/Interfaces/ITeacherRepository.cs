using School.Models;

namespace School.Repositories.Interfaces
{
    public interface ITeacherRepository
    {
        void Create(Teacher Teacher);
        List<Teacher> List();
        Teacher? GetById(int id);
        void Update(Teacher Teacher);
        void Delete(int id);
    }
}

