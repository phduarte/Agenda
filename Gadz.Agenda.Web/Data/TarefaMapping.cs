using Gadz.Agenda.Web.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gadz.Agenda.Web.Data
{
    internal class TarefaMapping : IEntityTypeConfiguration<Tarefa>
    {
        public void Configure(EntityTypeBuilder<Tarefa> builder)
        {
            builder.ToTable("tarefas");
            builder.HasKey(k => k.Id).HasName("pk_tarefas");

            builder.Property(p => p.Id).HasColumnName("tarefa_id");
            builder.Property(p => p.Nome).HasColumnName("tarefa").HasMaxLength(50).IsRequired();
            builder.Property(p => p.DataSolicitacao).HasColumnName("data_solicitacao").IsRequired();
            builder.Property(p => p.Observacao).HasColumnName("observacao").HasMaxLength(120).IsRequired();
            builder.Property(p => p.Status).HasColumnName("status").HasMaxLength(20).IsRequired();

            builder.HasOne(p => p.Responsavel)
                .WithMany()
                .HasForeignKey("responsavel_id")
                .HasConstraintName("fk_tarefas_responsaveis");

            builder.HasOne(p => p.Categoria)
                .WithMany()
                .HasForeignKey("categoria_id")
                .HasConstraintName("fk_tarefas_categorias");
        }
    }
}