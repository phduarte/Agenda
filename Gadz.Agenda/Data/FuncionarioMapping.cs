using Gadz.Agenda.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gadz.Agenda.Data
{
    internal class FuncionarioMapping : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            builder.ToTable("funcionarios");

            //builder.Property(p => p.Id).HasColumnName("funcionario_id").IsRequired();

            builder.HasOne(p => p.Gestor)
                .WithMany()
                .HasForeignKey("gestor_id")
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}