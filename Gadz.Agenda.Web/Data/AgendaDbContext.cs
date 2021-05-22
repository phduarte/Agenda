using Gadz.Agenda.Web.Domain;
using Microsoft.EntityFrameworkCore;

namespace Gadz.Agenda.Web.Data
{
    public class AgendaDbContext : DbContext
    {
        static bool updated = false;

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Tarefa> Tarefas { get; set; }
        public DbSet<Agendamento> Agendamentos { get; set; }
        public DbSet<Assistente> Assistentes { get; set; }
        public DbSet<Diagnostico> Diagnosticos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Tratamento> Tratamentos { get; set; }

        public AgendaDbContext(DbContextOptions<AgendaDbContext> options)
        {
            if (!updated)
            {
                Database.EnsureCreated();
                //Database.Migrate();
                updated = true;
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=agenda.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TarefaMapping());
        }
    }
}
