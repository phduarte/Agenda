using Gadz.Agenda.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Gadz.Agenda.Web
{
    public static class IoC
    {
        public static void AddAgendaDbContext(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<AgendaDbContext>(options =>
            {
                options.UseSqlite(connectionString);
            });
        }
    }
}
