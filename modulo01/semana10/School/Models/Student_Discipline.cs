using System.IO;

namespace School.Models
{
    public class Student_Discipline
    {
        public int Id { get; set; }
        public int DisciplineId { get; set; }
        public int StudentId { get; set; }


        public virtual Discipline Discipline { get; set; }
        public virtual Student Student { get; set; }
    }
}