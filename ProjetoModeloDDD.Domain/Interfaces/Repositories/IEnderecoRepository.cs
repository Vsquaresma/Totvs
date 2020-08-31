using System.Collections.Generic;
using Totvs.Domain.Entities;

namespace Totvs.Domain.Interfaces.Repositories
{
    public interface IEnderecoRepository : IRepositoryBase<Endereco>
    {
        IEnumerable<Endereco> BuscarPorNome(string nome);
    }
}
