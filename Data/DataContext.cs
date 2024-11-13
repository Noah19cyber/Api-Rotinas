using ApiRotina.Models;  // Certifique-se de que isso esteja no topo do arquivo
using Microsoft.EntityFrameworkCore;

 

namespace ApiRotina.Data
{
    public class DataContext : DbContext
    {
       
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

       
        public DbSet<Tarefa> Tarefas { get; set; }
    }
}
