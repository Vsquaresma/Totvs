using System.Collections.Generic;
using Totvs.Domain.Entities;

namespace Totvs.Domain.Interfaces.Services
{
    public interface IEnderecoService : IServiceBase<Endereco>
    {
        IEnumerable<Endereco> BuscarPorNome(string nome);
    }
}
