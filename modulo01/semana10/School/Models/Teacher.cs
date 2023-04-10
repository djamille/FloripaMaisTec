using System.IO;

namespace School.Models
{
    public class Teacher             //Exercicio 2 M1S10 - Crie classes de model
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Department { get; set; }


        public virtual User User { get; set; }
        public virtual ICollection<Discipline> Disciplines { get; set; }
    }
}
