
namespace Totvs.Domain.Entities
{
    public class Endereco
    {
        public int EnderecoId { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public bool Disponivel { get; set; }
        public int PacienteId { get; set; }
        public virtual Paciente Paciente { get; set; }
    }
}
