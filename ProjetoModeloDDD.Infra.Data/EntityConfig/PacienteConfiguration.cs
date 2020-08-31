

using System.Data.Entity.ModelConfiguration;
using Totvs.Domain.Entities;

namespace Totvs.Infra.Data.EntityConfig
{
    public class PacienteConfiguration : EntityTypeConfiguration<Paciente>
    {
        public PacienteConfiguration()
        {
            HasKey(c => c.PacienteId);

            Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.Sobrenome)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.CPF)
                .IsRequired();

            Property(c => c.DataNascimento)
                .IsRequired();

            Property(c => c.Sexo)
                .IsRequired();

            Property(c => c.NomeMae)
                .IsRequired();

            Property(c => c.Naturalidade)
                .IsRequired();

        }
    }
}
