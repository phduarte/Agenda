using Gadz.Agenda.Web.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gadz.Agenda.Data
{
    internal class CategoriaMapping : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("categorias");

            builder.HasKey(k => k.Id).HasName("pk_categorias");

            builder.Property(p => p.Id).HasColumnName("categoria_id");
            builder.Property(p => p.Nome).HasColumnName("categoria").HasMaxLength(30).IsRequired();

            builder.HasData(new Categoria[]
            {
                new Categoria 
                {
                    Id = 1,
                    Nome = "Trabalho"
                },
                new Categoria
                {
                    Id = 2,
                    Nome = "Hobby"
                },
                new Categoria
                {
                    Id = 3,
                    Nome = "Casa"
                },
                new Categoria
                {
                    Id = 4,
                    Nome = "Viagem"
                },
                new Categoria
                {
                    Id = 5,
                    Nome = "Saúde"
                }
            });
        }
    }
}