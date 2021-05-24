using Gadz.Agenda.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gadz.Agenda.Data.Mappings
{
    internal class AgendamentoMapping : IEntityTypeConfiguration<Agendamento>
    {
        public void Configure(EntityTypeBuilder<Agendamento> builder)
        {
            builder.ToTable("agendamentos");

            builder.HasKey(k => k.Id);

            builder.Property(p => p.Id).HasColumnName("agendamento_id");
            builder.Property(p => p.DataFim).HasColumnName("data_fim");
            builder.Property(p => p.DataInicio).HasColumnName("data_inicio").IsRequired();
            builder.Property(p => p.DuracaoHoras).HasColumnName("duracao_horas").IsRequired();
            builder.Property(p => p.DuracaoMinutos).HasColumnName("duracao_minutos").IsRequired();
            builder.Property(p => p.Motivo).HasColumnName("motivo").IsRequired();
            builder.Property(p => p.PrazoHora).HasColumnName("prazo_horas").IsRequired();
            builder.Property(p => p.PrazoMinutos).HasColumnName("prazo_minutos").IsRequired();
            builder.Property(p => p.Substituicao).HasColumnName("subtituicao").IsRequired();
            builder.Property(p => p.Tipo).HasColumnName("tipo_agendamento").IsRequired();

            builder.HasOne(p => p.Cliente).WithMany().HasForeignKey("cliente_id").OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(p => p.Responsavel).WithMany().HasForeignKey("responsavel_id").OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(p => p.Tarefa).WithMany().HasForeignKey("tarefa_id").OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(p => p.Tratamentos).WithOne().HasForeignKey("agendamento_id").OnDelete(DeleteBehavior.Cascade);
        }
    }
}