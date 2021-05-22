﻿using Gadz.Agenda.Web.Domain;
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
        public DbSet<Assistente> Funcionarios { get; set; }
        public DbSet<Diagnostico> Diagnosticos { get; set; }

        //public AgendaContext()
        //{
        //    if (!updated)
        //    {
        //        Database.Migrate();
        //        updated = true;
        //    }
        //}

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
