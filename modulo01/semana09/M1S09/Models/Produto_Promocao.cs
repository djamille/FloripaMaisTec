using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace M1S09.Models
{
    [Table("Produto_Promocao")]
    public class ProdutoPromocao
    {
        [Key]
        [Column("Id")]
        [Required]
        public int Id { get; set; }

        [Column("Produto_Id")]
        [Required]
        public int ProdutoId { get; set; }

        [Column("Promocao_Id")]
        [Required]
        public int PromocaoId { get; set; }


        //Propriedades virtuais

        [ForeignKey("ProdutoId")]
        public virtual Produto Produto { get; set; }

        [ForeignKey("PromocaoId")]
        public virtual Promocao Promocao { get; set; }

    }
}
