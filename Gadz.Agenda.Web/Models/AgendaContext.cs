using Microsoft.EntityFrameworkCore;

namespace Gadz.Agenda.Web.Models
{
    public class AgendaContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<ClienteModel> Clientes { get; set; }
        public DbSet<TarefaModel> Tarefas { get; set; }
        public DbSet<AgendamentoModel> Agendamentos { get; set; }
        public DbSet<AssistenteModel> Funcionarios { get; set; }
        public DbSet<Diagnostico> Diagnosticos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=agenda.db");
    }
}
