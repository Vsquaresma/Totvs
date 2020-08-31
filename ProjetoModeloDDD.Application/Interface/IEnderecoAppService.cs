
using System.Collections.Generic;
using Totvs.Domain.Entities;

namespace Totvs.Application.Interface
{
    public interface IEnderecoAppService : IAppServiceBase<Endereco>
    {
        IEnumerable<Endereco> BuscarPorNome(string nome);
    }
}
