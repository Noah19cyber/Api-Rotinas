using ApiRotina.Models;
using Microsoft.EntityFrameworkCore;
using ApiRotina.Data;
using Microsoft.EntityFrameworkCore;


namespace ApiRotina.Data
{

    public class DataContext : DbContext
    {
        public DbSet<Tarefa> Tarefas { get; set; }


        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tarefa>().HasData
                (
            
                new Tarefa() {Id = 1, nome = "Estudar", horario = 14, Concluida = true, descricao = "Estudar Matematica"},
                new Tarefa() {Id = 2, nome = "Almoço", horario = 12, Concluida = false, descricao = "Almoçar"},
                new Tarefa() {Id = 3, nome = "Estudar2", horario = 07, Concluida = true, descricao = "Estudar Portugues"},
                new Tarefa() {Id = 4, nome = "jogar", horario = 16, Concluida = false, descricao = "jogar algum jogo"}
                
                );
        }


    }
    /* public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<DataContext>
        {
            public DataContext CreateDbContext(string[] args)
            {
                var optionsBuilder = new DbContextOptionsBuilder<DataContext>();
                optionsBuilder.UseSqlServer(""); // Altere para a sua string de conexão

                return new DataContext(optionsBuilder.Options);
            }
        }*/
}
