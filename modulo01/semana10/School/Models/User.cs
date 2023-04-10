namespace School.Models
{
    public class User             //Exercicio 2 M1S10 - Crie classes de model
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int CPF { get; set; }
        public string Password { get; set; }


        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Teacher> Teachers { get; set; }

    }
}
