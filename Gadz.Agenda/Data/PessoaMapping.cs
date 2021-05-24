using Gadz.Agenda.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gadz.Agenda.Data
{
    internal class PessoaMapping : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.ToTable("pessoas");

            builder.HasKey(k => k.Id).HasName("pk_pessoas");

            builder.Property(p => p.Id).HasColumnName("pessoa_id");
            builder.Property(p => p.Nome).HasColumnName("nome").IsRequired();
        }
    }
}