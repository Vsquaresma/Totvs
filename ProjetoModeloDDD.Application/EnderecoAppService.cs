
using System.Collections.Generic;
using Totvs.Application.Interface;
using Totvs.Domain.Entities;
using Totvs.Domain.Interfaces.Services;

namespace Totvs.Application
{
    public class EnderecoAppService : AppServiceBase<Endereco>, IEnderecoAppService
    {
        private readonly IEnderecoService _enderecoService;

        public EnderecoAppService(IEnderecoService enderecoService)
            : base(enderecoService)
        {
            _enderecoService = enderecoService;
        }

        public IEnumerable<Endereco> BuscarPorNome(string nome)
        {
            return _enderecoService.BuscarPorNome(nome);
        }
    }
}
