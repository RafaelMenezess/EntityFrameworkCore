using Alura.Filmes.App.Negocio;
using Microsoft.EntityFrameworkCore;

namespace Alura.Filmes.App.Dados
{
    public class AluraFilmesContexto : DbContext
    {
        public DbSet<Ator> Atores { get; set; }
        public DbSet<Filme> Filmes { get; set; }
        public DbSet<FilmeAtor> Elenco { get; set; }
        public DbSet<Idioma> Idiomas { get; set; }
        public DbSet<Cliente> Clientes { get; internal set; }
        public DbSet<Funcionario> Funcionarios { get; internal set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Filmes;Trusted_connection=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AtorConfig());

            modelBuilder.ApplyConfiguration(new FilmeConfig());

            modelBuilder.ApplyConfiguration(new FilmeAtorConfig());

            modelBuilder.ApplyConfiguration(new IdiomaConfig());

            modelBuilder.ApplyConfiguration(new ClienteConfig());

            modelBuilder.ApplyConfiguration(new FuncionarioConfig());
        }
    }
}
