using Gadz.Agenda.Web.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gadz.Agenda.Web.Data
{
    internal class CategoriaMapping : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("categorias");

            builder.HasKey(k => k.Id).HasName("pk_categorias");

            builder.Property(p => p.Id).HasColumnName("categoria_id");
            builder.Property(p => p.Nome).HasColumnName("categoria").HasMaxLength(30).IsRequired();
        }
    }
}