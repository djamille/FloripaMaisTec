using School.Models;

namespace School01.Repositories.Interfaces
{
    public interface IUserRepository
    {
        void Create(User User);
        List<User> List();
        User? GetById(int id);
        void Update(User User);
        void Delete(int id);
        
    }
}
