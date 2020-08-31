
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Totvs.Api.ViewModels
{
    public class EnderecoViewModel
    {
        [Key]
        public int EnderecoId { get; set; }

        [Required(ErrorMessage = "Preencha o campo CEP")]
        public string CEP { get; set; }
        [Required(ErrorMessage = "Preencha o campo Rua")]
        public string Rua { get; set; }
        [Required(ErrorMessage = "Preencha o campo Número")]
        public string Numero { get; set; }

        [Required(ErrorMessage = "Preencha o campo Bairro")]
        public string Bairro { get; set; }
        [Required(ErrorMessage = "Preencha o campo Cidade")]
        public string Cidade { get; set; }
        [Required(ErrorMessage = "Preencha o campo Estado")]
        public string Estado { get; set; }

        public virtual PacienteViewModel Paciente { get; set; }
    }
}