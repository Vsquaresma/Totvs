
using System.Data.Entity.ModelConfiguration;
using Totvs.Domain.Entities;

namespace Totvs.Infra.Data.EntityConfig
{
    public class EnderecoConfiguration : EntityTypeConfiguration<Endereco>
    {
        public EnderecoConfiguration()
        {
            HasKey(p => p.EnderecoId);

            Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(250);

            Property(p => p.Valor)
                .IsRequired();

            HasRequired(p => p.Paciente)
                .WithMany()
                .HasForeignKey(p => p.PacienteId);
        }
    }
}
