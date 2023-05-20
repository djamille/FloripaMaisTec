using Escola.Enums;

namespace Escola.Models
{
    public class Professor : Pessoa
    {
        public int Cod { get; set; }
        public EEstado Estado { get; set; }
        public EExperiencia Experiencia { get; set; }
        public EFormacaoAcademica Formacao { get; set; }
    }
}
