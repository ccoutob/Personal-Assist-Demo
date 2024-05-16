using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace _Personal_Assist_Beta.Models
{
    //Define a classe como uma entidade mapeada para a tabela "tb_cliente" utilizando o entity framework
    [Table("TB_SERVICO")]
    public class Servico
    {
        // Define a propriedade "Id" como a chave primária da tabela
        [Key]
        public int Id { get; set; } 

        [Required, MaxLength(70)]
        public string Nome { get; set; }

        [Required, MaxLength(255)]
        public string Descricao { get; set; }

        [Required]
        public int Preco { get; set; }

        [Required, MaxLength(50)]
        public string Categoria { get; set; }
    }
}