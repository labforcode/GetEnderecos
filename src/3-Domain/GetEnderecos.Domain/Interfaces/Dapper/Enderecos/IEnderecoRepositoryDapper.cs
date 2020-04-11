using GetEnderecos.Domain.Core.Interfaces.Repositories;
using GetEnderecos.Domain.Entities.Enderecos;
using System.Threading.Tasks;

namespace GetEnderecos.Domain.Interfaces.Dapper.Enderecos
{
    public interface IEnderecoRepositoryDapper : IRepositoryBaseDapper<Endereco>
    {
        Task<Endereco> ObterTodos();
    }
}
