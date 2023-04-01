using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace M1S09.Models
{
    [Table("Promocao")]
    public class Promocao
    {
        [Key]
        [Column("Id")]
        [Required]
        public int Id { get; set; }

        [Column("Descricao")]
        [StringLength(150)]
        [Required]
        public string Descricao { get; set; }

        [Column("DataInicio")]        
        [Required]
        public DateTime DataInicio { get; set; }

        [Column("DataTermino")]
        [Required]
        public DateTime DataTermino { get; set; }

        //propriedade publica
        public virtual ICollection<ProdutoPromocao> Produto { get; set; }
    }
}
