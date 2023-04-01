using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace M1S09.Models
{
    [Table("Produto")]
    public class Produto
    {
        [Key]
        [Column("Id")]
        [Required]
        public int Id { get; set; }

        [Column("Name")]
        [StringLength(100)]
        [Required]
        public string Nome { get; set; }

        [Column("Categoria")]
        [StringLength(50)]
        [Required]
        public string Categoria { get; set;}

        [Column("PrecoUnitario", TypeName ="decimal(9,2)")]
        [Required]
        public decimal PrecoUnitario { get; set; }

        //Muitas produtos
        public virtual ICollection<Compra> Compras { get; set; }

        public virtual ICollection<ProdutoPromocao> ProdutosPromocoes { get; set; }
    }
}
