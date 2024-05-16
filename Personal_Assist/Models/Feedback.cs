using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace _Personal_Assist_Beta.Models
{
    //Define a classe como uma entidade mapeada para a tabela "tb_cliente" utilizando o entity framework
    [Table("TB_FEEDBACK")]
    public class Feedback
    {
        // Define a propriedade "Id" como a chave primária da tabela
        [Key]
        public int Id { get; set; }

        [Required]
        public int Nota { get; set; }

        [Required, MaxLength(255)]
        public string Positivo { get; set; }

        [Required, MaxLength(255)]
        public string Negativo { get; set; }

    }
}
