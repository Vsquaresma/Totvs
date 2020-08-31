
using System.Collections.Generic;
using System.Linq;
using Totvs.Domain.Entities;
using Totvs.Domain.Interfaces.Repositories;

namespace Totvs.Infra.Data.Repositories
{
    public class EnderecoRepository : RepositoryBase<Endereco>, IEnderecoRepository
    {
        public IEnumerable<Endereco> BuscarPorNome(string nome)
        {
            return Db.Enderecos.Where(p => p.Nome == nome);
        }
    }
}
