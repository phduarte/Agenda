using Gadz.Agenda.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gadz.Agenda.Data.Mappings
{
    internal class TratamentoMapping : IEntityTypeConfiguration<Tratamento>
    {
        public void Configure(EntityTypeBuilder<Tratamento> builder)
        {
            builder.ToTable("tratamentos");

            builder.HasKey(k => k.Id).HasName("pk_tratamentos");

            builder.Property(p => p.Id).HasColumnName("tratamento_id");
            builder.Property(p => p.DataEnvio).HasColumnName("data_envio").IsRequired();
            builder.Property(p => p.Prazo).HasColumnName("prazo").IsRequired();
            builder.Property(p => p.Status).HasColumnName("status").IsRequired();
            builder.Property(p => p.Observacao).HasColumnName("observacoes");

            builder.HasOne(p => p.Diagnostico)
                .WithMany()
                .HasForeignKey("diagnostico_id")
                .HasConstraintName("fk_tratamentos_diagnosticos")
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}