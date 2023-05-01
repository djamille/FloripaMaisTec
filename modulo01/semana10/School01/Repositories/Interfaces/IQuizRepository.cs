using School.Models;

namespace School.Repositories.Interfaces
{
    public interface IQuizRepository
    {
        void Create(Quiz Quiz);
        List<Quiz> List();
        Quiz? GetById(int id);
        void Update(Quiz Quiz);
        void Delete(int id);
    }
}
