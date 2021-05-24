using Gadz.Agenda.Web.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gadz.Agenda.Data
{
    internal class DiagnosticoMapping : IEntityTypeConfiguration<Diagnostico>
    {
        public void Configure(EntityTypeBuilder<Diagnostico> builder)
        {
            builder.ToTable("diagnosticos");

            builder.HasKey(k => k.Id);

            builder.Property(p => p.Id).HasColumnName("diagnostico_id");
            builder.Property(p => p.Descricao).HasColumnName("diagnostico");
        }
    }
}