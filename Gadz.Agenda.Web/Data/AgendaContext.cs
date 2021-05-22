using Microsoft.EntityFrameworkCore;

namespace Gadz.Agenda.Web.Models
{
    public class AgendaContext : DbContext
    {
        static bool updated = false;

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<ClienteModel> Clientes { get; set; }
        public DbSet<TarefaModel> Tarefas { get; set; }
        public DbSet<AgendamentoModel> Agendamentos { get; set; }
        public DbSet<AssistenteModel> Funcionarios { get; set; }
        public DbSet<Diagnostico> Diagnosticos { get; set; }

        //public AgendaContext()
        //{
        //    if (!updated)
        //    {
        //        Database.Migrate();
        //        updated = true;
        //    }
        //}

        public AgendaContext(DbContextOptions<AgendaContext> options)
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
