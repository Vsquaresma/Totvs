
using System.Collections.Generic;
using Totvs.Domain.Entities;
using Totvs.Domain.Interfaces.Repositories;
using Totvs.Domain.Interfaces.Services;

namespace Totvs.Domain.Services
{
    public class EnderecoService : ServiceBase<Endereco>, IEnderecoService
    {
        private readonly IEnderecoRepository _enderecoRepository;

        public EnderecoService(IEnderecoRepository enderecoRepository)
            : base(enderecoRepository)
        {
            _enderecoRepository = enderecoRepository;
        }

        public IEnumerable<Endereco> BuscarPorNome(string nome)
        {
            return _enderecoRepository.BuscarPorNome(nome);
        }
    }
}
