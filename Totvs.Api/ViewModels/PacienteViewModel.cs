

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Totvs.Domain.Entities;

namespace Totvs.Api.ViewModels
{
    public class PacienteViewModel
    {
        [Key]
        public int PacienteId { get; set; }

        [Required(ErrorMessage = "O CPF é obrigatório", AllowEmptyStrings = false)]
        public string CPF { get; set; }
        [Required(ErrorMessage = "O Nome é obrigatório", AllowEmptyStrings = false)]
        [MinLength(10, ErrorMessage = "O Nome deve ter no mínimo 10 caracteres")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O Sobrenome é obrigatório", AllowEmptyStrings = false)]
        [MinLength(10, ErrorMessage = "O Sobrenome deve ter no mínimo 10 caracteres")]
        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "A Data de Nascimento é obrigatória", AllowEmptyStrings = false)]
        public DateTime DataNascimento { get; set; }
        [Required(ErrorMessage = "O Sexo é obrigatório", AllowEmptyStrings = false)]
        public string Sexo { get; set; }
        [Required(ErrorMessage = "O Nome da Mãe é obrigatório", AllowEmptyStrings = false)]
        [MinLength(10, ErrorMessage = "O Nome da Mãe deve ter no mínimo 10 caracteres")]
        public string NomeMae { get; set; }

        [Required(ErrorMessage = "A Naturalidade é obrigatório", AllowEmptyStrings = false)]
        [MinLength(10, ErrorMessage = "A Naturalidade ter no mínimo 10 caracteres")]
        public string Naturalidade { get; set; }
        public virtual IEnumerable<EnderecoViewModel> Enderecos { get; set; }

        internal static Paciente Map(PacienteViewModel paciente)
        {
            return new Paciente
            {
                PacienteId = paciente.PacienteId,
                CPF = paciente.CPF,
                Nome = paciente.Nome,
                Sobrenome = paciente.Sobrenome,
                DataNascimento = paciente.DataNascimento,
                Sexo = paciente.Sexo,
                NomeMae = paciente.NomeMae,
                Naturalidade = paciente.Naturalidade,
            };
        }

        internal static PacienteViewModel Map(Paciente paciente)
        {
            return new PacienteViewModel
            {
                PacienteId = paciente.PacienteId,
                CPF = paciente.CPF,
                Nome = paciente.Nome,
                Sobrenome = paciente.Sobrenome,
                DataNascimento = paciente.DataNascimento,
                Sexo = paciente.Sexo,
                NomeMae = paciente.NomeMae,
                Naturalidade = paciente.Naturalidade,
            };
        }

        internal static IEnumerable<PacienteViewModel> Map(IEnumerable<Paciente> enumerable)
        {
            return enumerable.Select(x => Map(x));
        }
    }
}