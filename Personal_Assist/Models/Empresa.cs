using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace _Personal_Assist_Beta.Models
{
    //Define a classe como uma entidade mapeada para a tabela "tb_cliente" utilizando o entity framework
    [Table("TB_EMPRESA")]
    public class Empresa
    {
        // Define a propriedade "Id" como a chave primária da tabela
        [Key]
        public int Id { get; set; }

        //Coluna obrigatória e com no maximo 14 caracteres 
        [Required, MaxLength(14)]
        public string Cnpj { get; set; }

        //Coluna obrigatória e com no maximo 100 caracteres 
        [Required, MaxLength(100)]
        public string Nome { get; set; }

        //Coluna obrigatória e com no maximo 255 caracteres 
        [Required, MaxLength(255)]
        public string Objetivo { get; set; }

    }
}
