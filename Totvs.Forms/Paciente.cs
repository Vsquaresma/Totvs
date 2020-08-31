using System;
using System.Collections.Generic;

namespace Totvs.Forms
{
    public class Paciente
    {
        public int PacienteId { get; set; }
        public string CPF { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Sexo { get; set; }
        public string NomeMae { get; set; }
        public string Naturalidade { get; set; }
        public virtual IEnumerable<Endereco> Enderecos { get; set; }
    }
}
