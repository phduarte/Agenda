using Gadz.Agenda.Web.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gadz.Agenda.Web.Data
{
    internal class UsuarioMapping : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("usuarios");

            builder.Property(p => p.Id).HasColumnName("usuario_id");
            builder.Property(p => p.Login).HasColumnName("login");
            builder.Property(p => p.Senha).HasColumnName("senha");
            builder.Property(p => p.Ativo).HasColumnName("ativo");
        }
    }
}