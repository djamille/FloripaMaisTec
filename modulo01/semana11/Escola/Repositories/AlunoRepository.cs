using Escola.Context;
using Escola.Models;
using Escola.Repositories.Interface;

namespace Escola.Repositories
{
    public class AlunoRepository : IAlunoRepository
    {
        private readonly EscolaContext _context;


        public AlunoRepository(EscolaContext context)
        {
            _context = context;
        }


        public void Create(Aluno aluno)
        {
            _context.Alunos.Add(aluno);
            _context.SaveChanges();
        }


        public List<Aluno> List()
        {
            return _context.Alunos.ToList();
        }


        public Aluno? GetById(int Cod)
        {
            return _context.Alunos.FirstOrDefault(x => x.Cod.Equals(Cod));
        }


        public void Update(Aluno aluno)
        {
            _context.Alunos.Update(aluno);
            _context.SaveChanges();
        }


        public void Delete(int Cod)
        {
            var aluno = GetById(Cod);
            _context.Alunos.Remove(aluno);
            _context.SaveChanges();

        }
    }
}
