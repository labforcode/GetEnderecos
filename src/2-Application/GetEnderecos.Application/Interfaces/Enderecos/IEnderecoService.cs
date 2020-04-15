using GetEnderecos.Application.ViewModels.Enderecos;
using GetEnderecos.Domain.Entities.Enderecos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GetEnderecos.Application.Interfaces.Enderecos
{
    public interface IEnderecoService : IServiceBase<Endereco>
    {
        Task<EnderecoViewModel> ObterEnderecoPorCep(string cep);

        Task<IEnumerable<EnderecoViewModel>> ObterTodos();
    }
}
