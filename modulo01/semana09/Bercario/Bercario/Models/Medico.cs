
namespace Bercario.Models
{    
    public class Medico
    {   
        public int Id { get; set; }
        public string CRM { get; set; }
        public string Nome { get; set; }
        public string Celular { get; set; }
        public string Especialidade { get; set; }

        //propriedade de navegação
        public virtual ICollection<Parto> Partos { get; set; }

    }
}
