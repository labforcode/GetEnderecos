using GetEnderecos.Domain.Core.Interfaces.Repositories;
using GetEnderecos.Domain.Entities.Enderecos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GetEnderecos.Domain.Interfaces.Dapper.Enderecos
{
    public interface IEnderecoRepositoryDapper : IRepositoryBaseDapper<Endereco>
    {
        Task<Endereco> ObterEnderecoPorCep(string cep);

        Task<IEnumerable<Endereco>> ObterTodos();
    }
}
