using AutoMapper;
using GetEnderecos.Application.Interfaces.Enderecos;
using GetEnderecos.Application.ViewModels.Enderecos;
using GetEnderecos.Domain.Interfaces.Dapper.Enderecos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GetEnderecos.Application.Services.Enderecos
{
    public class EnderecoService : IEnderecoService
    {
        private readonly IEnderecoRepositoryDapper _enderecoRepositoryDapper;
        private readonly IMapper _mapper;

        public EnderecoService(IEnderecoRepositoryDapper enderecoRepositoryDapper,
                               IMapper mapper)
        {
            _enderecoRepositoryDapper = enderecoRepositoryDapper;
            _mapper = mapper;
        }

        /// <summary>
        /// Obtém um endereço pelo CEP
        /// </summary>
        /// <param name="cep"></param>
        /// <returns></returns>
        public async Task<EnderecoViewModel> ObterEnderecoPorCep(string cep)
        {
            return _mapper.Map<EnderecoViewModel>(await _enderecoRepositoryDapper.ObterEnderecoPorCep(cep));
        } 

        /// <summary>
        /// Obtém todos os endereços
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<EnderecoViewModel>> ObterTodos()
        {
            return _mapper.Map<IEnumerable<EnderecoViewModel>>(await _enderecoRepositoryDapper.ObterTodos());
        }
    }
}
