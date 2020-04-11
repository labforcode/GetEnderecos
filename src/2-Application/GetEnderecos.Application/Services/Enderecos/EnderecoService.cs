using AutoMapper;
using GetEnderecos.Application.Interfaces.Enderecos;
using GetEnderecos.Application.ViewModels.Enderecos;
using GetEnderecos.Domain.Interfaces.Dapper.Enderecos;
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
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<EnderecoViewModel> ObterTodos()
        {
            //return _mapper.Map<EnderecoViewModel>(await _enderecoRepositoryDapper.ObterTodos());
            return null;
        }
    }
}
