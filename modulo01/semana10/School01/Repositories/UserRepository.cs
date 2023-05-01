using School.Models;
using School01.Context;
using School01.Repositories.Interfaces;


namespace School01.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly School01Context _context;

        public UserRepository(School01Context context)
        {
            _context = context;
        }


        public void Create(User User)
        {
            _context.Users.Add(User);
            _context.SaveChanges();
        }


        public List<User> List()
        {
            return _context.Users.ToList();
        }


        public User? GetById(int id)
        {
            return _context.Users.FirstOrDefault(x => x.Id.Equals(id));
        }


        public void Update(User User)
        {
            _context.Users.Update(User);
            _context.SaveChanges();
        }


        public void Delete(int id)
        {
            var User = GetById(id);
            _context.Users.Remove(User);
            _context.SaveChanges();

        }
    }
}
