using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace M1S09.Models
{
    [Table("Enderecos")]
    public class Endereco
    {
        [Key]
        [Column("Id")]
        [Required]
        public int Id { get; set; }

        [Column("Numero")]
        [Required]
        public int Numero { get; set; }

        [Column("Logadouro")]
        [StringLength(200)]
        [Required]
        public string Logadouro { get; set; }

        [Column("Complemento")]
        [StringLength(100)]
        [Required]
        public string Complemento { get; set; }

        [Column("Bairro")]
        [StringLength(100)]
        [Required]
        public string Bairro { get; set; }

        [Column("Cidade")]
        [StringLength(100)]
        [Required]
        public string Cidade { get; set; }

        //propriedade virtual
        public virtual Cliente Cliente { get; set; }
    }
}
