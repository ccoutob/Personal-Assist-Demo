using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace _Personal_Assist_Beta.Models
{
    //Define a classe como uma entidade mapeada para a tabela
    [Table("TB_SUPORTE")]
    public class Suporte
    {
        // Define a propriedade "Id" como a chave primária da tabela
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(255)]
        public string Problema { get; set; }

        [Required, MaxLength(30)]
        public string Status { get; set; }

        [Required, MaxLength(5)]
        public string Prioridade { get; set; }

    }
}