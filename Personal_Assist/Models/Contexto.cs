using _Personal_Assist_Beta.Models;
using Microsoft.EntityFrameworkCore;

namespace _Personal_Assist_Beta.Models
{
    //Criando a classe de contexto, que é responsavel por conectar com banco de dados e gerenciar as transações
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }


        //Criando os DBSets que são responsáveis por criar e executar as consultas de CRUD com banco, sendo Select, Update, Insert e Delete
        public DbSet<Empresa> Empresa { get; set; }
        public DbSet<Feedback> Feedback { get; set; }
        public DbSet<Servico> Servico { get; set; }
        public DbSet<Suporte> Suporte { get; set; }
}

    //README

    /*
        Para executa a migration deve utilizar o "Package Manager Console", caso ele não esteja disponivel 
        vá no menu "View>Other Windows>Package Manager Console"


        Execute os comandos Add-Migration e Update-Database para criar a migration e depois atualizar o banco de dados.

        Add-Migration initdb  

        Update-Database
      
     */


}
