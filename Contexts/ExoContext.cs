using Exo.WebApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace Exo.WebApi.Contexts
{
    public class ExoContext : DbContext
    {
        public ExoContext()
        {
        }
        public ExoContext(DbContextOptions<ExoContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                //String de conexao depende da máquina sendo usada
                optionsBuilder.UseSqlServer("User ID=sa;Password=19870416;Server=localhost;Database=ExoApi;Trusted_Connection=False;");

                // Exemplo 1 destring de conexão:
                // User ID= sa;Password admin;Server localhost;Database ExoApi + Trusted_Connection=False
                // Exemplo 2 de string de conexão:
                // Server= localhost SQLEXPRESS;Database ExoApi;Trusted_Connection True
            }
        }
        public DbSet<Projeto> Projetos { get; set; }
    }
}

