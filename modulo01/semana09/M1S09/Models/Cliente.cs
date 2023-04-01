using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace M1S09.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        [Key]
        [Column("Id")]
        [Required]
        public int Id { get; set; }

        [Column("Name")]
        [StringLength(150)]
        [Required]
        public string Nome { get; set; }

        [Column("Endereco_Id")]
        [Required]
        public int EnderecoId { get;}


        //Propriedades virtuais

        [ForeignKey("EnderecoId")]
        public virtual Endereco EnderecoDeEntrega { get; set; }

        //Muitas compras
        public virtual List<Compra> Compras { get; set; }
    }
}
